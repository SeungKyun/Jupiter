<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/Site.Master" Inherits="System.Web.Mvc.ViewPage<IEnumerable<ERUTC.Models.RegisterModel>>" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

<h2>List</h2>

<p>
    <%: Html.ActionLink("Create New", "Create") %>
</p>
<table>
    <tr>
        <th>
            UserName
        </th>
        <th>
            Password
        </th>
        <th>
            ConfirmPassword
        </th>
        <th>
            ClassId
        </th>
        <th>
            RealName
        </th>
        <th>
            Gender
        </th>
        <th>
            HomePhone
        </th>
        <th>
            MobilePIN
        </th>
        <th>
            Email
        </th>
        <th>
            Post
        </th>
        <th>
            Address
        </th>
        <th>
            SchoolName
        </th>
        <th>
            SchoolGrade
        </th>
        <th>
            Comment
        </th>
        <th>
            ChurchName
        </th>
        <th>
            ChurchRole
        </th>
        <th></th>
    </tr>

<% foreach (var item in Model) { %>
    <tr>
        <td>
            <%: Html.DisplayFor(modelItem => item.UserName) %>
        </td>
        <td>
            <%: Html.DisplayFor(modelItem => item.Password) %>
        </td>
        <td>
            <%: Html.DisplayFor(modelItem => item.ConfirmPassword) %>
        </td>
        <td>
            <%: Html.DisplayFor(modelItem => item.ClassId) %>
        </td>
        <td>
            <%: Html.DisplayFor(modelItem => item.RealName) %>
        </td>
        <td>
            <%: Html.DisplayFor(modelItem => item.Gender) %>
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
            <%: Html.DisplayFor(modelItem => item.Post) %>
        </td>
        <td>
            <%: Html.DisplayFor(modelItem => item.Address) %>
        </td>
        <td>
            <%: Html.DisplayFor(modelItem => item.SchoolName) %>
        </td>
        <td>
            <%: Html.DisplayFor(modelItem => item.SchoolGrade) %>
        </td>
        <td>
            <%: Html.DisplayFor(modelItem => item.Comment) %>
        </td>
        <td>
            <%: Html.DisplayFor(modelItem => item.ChurchName) %>
        </td>
        <td>
            <%: Html.DisplayFor(modelItem => item.ChurchRole) %>
        </td>
        <td>
            <%: Html.ActionLink("Edit", "Edit", new { /* id=item.PrimaryKey */ }) %> |
            <%: Html.ActionLink("Details", "Details", new { /* id=item.PrimaryKey */ }) %> |
            <%: Html.ActionLink("Delete", "Delete", new { /* id=item.PrimaryKey */ }) %>
        </td>
    </tr>
<% } %>

</table>

</asp:Content>
