/****************************************************************************************
 * Copyright(c) Seungkyun,Park/박승균 (qkrtmdrbs@gmail.com)
 * 본 소스는 저작자의 개인소유자산입니다.
 * 본 소스를 원저작자의 허락없이 무단으로 변형,판매,가공시에는 저작권법에 위반됩니다.
 ****************************************************************************************/
using System;
using System.Web.Mvc;

namespace Jupiter.Repository.ExceptionHandle
{
    public class MVCErrorHandler : HandleErrorAttribute
    {
        /// <summary>
        /// 기본 생성자
        /// </summary>
        public MVCErrorHandler()
        {
        }

        /// <summary>
        /// 오류정보를 표시할 뷰를 지정합니다.
        /// </summary>
        /// <param name="view">오류정보를 표시할 뷰 이름</param>
        public MVCErrorHandler(string view)
        {
            base.View = view;
        }

        /// <summary>
        /// MVC Framework 전반에 걸쳐 오류 발생시 호출됩니다.
        /// </summary>
        /// <param name="filterContext">MVC Framework의 예외정보 컨텍스트</param>
        public override void OnException(ExceptionContext filterContext)
        {
            new ExceptionRepository().WriteToDB(filterContext);

            base.OnException(filterContext);
        }
    }
}
