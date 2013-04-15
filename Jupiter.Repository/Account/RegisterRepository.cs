using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Jupiter.Repository.Account;

namespace Jupiter.Repository.Account
{
    public class RegisterRepository : IAccountRepository
    {
        private AccountEntities _db = new AccountEntities();

        #region IRepository<RegisterModel>

        public void Insert(RegisterModel model)
        {
            throw new NotImplementedException();
        }

        public void Insert(List<RegisterModel> models)
        {
            throw new NotImplementedException();
        }

        public RegisterModel GetById(object id)
        {
            throw new NotImplementedException();
        }

        public List<RegisterModel> GetById(List<object> ids)
        {
            throw new NotImplementedException();
        }

        public PagedList<RegisterModel> GetAll(int? page, int? pageSize)
        {
            throw new NotImplementedException();
        }

        public void Delete(RegisterModel model)
        {
            throw new NotImplementedException();
        }

        public void Delete(List<RegisterModel> models)
        {
            throw new NotImplementedException();
        }

        public int SaveChanges()
        {
            throw new NotImplementedException();
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }

        #endregion


        #region IAccountRepository

        public void UpdateRealName(string userName, string realName)
        {
            throw new NotImplementedException();
        }

        public void CreateMembershipExtend(RegisterModel model)
        {
            throw new NotImplementedException();
        }

        public PagedList<RegisterModel> GetRegisterModels(int iPage, int iPageSize)
        {
            throw new NotImplementedException();
        }

        public IQueryable<RegisterModel> QueryToRegisterModel(IQueryable<aspnet_Membership> query)
        {
            throw new NotImplementedException();
        }

        public List<aspnet_Users> GetAllUsers()
        {
            throw new NotImplementedException();
        }

        public List<aspnet_Users> GetUsersByClassId(byte classId)
        {
            throw new NotImplementedException();
        }

        public List<aspnet_Membership_Class> GetAllClasses()
        {
            throw new NotImplementedException();
        }

        public List<aspnet_Membership_Class> GetAllClassesWithGrade()
        {
            throw new NotImplementedException();
        }

        public List<aspnet_Membership_Class> GetClasses(byte gradeId)
        {
            throw new NotImplementedException();
        }

        public List<aspnet_Membership_Class> GetClassesWithGrade(byte gradeId)
        {
            throw new NotImplementedException();
        }

        public List<aspnet_Membership_Grade> GetAllGrades()
        {
            throw new NotImplementedException();
        }

        #endregion
    }
}