using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Jupiter.Components.DBModels;
using Jupiter.Components.Common;
using Jupiter.Components.ViewModels;

namespace Jupiter.Controllers
{
  [Authorize(Roles = "Administrators")]
  public class ExamAdminController : BaseController
  {

    //
    // GET: /ExamAdmin/

    public ViewResult Index(int? page, int? pageSize)
    {
      int iPage = page ?? 0;
      int iPageSize = pageSize ?? 10;

      PagedList<ExamModel> model = ExamComponent.GetExamModelList(iPage, iPageSize);

      return View(model);
    }

    //
    // GET: /ExamAdmin/Details/5

    public ViewResult Details(int id)
    {
      ExamModel model = ExamComponent.GetExamModel(id);
      ChoiceQuestionsModel choiceQuestionsModel = new ChoiceQuestionsModel();
      choiceQuestionsModel.Chapters = new SelectList(ExamComponent.GetChapters(model.BookId), "Id", "Name");
      choiceQuestionsModel.Answers = new SelectList(new List<SelectListItem>());
      choiceQuestionsModel.SelectedAnswers = new SelectList(ExamComponent.GetAnswersByExamId(id).Select(m => new { key = string.Format("{0}- {1}번", m.Chapter.Name, m.QuestionNumber), value = m.Id }), "value", "key");
      ViewData["ChoiceQuestionsModel"] = choiceQuestionsModel;
      ChoiceUsersModel choiceUsersModel = new ChoiceUsersModel();
      choiceUsersModel.Grades = new SelectList(AccountComponent.GetAllGrades(), "Id", "Name");
      choiceUsersModel.Classes = new SelectList(AccountComponent.GetAllClasses(), "Id", "Name");
      choiceUsersModel.Users = new SelectList(new List<SelectListItem>());
      choiceUsersModel.SelectedUsers = new SelectList(ExamComponent.GetUsersByExamId(id).Select(m => new { UserId = m.UserId, RealName = string.Format("{0}({1})", m.RealName, m.UserName) }), "UserId", "RealName");
      ViewData["ChoiceUsersModel"] = choiceUsersModel;

      return View(model);
    }

    //
    // POST: /ExamAdmin/Details

    [AcceptVerbs(HttpVerbs.Post)]
    public ActionResult Details(int id, string[] selectedAnswers, string[] selectedUsers)
    {
      if (selectedAnswers == null || selectedUsers == null)
        return RedirectToAction("Details", new { id = id });

      ExamComponent.CompleteExamSetting(id, selectedAnswers, selectedUsers);

      return RedirectToAction("Index");
    }

    //
    // GET: /ExamAdmin/Create

    public ActionResult Create()
    {
      ViewBag.CategoryId = new SelectList(ExamComponent.GetCategories(), "Id", "Name");
      ViewBag.BookId = new SelectList(ExamComponent.GetBooks(), "Id", "Name");
      return View();
    }

    //
    // POST: /ExamAdmin/Create

    [HttpPost]
    public ActionResult Create(ExamModel model)
    {
      if (ModelState.IsValid)
      {
        ExamComponent.CreateExam(model);
        return RedirectToAction("Index");
      }

      ViewBag.CategoryId = new SelectList(ExamComponent.GetCategories(), "Id", "Name", model.CategoryId);
      ViewBag.BookId = new SelectList(ExamComponent.GetBooks(), "Id", "Name", model.BookId);
      return View(model);
    }

    //
    // GET: /ExamAdmin/Edit/5

    public ActionResult Edit(int id)
    {
      ExamModel model = ExamComponent.GetExamModel(id);
      ViewBag.CategoryId = new SelectList(ExamComponent.GetCategories(), "Id", "Name", model.CategoryId);
      ViewBag.BookId = new SelectList(ExamComponent.GetBooks(), "Id", "Name", model.BookId);
      return View("Create", model);
    }

    //
    // POST: /ExamAdmin/Edit/5

    [HttpPost]
    public ActionResult Edit(ExamModel model)
    {
      if (ModelState.IsValid)
      {
        ExamComponent.UpdateExam(model);
        return RedirectToAction("Index");
      }
      ViewBag.CategoryId = new SelectList(ExamComponent.GetCategories(), "Id", "Name", model.CategoryId);
      ViewBag.BookId = new SelectList(ExamComponent.GetBooks(), "Id", "Name", model.BookId);
      return View("Create", model);
    }

    //
    // GET: /ExamAdmin/Delete/5

    public ActionResult Delete(int id)
    {
      ExamComponent.DeleteExam(id);
      return RedirectToAction("Index");
    }

    //
    // POST: /ExamAdmin/GetBooksList

    [HttpPost]
    public JsonResult GetBooksList(int categoryId)
    {
      return Json(ExamComponent.GetBooks(categoryId).Select(m => new { key = m.Name, value = m.Id }).ToList());
    }

    //
    // POST: /ExamAdmin/GetAnswersList

    [HttpPost]
    public JsonResult GetAnswersList(int chapterId)
    {
      return Json(ExamComponent.GetAnswersByChapterId(chapterId).Select(m => new { key = string.Format("{0}- {1}번", m.Chapter.Name, m.QuestionNumber), value = m.Id }).ToList());
    }

    //
    // POST: /ExamAdmin/GetClassesList

    [HttpPost]
    public JsonResult GetClassesList(byte gradeId)
    {
      return Json(AccountComponent.GetClasses(gradeId).Select(m => new { key = m.Name, value = m.Id }).ToList());
    }

    //
    // POST: /ExamAdmin/GetUsersList

    [HttpPost]
    public JsonResult GetUsersList(byte classId)
    {
      return Json(AccountComponent.GetUsersByClassId(classId).Select(m => new { key = string.Format("{0}({1})", m.RealName, m.UserName), value = m.UserId }).ToList());
    }
  }
}