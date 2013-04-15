<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/Site.Master" Inherits="System.Web.Mvc.ViewPage<PagedList<ERUTC.Models.RegisterModel>>" %>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">

<h2>사용자리스트</h2>

<div style="text-align:right;">
  <p>
      <%: Html.ActionLink("사용자등록", "Register", "Account")%>
  </p>
</div>
<table class="listtable">
    <tr>
        <th>
            아이디
        </th>
        <th>
            이름
        </th>
        <th>
            집전화번호
        </th>
        <th>
            휴대폰번호
        </th>
        <th>
            이메일
        </th>
        <th>
            계정타입
        </th>
        <th>기능</th>
    </tr>

<% foreach (var item in Model) { %>
    <tr>
        <td>
            <%: Html.DisplayFor(modelItem => item.UserName) %>
        </td>
        <td>
            <%: Html.DisplayFor(modelItem => item.RealName) %>
        </td>
        <td>
            <%: Html.DisplayFor(modelItem => item.HomePhone) %>
        </td>
        <td>
            <%: Html.DisplayFor(modelItem => item.MobilePIN) %>
        </td>
        <td>
            <%: Html.DisplayFor(modelItem => item.Email) %>
        </td>
        <td>
            <%: item.IsAdmin ? "관리자" : "수강생" %>
        </td>
        <td>
            <%: Html.ActionLink("Edit", "Edit", new { /* id=item.PrimaryKey */ }) %> |
            <%: Html.ActionLink("Details", "Details", new { /* id=item.PrimaryKey */ }) %> |
            <%: Html.ActionLink("Delete", "Delete", new { /* id=item.PrimaryKey */ }) %>
        </td>
    </tr>
<% } %>

</table>

<%: Html.Pager(Model) %>

</asp:Content>
