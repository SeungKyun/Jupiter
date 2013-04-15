using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;
using Jupiter.Repository.Account;

namespace Jupiter.Controllers
{
  [Authorize(Roles = "Administrators")]
  public class AccountAdminController : Controller
  {
      /*
    //
    // GET: /AccountAdmin/

    public ViewResult Index(int? page, int? pageSize)
    {
      int iPage = page ?? 0;
      int iPageSize = pageSize ?? 10;

      PagedList<RegisterModel> model = AccountComponent.GetRegisterModels(iPage, iPageSize);

      return View(model);
    }

    //
    // GET: /AccountAdmin/Details/5

    public ViewResult Details(Guid id)
    {
      vw_aspnet_MembershipUsers vw_aspnet_membershipusers = db.vw_aspnet_MembershipUsers.Single(v => v.UserId == id);
      return View(vw_aspnet_membershipusers);
    }

    //
    // GET: /AccountAdmin/Create

    public ActionResult Create()
    {
      return View();
    }

    //
    // POST: /AccountAdmin/Create

    [HttpPost]
    public ActionResult Create(vw_aspnet_MembershipUsers vw_aspnet_membershipusers)
    {
      if (ModelState.IsValid)
      {
        vw_aspnet_membershipusers.UserId = Guid.NewGuid();
        db.vw_aspnet_MembershipUsers.AddObject(vw_aspnet_membershipusers);
        db.SaveChanges();
        return RedirectToAction("Index");
      }

      return View(vw_aspnet_membershipusers);
    }

    //
    // GET: /AccountAdmin/Edit/5

    public ActionResult Edit(Guid id)
    {
      vw_aspnet_MembershipUsers vw_aspnet_membershipusers = db.vw_aspnet_MembershipUsers.Single(v => v.UserId == id);
      return View(vw_aspnet_membershipusers);
    }

    //
    // POST: /AccountAdmin/Edit/5

    [HttpPost]
    public ActionResult Edit(vw_aspnet_MembershipUsers vw_aspnet_membershipusers)
    {
      if (ModelState.IsValid)
      {
        db.vw_aspnet_MembershipUsers.Attach(vw_aspnet_membershipusers);
        db.ObjectStateManager.ChangeObjectState(vw_aspnet_membershipusers, EntityState.Modified);
        db.SaveChanges();
        return RedirectToAction("Index");
      }
      return View(vw_aspnet_membershipusers);
    }

    //
    // GET: /AccountAdmin/Delete/5

    public ActionResult Delete(Guid id)
    {
      vw_aspnet_MembershipUsers vw_aspnet_membershipusers = db.vw_aspnet_MembershipUsers.Single(v => v.UserId == id);
      return View(vw_aspnet_membershipusers);
    }

    //
    // POST: /AccountAdmin/Delete/5

    [HttpPost, ActionName("Delete")]
    public ActionResult DeleteConfirmed(Guid id)
    {
      vw_aspnet_MembershipUsers vw_aspnet_membershipusers = db.vw_aspnet_MembershipUsers.Single(v => v.UserId == id);
      db.vw_aspnet_MembershipUsers.DeleteObject(vw_aspnet_membershipusers);
      db.SaveChanges();
      return RedirectToAction("Index");
    }

    protected override void Dispose(bool disposing)
    {
      db.Dispose();
      base.Dispose(disposing);
    }*/
  }
}