using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Jupiter.Repository.ExceptionHandle;

namespace Jupiter.Controllers
{ 
    public class ExceptionController : Controller
    {
        /// <summary>
        /// 예외정보처리 저장소
        /// </summary>
        IExceptionRepository _exceptionRepository;

        /// <summary>
        /// 기본생성자
        /// </summary>
        public ExceptionController()
        {
            _exceptionRepository = new ExceptionRepository();
        }

        /// <summary>
        /// 생성자
        /// </summary>
        /// <param name="exceptionRepository">예외정보처리 저장소</param>
        public ExceptionController(IExceptionRepository exceptionRepository)
        {
            _exceptionRepository = exceptionRepository;
        }

        /// <summary>
        /// 예외정보 리스트
        /// </summary>
        /// <param name="page">페이지 번호</param>
        /// <param name="pageSize">페이지 크기</param>
        /// <returns>예외정보 리스트</returns>
        public ViewResult Index(int? page, int? pageSize)
        {
            var model = _exceptionRepository.GetExceptionList(page, pageSize, null, null);
            return View(model);
        }

        /// <summary>
        /// 예외상세정보와 예외처리내역
        /// </summary>
        /// <param name="id">예외 식별키</param>
        /// <returns>예외상세정보와 예외처리내역</returns>
        public ViewResult Details(long id)
        {
            var model = _exceptionRepository.GetException(id);
            return View(model);
        }

        /// <summary>
        /// 예외처리내역
        /// </summary>
        /// <param name="exceptionId">예외 식별키</param>
        /// <returns></returns>
        public ViewResult ExceptionHandleList(long id)
        {
            ViewBag.exceptionId = id;
            var model = _exceptionRepository.GetExceptionHandles(id);
            return View(model);
        }

        /// <summary>
        /// 예외처리내역 등록폼
        /// </summary>
        /// <param name="exceptionId"></param>
        /// <returns></returns>
        public ViewResult ExceptionHandleCreate(long id)
        {
            ExceptionHandleModel model = new ExceptionHandleModel();
            model.ExceptionId = id;
            return View(model);
        }

        /// <summary>
        /// 예외처리내역 등록처리
        /// </summary>
        /// <param name="exceptionId"></param>
        /// <returns></returns>
        [AcceptVerbs(HttpVerbs.Post)]
        public JsonResult ExceptionHandleCreate(ExceptionHandleModel model)
        {
            if (ModelState.IsValid)
            {
                _exceptionRepository.CreateExceptionHandles(model);
                return Json(new { Result = true, Data = model });
            }

            string[] errors = ModelState.Where(m => m.Value.Errors.Count > 0).Select(m => m.Value.Errors[0].ErrorMessage).ToArray();
            return Json(new { Result = false, Data = errors });
        }
    }
}