<%@ Control Language="C#" Inherits="System.Web.Mvc.ViewUserControl<ERUTC.Models.ChoiceUsersModel>" %>
<table width="100%">
  <tr>
    <td>
      <script type="text/javascript">
        $(function () {
          $('#btnPushUsers').bind("click", function () {
            $('#Users option:selected').remove().appendTo('#SelectedUsers');
          });
          $('#btnPopUsers').bind("click", function () {
            $('#SelectedUsers option:selected').remove().appendTo('#Users');
          });
          $('#Grades').bind("change", function () {
            var gradeId = $(this).val();
            var Classes = $('#Classes');

            if (gradeId != '') {
              Classes.get(0).options.length = 0; Classes.get(0).options[0] = new Option("가져오는중..", "");
              $.ajax(
            {
              type: 'POST',
              url: '/ExamAdmin/GetClassesList',
              data: '{"gradeId":"' + gradeId + '"}',
              contentType: "application/json; charset=utf-8",
              dataType: "json",
              success: function (books) {
                Classes.get(0).options.length = 0;
                Classes.get(0).options[0] = new Option(" --- 선 택 --- ", "");
                $.each(books, function (index, item) {
                  Classes.get(0).options[Classes.get(0).options.length] = new Option(item.key, item.value);
                });
              }, error: function () {
                Classes.get(0).options.length = 0;
                alert("요청이 실패했습니다. 다시 시도해 주십시오.");
              }
            });
            } else {
              Classes.get(0).options.length = 0;
            }
          });
          $(function () {
            $('#Classes').bind("change", function () {
              var classId = $(this).val();
              var Users = $('#Users');

              if (classId != '') {
                Users.get(0).options.length = 0; Users.get(0).options[0] = new Option("가져오는중..", "");
                $.ajax(
            {
              type: 'POST',
              url: '/ExamAdmin/GetUsersList',
              data: '{"classId":"' + classId + '"}',
              contentType: "application/json; charset=utf-8",
              dataType: "json",
              success: function (books) {
                Users.get(0).options.length = 0;
                $.each(books, function (index, item) {
                  Users.get(0).options[Users.get(0).options.length] = new Option(item.key, item.value);
                });
              }, error: function () {
                Users.get(0).options.length = 0;
                alert("요청이 실패했습니다. 다시 시도해 주십시오.");
              }
            });
              } else {
                Users.get(0).options.length = 0;
              }
            });
          });
        });
      </script>
      <fieldset>
        <legend>
          <div>
            상위분류 :
            <%: Html.LabelFor(model => model.Grades)%>
            <%: Html.DropDownListFor(model => Model.Grades, Model.Grades, " --- 선 택 --- ")%>
            <%: Html.ValidationMessageFor(model => model.Grades)%>
          </div>
          <div>
            하위분류 :
            <%: Html.LabelFor(model => model.Classes)%>
            <%: Html.DropDownListFor(model => Model.Classes, Model.Classes, " --- 선 택 --- ")%>
            <%: Html.ValidationMessageFor(model => model.Classes)%>
          </div>
          </div>
        </legend>
        <%: Html.ListBoxFor(m => m.Users, Model.Users, new { @class = "selectlistbox" })%>
      </fieldset>
    </td>
    <td style="padding:10px;">
      <input type="button" id="btnPushUsers" value="▷" />
      <br />
      <input type="button" id="btnPopUsers" value="◁" />
    </td>
    <td>
      <fieldset>
        <legend>
          <div>
            선택된수강생</div>
        </legend>
        <%: Html.ListBoxFor(m => m.SelectedUsers, Model.SelectedUsers, new { @class = "selectlistbox" })%>
      </fieldset>
    </td>
  </tr>
</table>
