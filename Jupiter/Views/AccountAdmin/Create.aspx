<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/Site.master" Inherits="System.Web.Mvc.ViewPage<ERUTC.Models.vw_aspnet_MembershipUsers>" %>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">

<h2>Create</h2>

<script src="<%: Url.Content("~/Scripts/jquery.validate.min.js") %>" type="text/javascript"></script>
<script src="<%: Url.Content("~/Scripts/jquery.validate.unobtrusive.min.js") %>" type="text/javascript"></script>

<% using (Html.BeginForm()) { %>
    <%: Html.ValidationSummary(true) %>
    <fieldset>
        <legend>vw_aspnet_MembershipUsers</legend>

        <div class="editor-label">
            <%: Html.LabelFor(model => model.MobilePIN) %>
        </div>
        <div class="editor-field">
            <%: Html.EditorFor(model => model.MobilePIN) %>
            <%: Html.ValidationMessageFor(model => model.MobilePIN) %>
        </div>

        <div class="editor-label">
            <%: Html.LabelFor(model => model.Email) %>
        </div>
        <div class="editor-field">
            <%: Html.EditorFor(model => model.Email) %>
            <%: Html.ValidationMessageFor(model => model.Email) %>
        </div>

        <div class="editor-label">
            <%: Html.LabelFor(model => model.LoweredEmail) %>
        </div>
        <div class="editor-field">
            <%: Html.EditorFor(model => model.LoweredEmail) %>
            <%: Html.ValidationMessageFor(model => model.LoweredEmail) %>
        </div>

        <div class="editor-label">
            <%: Html.LabelFor(model => model.PasswordQuestion) %>
        </div>
        <div class="editor-field">
            <%: Html.EditorFor(model => model.PasswordQuestion) %>
            <%: Html.ValidationMessageFor(model => model.PasswordQuestion) %>
        </div>

        <div class="editor-label">
            <%: Html.LabelFor(model => model.PasswordAnswer) %>
        </div>
        <div class="editor-field">
            <%: Html.EditorFor(model => model.PasswordAnswer) %>
            <%: Html.ValidationMessageFor(model => model.PasswordAnswer) %>
        </div>

        <div class="editor-label">
            <%: Html.LabelFor(model => model.Comment) %>
        </div>
        <div class="editor-field">
            <%: Html.EditorFor(model => model.Comment) %>
            <%: Html.ValidationMessageFor(model => model.Comment) %>
        </div>

        <div class="editor-label">
            <%: Html.LabelFor(model => model.MobileAlias) %>
        </div>
        <div class="editor-field">
            <%: Html.EditorFor(model => model.MobileAlias) %>
            <%: Html.ValidationMessageFor(model => model.MobileAlias) %>
        </div>

        <p>
            <input type="submit" value="Create" />
        </p>
    </fieldset>
<% } %>

<div>
    <%: Html.ActionLink("Back to List", "Index") %>
</div>

</asp:Content>
