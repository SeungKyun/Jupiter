<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/Site.master" Inherits="System.Web.Mvc.ViewPage<PagedList<ERUTC.Models.ExamModel>>" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
  <script type="text/javascript">
    function DeleteConfirm() {
      if (!confirm("삭제 하시겠습니까?"))
        return false;
      return true;
    }
  </script>

<h2>시험관리</h2>

<div style="text-align:right;">
  <p>
      <%: Html.ActionLink("시험생성", "Create") %>
  </p>
</div>
<table class="listtable">
    <tr>
        <th>
            교재명
        </th>
        <th>
            시험명
        </th>
        <th>
            문항수
        </th>
        <th>
            시작일
        </th>
        <th>
            종료일
        </th>
        <th>
            답안오픈일
        </th>
        <th></th>
    </tr>

<% foreach (var item in Model) { %>
    <tr>
        <td>
            <%: Html.DisplayFor(modelItem => item.BookName) %>
        </td>
        <td>
            <%: Html.DisplayFor(modelItem => item.ExamName) %>
        </td>
        <td>
            <%: Html.DisplayFor(modelItem => item.CountOfQuestions) %>
        </td>
        <td>
            <%: Html.DisplayFor(modelItem => item.BeginDate) %>
        </td>
        <td>
            <%: Html.DisplayFor(modelItem => item.EndDate) %>
        </td>
        <td>
            <%: Html.DisplayFor(modelItem => item.AnswerOpenDate) %>
        </td>
        <td>
            <%: Html.ActionLink("수정", "Edit", new { id=item.Id }) %> |
            <%: item.IsMakedUserExam ? new HtmlString("출제완료") : Html.ActionLink("시험출제", "Details", new { id=item.Id }) %> |
            <%: Html.ActionLink("삭제", "Delete", new { id = item.Id }, new { onclick = "return DeleteConfirm()" })%>
        </td>
    </tr>
<% } %>

</table>

  <%: Html.Pager(Model) %>

</asp:Content>
