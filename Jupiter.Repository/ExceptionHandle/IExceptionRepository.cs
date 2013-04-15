/****************************************************************************************
 * Copyright(c) Seungkyun,Park/박승균 (qkrtmdrbs@gmail.com)
 * 본 소스는 저작자의 개인소유자산입니다.
 * 본 소스를 원저작자의 허락없이 무단으로 변형,판매,가공시에는 저작권법에 위반됩니다.
 ****************************************************************************************/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Jupiter.Repository.ExceptionHandle
{
    /// <summary>
    /// 예외정보를 처리합니다.
    /// </summary>
    public interface IExceptionRepository
    {
        /// <summary>
        /// 예외정보를 저장합니다.
        /// </summary>
        /// <param name="filterContext">MVC Framework의 예외정보 컨텍스트</param>
        void WriteToDB(System.Web.Mvc.ExceptionContext filterContext);

        /// <summary>
        /// 예외정보 리스트를 가져옵니다.
        /// </summary>
        /// <param name="page">페이지 번호</param>
        /// <param name="pageSize">페이지 크기</param>
        /// <param name="begin">시작일(검색조건)</param>
        /// <param name="end">종료일(검색조건)</param>
        /// <returns>예외정보 리스트</returns>
        List<common_Exceptions> GetExceptionList(int? page, int? pageSize, DateTime? begin, DateTime? end);

        /// <summary>
        /// 예외상세정보를 가져옵니다.
        /// </summary>
        /// <param name="id">예외 식별키</param>
        /// <returns>예외상세정보</returns>
        common_Exceptions GetException(long id);

        /// <summary>
        /// 예외상세정보와 예외처리내역을 가져옵니다.
        /// </summary>
        /// <param name="id">예외 식별키</param>
        /// <returns>예외상세정보와 예외처리내역</returns>
        common_Exceptions GetExceptionWithHandles(long id);

        /// <summary>
        /// 예외처리결과 리스트를 가져옵니다.
        /// </summary>
        /// <param name="exceptionId">예외 식별키</param>
        /// <returns>예외처리결과 리스트</returns>
        List<common_Exceptions_Handle> GetExceptionHandles(long exceptionId);

        /// <summary>
        /// 예외처리결과를 저장합니다.
        /// </summary>
        /// <param name="model">예외처리결과</param>
        void CreateExceptionHandles(ExceptionHandleModel model);
    }
}