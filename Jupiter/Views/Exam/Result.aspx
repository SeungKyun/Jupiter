<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/Site.Master" Inherits="System.Web.Mvc.ViewPage<ERUTC.Models.UserExamResultModel>" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
  <% Html.RenderPartial("UserExamResult", Model); %>
  <map name="Map_BT_OK01" id="Map_BT_OK01">
    <area shape="rect" coords="292,25,357,61" href="/Exam/Index" alt="확인" />
  </map>
</asp:Content>
