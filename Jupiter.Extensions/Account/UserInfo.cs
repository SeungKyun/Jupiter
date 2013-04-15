using System;
using System.Collections.Generic;
using System.Globalization;
using System.Web.Mvc;
using System.Web.Security;
using System.Web;

namespace Jupiter
{
    /// <summary>
    /// 로그인한 사용자 정보
    /// 로그인 시 쿠키에 저장됩니다.
    /// </summary>
    public static class UserInfo
    {
        /// <summary>
        /// 쿠키 명
        /// </summary>
        static string CookieName = string.Format("UserInfo{0}{1}", System.Web.HttpContext.Current.Request.Url.DnsSafeHost, System.Web.HttpContext.Current.Request.Url.Port);

        /// <summary>
        /// 로그인한 사용자 정보 쿠키에 저장
        /// </summary>
        /// <param name="siteId"></param>
        /// <param name="userID"></param>
        /// <param name="userName"></param>
        /// <param name="orgName"></param>
        /// <param name="email"></param>
        /// <param name="stemUserID"></param>
        /// <param name="mobile"></param>
        /// <param name="isDisPersonApproval">장애인 승인 여부</param>
        public static void CreateUserInfo(string userName, string realName, bool isAdmin)
        {
            System.Web.HttpCookie cookie = new System.Web.HttpCookie(CookieName);
            cookie.Expires = DateTime.Now.AddDays(1);
            cookie.Values.Add("UserName", System.Web.HttpUtility.UrlEncode(userName));
            cookie.Values.Add("OrgName", System.Web.HttpUtility.UrlEncode(realName));
            cookie.Values.Add("Email", System.Web.HttpUtility.UrlEncode(isAdmin.ToString()));

            System.Web.HttpContext.Current.Response.Cookies.Add(cookie);
        }

        /// <summary>
        /// 로그인한 사용자 정보 쿠키 삭제
        /// </summary>
        public static void RemoveUserInfo()
        {
            System.Web.HttpCookie cookie = new System.Web.HttpCookie(CookieName);
            cookie.Expires = DateTime.Now.AddDays(-1);
            System.Web.HttpContext.Current.Response.Cookies.Add(cookie);
        }

        /// <summary>
        /// 로그인한 사용자 정보 세션 또는 쿠키값 가져오기
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        [HandleError]
        private static string GetValue(string name)
        {
            if (System.Web.HttpContext.Current.Request.Cookies[CookieName] != null)
            {
                return System.Web.HttpContext.Current.Request.Cookies[CookieName][name];
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// 로그인한 사용자 정보 세션값 저장하기
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        [HandleError]
        private static void SetValue(string name, string val)
        {
            if (System.Web.HttpContext.Current.Request.Cookies[CookieName] != null)
            {
                System.Web.HttpContext.Current.Request.Cookies[CookieName][name] = System.Web.HttpUtility.UrlEncode(val);
            }
        }

        /// <summary>
        /// 인스턴스 존재(사용가능) 여부리턴
        /// </summary>
        /// <returns></returns>
        public static bool Exists()
        {
            return System.Web.HttpContext.Current.Request.Cookies[CookieName] != null;
        }

        /// <summary>
        /// 사용자아이디
        /// </summary>
        public static string UserName
        {
            get { return System.Web.HttpUtility.UrlDecode(GetValue("UserName")); }
        }

        /// <summary>
        /// 사용자한글이름
        /// </summary>
        public static string RealName
        {
            get { return System.Web.HttpUtility.UrlDecode(GetValue("RealName")); }
        }

        /// <summary>
        /// 관리자여부
        /// </summary>
        public static bool IsAdmin
        {
            get { return string.IsNullOrEmpty(GetValue("IsAdmin")) ? false : bool.Parse(GetValue("IsAdmin")); }
        }
    }
}