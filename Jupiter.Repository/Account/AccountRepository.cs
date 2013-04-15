using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Jupiter.Repository.Account;

namespace Jupiter.Repository.Account
{
    public static class AccountRepository
    {
        //private AccountEntities db = new AccountEntities();

        public static void UpdateRealName(string userName, string realName)
        {
            using (AccountEntities db = new AccountEntities())
            {
                var user = db.aspnet_Users.FirstOrDefault(m => m.UserName.Equals(userName));
                if (user != null)
                {
                    user.RealName = realName;
                    db.SaveChanges();
                }
            }
        }

        public static void CreateMembershipExtend(RegisterModel model)
        {
            using (AccountEntities db = new AccountEntities())
            {
                aspnet_Users user = db.aspnet_Users.Include("aspnet_Membership").FirstOrDefault(m => m.UserName.Equals(model.UserName));
                user.RealName = model.RealName;
                user.LastActivityDate = DateTime.Now;
                user.aspnet_Membership.CreateDate = DateTime.Now;

                aspnet_Membership_Extend extend = new aspnet_Membership_Extend();
                extend.Post = model.Post;
                extend.Address = model.Address;
                extend.SchoolName = model.SchoolName;
                extend.SchoolGrade = model.SchoolGrade;
                extend.HomePhone = model.HomePhone;
                extend.ChurchName = model.ChurchName;
                extend.ChurchRole = model.ChurchRole;
                extend.Gender = model.Gender;
                db.aspnet_Membership_Extend.AddObject(extend);

                db.SaveChanges();
            }
        }

        public static PagedList<RegisterModel> GetRegisterModels(int iPage, int iPageSize)
        {
            PagedList<RegisterModel> model = null;

            using (AccountEntities db = new AccountEntities())
            {
                IQueryable<aspnet_Membership> query = db.aspnet_Membership
                  .Include("aspnet_Users")
                  .Include("aspnet_Membership_Extend")
                  .OrderByDescending(m => m.CreateDate);
                model = QueryToRegisterModel(query).ToPagedList(iPage, iPageSize);
            }
            return model;
        }

        private static IQueryable<RegisterModel> QueryToRegisterModel(IQueryable<aspnet_Membership> query)
        {
            return query.Select(m => new RegisterModel
            {
                UserName = m.aspnet_Users.UserName,
                RealName = m.aspnet_Users.RealName,
                Password = m.Password,
                Email = m.Email,
                MobilePIN = m.MobilePIN,
                CreateDate = m.CreateDate,
                Comment = m.Comment,
                ClassId = m.aspnet_Membership_Extend.ClassId,
                Post = m.aspnet_Membership_Extend.Post,
                Address = m.aspnet_Membership_Extend.Address,
                ChurchName = m.aspnet_Membership_Extend.ChurchName,
                ChurchRole = m.aspnet_Membership_Extend.ChurchRole,
                HomePhone = m.aspnet_Membership_Extend.HomePhone,
                SchoolName = m.aspnet_Membership_Extend.SchoolName,
                SchoolGrade = m.aspnet_Membership_Extend.SchoolGrade,
                Gender = m.aspnet_Membership_Extend.Gender,
                IsAdmin = (m.aspnet_Users.aspnet_Roles.Count(s => s.RoleName.Equals("관리자")) > 0)
            });
        }

        public static List<aspnet_Users> GetAllUsers()
        {
            List<aspnet_Users> model = null;

            using (AccountEntities db = new AccountEntities())
            {
                model = db.aspnet_Users.ToList();
            }

            return model;
        }


        public static List<aspnet_Users> GetUsersByClassId(byte classId)
        {
            List<aspnet_Users> model = null;

            using (AccountEntities db = new AccountEntities())
            {
                model = (from mem in db.aspnet_Membership_Extend
                         join user in db.aspnet_Users on mem.UserId equals user.UserId
                         where mem.ClassId.Equals(classId)
                         select user).ToList();
            }

            return model;
        }

        public static List<aspnet_Membership_Class> GetAllClasses()
        {
            List<aspnet_Membership_Class> model = null;

            using (AccountEntities db = new AccountEntities())
            {
                model = db.aspnet_Membership_Class.Include("aspnet_Membership_Grade").ToList();
            }

            return model;
        }

        public static List<aspnet_Membership_Class> GetAllClassesWithGrade()
        {
            List<aspnet_Membership_Class> model = null;

            using (AccountEntities db = new AccountEntities())
            {
                model = db.aspnet_Membership_Class.Include("aspnet_Membership_Grade").ToList();
            }

            return model;
        }

        public static List<aspnet_Membership_Class> GetClasses(byte gradeId)
        {
            List<aspnet_Membership_Class> model = null;

            using (AccountEntities db = new AccountEntities())
            {
                model = db.aspnet_Membership_Class.Where(m => m.GradeId.Equals(gradeId)).ToList();
            }

            return model;
        }

        public static List<aspnet_Membership_Class> GetClassesWithGrade(byte gradeId)
        {
            List<aspnet_Membership_Class> model = null;

            using (AccountEntities db = new AccountEntities())
            {
                model = db.aspnet_Membership_Class.Include("Grade").Where(m => m.GradeId.Equals(gradeId)).ToList();
            }

            return model;
        }

        public static List<aspnet_Membership_Grade> GetAllGrades()
        {
            List<aspnet_Membership_Grade> model = null;

            using (AccountEntities db = new AccountEntities())
            {
                model = db.aspnet_Membership_Grade.ToList();
            }

            return model;
        }
    }
}