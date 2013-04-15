<%@ Control Language="C#" Inherits="System.Web.Mvc.ViewUserControl<ERUTC.Models.ChoiceQuestionsModel>" %>
<table width="100%">
  <tr>
    <td>
      <script type="text/javascript">
        $(function () {
          $('#btnPushAnswers').bind("click", function () {
            $('#Answers option:selected').remove().appendTo('#SelectedAnswers');
          });
          $('#btnPopAnswers').bind("click", function () {
            $('#SelectedAnswers option:selected').remove().appendTo('#Answers');
          });
          $('#Chapters').bind("change", function () {
            var chapterId = $(this).val();
            var Answers = $('#Answers');

            if (chapterId != '') {
              Answers.get(0).options.length = 0; Answers.get(0).options[0] = new Option("가져오는중..", "");
              $.ajax(
            {
              type: 'POST',
              url: '/ExamAdmin/GetAnswersList',
              data: '{"chapterId":"' + chapterId + '"}',
              contentType: "application/json; charset=utf-8",
              dataType: "json",
              success: function (books) {
                Answers.get(0).options.length = 0;
                $.each(books, function (index, item) {
                  Answers.get(0).options[Answers.get(0).options.length] = new Option(item.key, item.value);
                });
              }, error: function () {
                Answers.get(0).options.length = 0;
                alert("요청이 실패했습니다. 다시 시도해 주십시오.");
              }
            });
            } else {
              Answers.get(0).options.length = 0;
            }
          });
        });
      </script>
      <fieldset>
        <legend>
          <div>
            문제선택 :
            <%: Html.LabelFor(model => model.Chapters)%>
            <%: Html.DropDownListFor(model => Model.Chapters, Model.Chapters, " --- 선 택 --- ")%>
            <%: Html.ValidationMessageFor(model => model.Chapters)%>
          </div>
        </legend>
        <%: Html.ListBoxFor(m => m.Answers, Model.Answers, new { @class = "selectlistbox" })%>
      </fieldset>
    </td>
    <td style="padding:10px;">
      <input type="button" id="btnPushAnswers" value="▷" />
      <br />
      <input type="button" id="btnPopAnswers" value="◁" />
    </td>
    <td>
      <fieldset>
        <legend>
          <div>
            선택된문제</div>
        </legend>
        <%: Html.ListBoxFor(m => m.SelectedAnswers, Model.SelectedAnswers, new { @class = "selectlistbox" })%>
      </fieldset>
    </td>
  </tr>
</table>
