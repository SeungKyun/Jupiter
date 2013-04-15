<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/Site.master" Inherits="System.Web.Mvc.ViewPage<ERUTC.Models.ExamModel>" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
  <div class="adminbody">
    <h2>시험생성</h2>
    <script src="<%: Url.Content("~/Scripts/jquery.validate.min.js") %>" type="text/javascript"></script>
    <script src="<%: Url.Content("~/Scripts/jquery.validate.unobtrusive.min.js") %>"
      type="text/javascript"></script>
    <script type="text/javascript">
      var IsMakedUserExam = false;
  <% if (Model != null && Model.IsMakedUserExam)
     { %>
      IsMakedUserExam = true;
  <% } %>
      $(function () {
        $('#ddlCategoryId').bind("change", function () {
          var categoryId = $(this).val();
          var ddlBookId = $('#ddlBookId');

          if (categoryId != '') {
            ddlBookId.get(0).options.length = 0; ddlBookId.get(0).options[0] = new Option("가져오는중..", "");
            $.ajax(
            {
              type: 'POST',
              url: '/ExamAdmin/GetBooksList',
              data: '{"categoryId":"' + categoryId + '"}',
              contentType: "application/json; charset=utf-8",
              dataType: "json",
              success: function (books) {
                ddlBookId.get(0).options.length = 0;
                ddlBookId.get(0).options[0] = new Option(" --- 선 택 --- ", "");
                $.each(books, function (index, item) {
                  ddlBookId.get(0).options[ddlBookId.get(0).options.length] = new Option(item.key, item.value);
                });
              }, error: function () {
                ddlBookId.get(0).options.length = 0;
                alert("요청이 실패했습니다. 다시 시도해 주십시오.");
              }
            });
          } else {
            ddlBookId.get(0).options.length = 0;
          }
        });
        $('#ddlBookId').bind("change", function () {
          if ($($(this).get(0).options[$(this).get(0).selectedIndex]).val() == '')
            $('#ExamName').val('');
          else
            $('#ExamName').val($($(this).get(0).options[$(this).get(0).selectedIndex]).text());
        });
        if (IsMakedUserExam) {
          $('#CountOfQuestions').attr('readonly', 'true');
          $('#BeginDate').attr('readonly', 'true');
        }
        else {
          $('#BeginDate').datepicker();
        }
        $('#EndDate').datepicker();
        $('#AnswerOpenDate').datepicker();
      });
    </script>
    <% using (Html.BeginForm())
       { %>
    <%: Html.ValidationSummary(true) %>
    <%: Html.Hidden("Id", Model == null ? 0 : Model.Id )%>
    <%: Html.Hidden("CreateDate", Model == null ? DateTime.Now : Model.CreateDate ) %>
    <fieldset>
      <legend>시험</legend>
      <div class="editor-label">
        <%: Html.LabelFor(model => model.CategoryId)%>
      </div>
      <div class="editor-field">
        <%: Html.DropDownListEditorFor(model => model.CategoryId, (SelectList)ViewBag.CategoryId, " --- 선 택 --- ")%>
        <%: Html.ValidationMessageFor(model => model.CategoryId)%>
      </div>
      <div class="editor-label">
        <%: Html.LabelFor(model => model.BookId) %>
      </div>
      <div class="editor-field">
        <%: Html.DropDownListEditorFor(model => model.BookId, (SelectList)ViewBag.BookId, " --- 선 택 --- ")%>
        <%: Html.ValidationMessageFor(model => model.BookId) %>
      </div>
      <div class="editor-label">
        <%: Html.LabelFor(model => model.ExamName) %>
      </div>
      <div class="editor-field">
        <%: Html.EditorFor(model => model.ExamName)%>
        <%: Html.ValidationMessageFor(model => model.ExamName)%>
      </div>
      <div class="editor-label">
        <%: Html.LabelFor(model => model.CountOfQuestions) %>
      </div>
      <div class="editor-field numberpicker">
        <%: Html.EditorFor(model => model.CountOfQuestions)%>
        <%: Html.ValidationMessageFor(model => model.CountOfQuestions)%>
      </div>
      <div class="editor-label">
        <%: Html.LabelFor(model => model.BeginDate) %>
      </div>
      <div class="editor-field datepicker">
        <%: Html.EditorFor(model => model.BeginDate) %>
        <%: Html.ValidationMessageFor(model => model.BeginDate) %>
      </div>
      <div class="editor-label">
        <%: Html.LabelFor(model => model.EndDate) %>
      </div>
      <div class="editor-field datepicker">
        <%: Html.EditorFor(model => model.EndDate) %>
        <%: Html.ValidationMessageFor(model => model.EndDate) %>
      </div>
      <div class="editor-label">
        <%: Html.LabelFor(model => model.AnswerOpenDate) %>
      </div>
      <div class="editor-field datepicker">
        <%: Html.EditorFor(model => model.AnswerOpenDate) %>
        <%: Html.ValidationMessageFor(model => model.AnswerOpenDate) %>
      </div>
      <div class="editor-label">
        <%: Html.LabelFor(model => model.IsPresentlyAnswerOpen) %>
      </div>
      <div class="editor-field">
        <%: Html.EditorFor(model => model.IsPresentlyAnswerOpen)%>
        <%: Html.ValidationMessageFor(model => model.IsPresentlyAnswerOpen)%>
      </div>
      <p>
        <input type="submit" value=" 저 장 " />
      </p>
    </fieldset>
    <% } %>
    <div>
      <%: Html.ActionLink("리스트", "Index") %>
    </div>
  </div>
</asp:Content>
