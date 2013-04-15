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
  [Authorize]
  public class ExamController : BaseController
  {

    //
    // GET: /Exam/

    public ViewResult Index(int? page, int? pageSize, bool? IsComplete)
    {
      int iPage = page ?? 0;
      int iPageSize = pageSize ?? 10;
      ViewData["IsComplete"] = IsComplete;

      PagedList<ExamOfUserModel> model = ExamComponent.GetExamOfUserModels(IsComplete, iPage, iPageSize);

      return View(model);
    }

    //
    // GET: /Exam/Details/5

    public ViewResult Details(int examId, long examOfUserId, string examName, string message)
    {
      List<AnswerModel> model = ExamComponent.BeginUserExam(examId, examOfUserId);
      ViewBag.examOfUserId = examOfUserId;
      ViewBag.ExamId = examId;
      ViewBag.ExamName = examName;
      ViewData["Message"] = message;

      return View(model);
    }

    //
    // POST: /Exam/Details/5

    [AcceptVerbs(HttpVerbs.Post)]
    public ActionResult Details(FormCollection forms, int examId, long examOfUserId, string examName)
    {
      if (forms.Count > 3)
      {
        forms.Remove("examOfUserId");
        forms.Remove("examId");
        forms.Remove("examName");

        List<KeyValuePair<long, byte>> answers = new List<KeyValuePair<long, byte>>();
        foreach (string item in forms.AllKeys)
	      {
          answers.Add(new KeyValuePair<long, byte>(long.Parse(item), byte.Parse(forms[item])));
	      }

        bool isComplete = ExamComponent.CompleteUserExam(examId, examOfUserId, answers);

        if (isComplete)
        {
          Exam exam = ExamComponent.GetExam(examId);
          if (exam.IsPresentlyAnswerOpen || DateTime.Today >= exam.AnswerOpenDate)
          {
            return RedirectToAction("Result", new { examOfUserId = examOfUserId }); 
          }
          else
          {
            return RedirectToAction("Index");
          }
        }
      }

      string message = "제출한 시험지의 점수가 50점 미만입니다. 다시 한번 도전해주세요.";
      return RedirectToAction("Details", new { examOfUserId = examOfUserId, examId = examId, examName = examName, message = message });
    }

    //
    // GET: /Exam/Result/5

    public ViewResult Result(long examOfUserId)
    {
      UserExamResultModel uerModel = ExamComponent.GetUserExamResultModel(examOfUserId);

      return View(uerModel);
    }

    protected override void Dispose(bool disposing)
    {
      base.Dispose(disposing);
    }
  }
}