using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Jupiter.Repository.Account;

namespace Jupiter.Repository.Account
{
    public interface IAccountRepository : IRepository<RegisterModel>
    {
        void UpdateRealName(string userName, string realName);
        void CreateMembershipExtend(RegisterModel model);
        PagedList<RegisterModel> GetRegisterModels(int iPage, int iPageSize);
        IQueryable<RegisterModel> QueryToRegisterModel(IQueryable<aspnet_Membership> query);
        List<aspnet_Users> GetAllUsers();
        List<aspnet_Users> GetUsersByClassId(byte classId);
        List<aspnet_Membership_Class> GetAllClasses();
        List<aspnet_Membership_Class> GetAllClassesWithGrade();
        List<aspnet_Membership_Class> GetClasses(byte gradeId);
        List<aspnet_Membership_Class> GetClassesWithGrade(byte gradeId);
        List<aspnet_Membership_Grade> GetAllGrades();
    }
}