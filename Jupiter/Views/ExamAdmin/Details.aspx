<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/Site.master" Inherits="System.Web.Mvc.ViewPage<ERUTC.Models.ExamModel>" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
<div class="adminbody">
<h2>문제, 시험대상 선택</h2>
<% using (Html.BeginForm())
   { %>
<%: Html.ValidationSummary(true)%>
<%: Html.HiddenFor(m => m.Id) %>
<fieldset>
    <legend>시험정보</legend>

      <div class="display-label">
        <%: Html.LabelFor(model => model.BookName)%>
      </div>
      <div class="display-field">
        <%: Html.DisplayFor(model => model.BookName)%>
        <%: Html.ValidationMessageFor(model => model.BookName)%>
      </div>
      <div class="display-label">
        <%: Html.LabelFor(model => model.ExamName)%>
      </div>
      <div class="display-field">
        <%: Html.DisplayFor(model => model.ExamName)%>
        <%: Html.ValidationMessageFor(model => model.ExamName)%>
      </div>
      <div class="display-label">
        <%: Html.LabelFor(model => model.CountOfQuestions)%>
      </div>
      <div class="display-field numberpicker">
        <%: Html.DisplayFor(model => model.CountOfQuestions)%>
        <%: Html.ValidationMessageFor(model => model.CountOfQuestions)%>
      </div>
      <div class="display-label">
        <%: Html.LabelFor(model => model.BeginDate)%>
      </div>
      <div class="display-field datepicker">
        <%: Html.DisplayFor(model => model.BeginDate)%>
        <%: Html.ValidationMessageFor(model => model.BeginDate)%>
      </div>
      <div class="display-label">
        <%: Html.LabelFor(model => model.EndDate)%>
      </div>
      <div class="display-field datepicker">
        <%: Html.DisplayFor(model => model.EndDate)%>
        <%: Html.ValidationMessageFor(model => model.EndDate)%>
      </div>
      <div class="display-label">
        <%: Html.LabelFor(model => model.AnswerOpenDate)%>
      </div>
      <div class="display-field datepicker">
        <%: Html.DisplayFor(model => model.AnswerOpenDate)%>
        <%: Html.ValidationMessageFor(model => model.AnswerOpenDate)%>
      </div>
      <div class="display-label">
        <%: Html.LabelFor(model => model.IsPresentlyAnswerOpen)%>
      </div>
      <div class="display-field">
        <%: Html.DisplayFor(model => model.IsPresentlyAnswerOpen)%>
        <%: Html.ValidationMessageFor(model => model.IsPresentlyAnswerOpen)%>
      </div>
      <div class="display-label">
        <%: Html.LabelFor(model => model.IsMakedUserExam)%>
      </div>
      <div class="display-field">
        <%: Html.DisplayFor(model => model.IsMakedUserExam)%>
        <%: Html.ValidationMessageFor(model => model.IsMakedUserExam)%>
      </div>
</fieldset>
<% Html.RenderPartial("Answers", ViewData["ChoiceQuestionsModel"]); %>
<% Html.RenderPartial("Users", ViewData["ChoiceUsersModel"]); %>
<input type="submit" value="시험출제" />
<% } %>
<p>
    <%: Html.ActionLink("Edit", "Edit", new { id=Model.Id }) %> |
    <%: Html.ActionLink("Back to List", "Index") %>
</p>
</div>
</asp:Content>
