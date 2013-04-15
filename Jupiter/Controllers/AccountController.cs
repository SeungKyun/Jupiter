using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;
using System.Web.Security;
using Jupiter.Repository.Account;

namespace Jupiter.Controllers
{
    public class AccountController : Controller
    {

        //
        // GET: /Account/LogOn

        public ActionResult LogOn()
        {
            if (HttpContext.User.Identity.IsAuthenticated)
            {
                if (UserInfo.IsAdmin)
                    return RedirectToAction("Index", "ExamAdmin");
                else
                    return RedirectToAction("Index", "Exam");
            }
            return View();
        }

        //
        // POST: /Account/LogOn

        [HttpPost]
        public ActionResult LogOn(LogOnModel model, string returnUrl)
        {
            if (ModelState.IsValid)
            {
                if (Membership.ValidateUser(model.UserName, model.Password))
                {
                    FormsAuthentication.SetAuthCookie(model.UserName, model.RememberMe);
                    bool isAdmin = Roles.IsUserInRole("Administrators");
                    //System.Web.Profile.DefaultProfile.Create("").SetPropertyValue("RealName", )
                    var a = System.Web.Profile.DefaultProfile.Properties["RealName"];
                    var b = System.Web.Profile.ProfileManager.GetAllProfiles(System.Web.Profile.ProfileAuthenticationOption.Authenticated);
                    if (returnUrl != null && Url.IsLocalUrl(returnUrl) && returnUrl.Length > 1 && returnUrl.StartsWith("/")
                        && !returnUrl.StartsWith("//") && !returnUrl.StartsWith("/\\"))
                    {
                        return Redirect(returnUrl);
                    }
                    else
                    {
                        if (isAdmin)
                            return RedirectToAction("Index", "ExamAdmin");
                        else
                            return RedirectToAction("Index", "Exam");
                    }
                }
                else
                {
                    ModelState.AddModelError("", "제공한 사용자 이름 또는 암호가 잘못되었습니다.");
                }
            }

            // 이 경우 오류가 발생한 것이므로 폼을 다시 표시하십시오.
            return View(model);
        }

        //
        // GET: /Account/LogOff

        public ActionResult LogOff()
        {
            FormsAuthentication.SignOut();

            return RedirectToAction("LogOn");
        }

        //
        // GET: /Account/Register

        public ActionResult Register()
        {
            return View();
        }

        //
        // POST: /Account/Register

        [HttpPost]
        public ActionResult Register(RegisterModel model)
        {
            if (ModelState.IsValid)
            {
                // 사용자를 등록해 보십시오.
                MembershipCreateStatus createStatus;
                MembershipUser user = Membership.CreateUser(model.UserName, model.Password, model.Email, null, null, true, null, out createStatus);

                if (createStatus == MembershipCreateStatus.Success)
                {
                    //AccountRepository.CreateMembershipExtend(model);
                    System.Web.Profile.DefaultProfile.Create(model.UserName).SetPropertyValue("RealName", model.RealName);
                    return RedirectToAction("Index", "AccountAdmin");
                    //FormsAuthentication.SetAuthCookie(model.UserName, false /* createPersistentCookie */);
                    //return RedirectToAction("LogOn");
                }
                else
                {
                    ModelState.AddModelError("", ErrorCodeToString(createStatus));
                }
            }

            // 이 경우 오류가 발생한 것이므로 폼을 다시 표시하십시오.
            return View(model);
        }

        //
        // GET: /Account/ChangePassword

        [Authorize]
        public ActionResult ChangePassword()
        {
            return View();
        }

        //
        // POST: /Account/ChangePassword

        [Authorize]
        [HttpPost]
        public ActionResult ChangePassword(ChangePasswordModel model)
        {
            if (ModelState.IsValid)
            {

                // ChangePassword는 특정 실패 시나리오에서 false를 반환하지 않고
                // 예외를 throw합니다.
                bool changePasswordSucceeded;
                try
                {
                    MembershipUser currentUser = Membership.GetUser(User.Identity.Name, true /* userIsOnline */);
                    changePasswordSucceeded = currentUser.ChangePassword(model.OldPassword, model.NewPassword);
                }
                catch (Exception)
                {
                    changePasswordSucceeded = false;
                }

                if (changePasswordSucceeded)
                {
                    return RedirectToAction("ChangePasswordSuccess");
                }
                else
                {
                    ModelState.AddModelError("", "현재 암호가 정확하지 않거나 새 암호가 잘못되었습니다.");
                }
            }

            // 이 경우 오류가 발생한 것이므로 폼을 다시 표시하십시오.
            return View(model);
        }

        //
        // GET: /Account/ChangePasswordSuccess

        public ActionResult ChangePasswordSuccess()
        {
            return View();
        }

        #region Status Codes
        private static string ErrorCodeToString(MembershipCreateStatus createStatus)
        {
            // 전체 상태 코드 목록은 http://go.microsoft.com/fwlink/?LinkID=177550을
            // 참조하십시오.
            switch (createStatus)
            {
                case MembershipCreateStatus.DuplicateUserName:
                    return "사용자 이름이 이미 있습니다. 다른 사용자 이름을 입력하십시오.";

                case MembershipCreateStatus.DuplicateEmail:
                    return "해당 전자 메일 주소를 가진 사용자 이름이 이미 있습니다. 다른 전자 메일 주소를 입력하십시오.";

                case MembershipCreateStatus.InvalidPassword:
                    return "제공한 암호가 잘못되었습니다. 올바른 암호 값을 입력하십시오.";

                case MembershipCreateStatus.InvalidEmail:
                    return "제공한 전자 메일 주소가 잘못되었습니다. 값을 확인한 후 다시 시도하십시오.";

                case MembershipCreateStatus.InvalidAnswer:
                    return "제공한 암호 찾기 대답이 잘못되었습니다. 값을 확인한 후 다시 시도하십시오.";

                case MembershipCreateStatus.InvalidQuestion:
                    return "제공한 암호 찾기 질문이 잘못되었습니다. 값을 확인한 후 다시 시도하십시오.";

                case MembershipCreateStatus.InvalidUserName:
                    return "제공한 사용자 이름이 잘못되었습니다. 값을 확인한 후 다시 시도하십시오.";

                case MembershipCreateStatus.ProviderError:
                    return "인증 공급자가 오류를 반환했습니다. 입력한 내용을 확인하고 다시 시도하십시오. 문제가 계속되면 시스템 관리자에게 문의하십시오.";

                case MembershipCreateStatus.UserRejected:
                    return "사용자 생성 요청이 취소되었습니다. 입력한 내용을 확인하고 다시 시도하십시오. 문제가 계속되면 시스템 관리자에게 문의하십시오.";

                default:
                    return "알 수 없는 오류가 발생했습니다. 입력한 내용을 확인하고 다시 시도하십시오. 문제가 계속되면 시스템 관리자에게 문의하십시오.";
            }
        }
        #endregion
    }
}
