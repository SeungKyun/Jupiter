/****************************************************************************************
 * Copyright(c) Seungkyun,Park/박승균 (qkrtmdrbs@gmail.com)
 * 본 소스는 저작자의 개인소유자산입니다.
 * 본 소스를 원저작자의 허락없이 무단으로 변형,판매,가공시에는 저작권법에 위반됩니다.
 ****************************************************************************************/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;

namespace Jupiter.Repository.ExceptionHandle
{
    /// <summary>
    /// 데이터 저장소로 데이터베이스를 사용하여 예외정보를 처리합니다.
    /// </summary>
    public class ExceptionRepository : IExceptionRepository
    {
        /// <summary>
        /// 저장소(데이터베이스 객체모델)
        /// </summary>
        public ExceptionHandleEntities _db { get; private set; }

        /// <summary>
        /// 기본 생성자
        /// </summary>
        public ExceptionRepository()
        {
            _db = new ExceptionHandleEntities();
        }

        /// <summary>
        /// 생성자
        /// </summary>
        /// <param name="db">저장소(데이터베이스 객체모델)</param>
        public ExceptionRepository(ExceptionHandleEntities db)
        {
            _db = db;
        }

        public void WriteToDB(System.Web.Mvc.ExceptionContext filterContext)
        {
            Exception ex = filterContext.Exception;
            System.Web.HttpContextBase httpContext = filterContext.HttpContext;

            Exception exception = ex;
            int idx = 0;
            while (exception.InnerException != null)
            {
                exception = exception.InnerException;

                idx++;
                if (idx == 100)
                    break;
            }

            common_Exceptions error = new common_Exceptions();
            error.Message = exception.Message;
            error.Source = exception.Source;
            error.StackTrace = exception.StackTrace;
            if (httpContext != null)
            {
                error.UserName = httpContext.User.Identity.Name;
                error.Url = httpContext.Request.Url == null ? null : httpContext.Request.Url.ToString();
                error.UrlReferrer = httpContext.Request.UrlReferrer == null ? null : httpContext.Request.UrlReferrer.ToString();
                error.UserHostName = httpContext.Request.UserHostName;
                error.UserHostAddress = httpContext.Request.UserHostAddress;
            }
            error.CreateDate = DateTime.Now;
            error.Exceptions_StateId = 1;

            _db.common_Exceptions.AddObject(error);
            _db.SaveChanges();
        }

        public List<common_Exceptions> GetExceptionList(int? page, int? pageSize, DateTime? begin, DateTime? end)
        {
            page = page ?? 0;
            pageSize = pageSize ?? 15;

            var query = _db.common_Exceptions.Include("common_Exceptions_State")
                .OrderByDescending(m => m.CreateDate)
                .Skip(page.Value * pageSize.Value).Take(pageSize.Value);
            if (begin.HasValue)
                query = query.Where(m => m.CreateDate > begin);
            if (end.HasValue)
                query = query.Where(m => m.CreateDate < end);

            return query.ToList();
        }

        public common_Exceptions GetException(long id)
        {
            return _db.common_Exceptions.Include("common_Exceptions_State")
                .FirstOrDefault(m => m.Id.Equals(id));
        }

        public common_Exceptions GetExceptionWithHandles(long id)
        {
            return _db.common_Exceptions.Include("common_Exceptions_State").Include("common_Exceptions_Handle")
                .FirstOrDefault(m => m.Id.Equals(id));
        }

        public List<common_Exceptions_Handle> GetExceptionHandles(long exceptionId)
        {
            var query = _db.common_Exceptions_Handle.Where(m => m.ExceptionId.Equals(exceptionId));
            return query.ToList();
        }

        public void CreateExceptionHandles(ExceptionHandleModel model)
        {
            model.CreateDate = DateTime.Now;
            model.UserName = HttpContext.Current.User.Identity.Name;

            common_Exceptions_Handle exceptionsHandle = new common_Exceptions_Handle();
            ModelCopier.CopyModel(model, exceptionsHandle);

            _db.common_Exceptions_Handle.AddObject(exceptionsHandle);
            _db.SaveChanges();
        }
    }
}