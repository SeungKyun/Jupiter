<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/Site.master" Inherits="System.Web.Mvc.ViewPage<ERUTC.Models.vw_aspnet_MembershipUsers>" %>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">

<h2>Edit</h2>

<script src="<%: Url.Content("~/Scripts/jquery.validate.min.js") %>" type="text/javascript"></script>
<script src="<%: Url.Content("~/Scripts/jquery.validate.unobtrusive.min.js") %>" type="text/javascript"></script>

<% using (Html.BeginForm()) { %>
    <%: Html.ValidationSummary(true) %>
    <fieldset>
        <legend>vw_aspnet_MembershipUsers</legend>

        <%: Html.HiddenFor(model => model.UserId) %>

        <%: Html.HiddenFor(model => model.PasswordFormat) %>

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

        <%: Html.HiddenFor(model => model.IsApproved) %>

        <%: Html.HiddenFor(model => model.IsLockedOut) %>

        <%: Html.HiddenFor(model => model.CreateDate) %>

        <%: Html.HiddenFor(model => model.LastLoginDate) %>

        <%: Html.HiddenFor(model => model.LastPasswordChangedDate) %>

        <%: Html.HiddenFor(model => model.LastLockoutDate) %>

        <%: Html.HiddenFor(model => model.FailedPasswordAttemptCount) %>

        <%: Html.HiddenFor(model => model.FailedPasswordAttemptWindowStart) %>

        <%: Html.HiddenFor(model => model.FailedPasswordAnswerAttemptCount) %>

        <%: Html.HiddenFor(model => model.FailedPasswordAnswerAttemptWindowStart) %>

        <div class="editor-label">
            <%: Html.LabelFor(model => model.Comment) %>
        </div>
        <div class="editor-field">
            <%: Html.EditorFor(model => model.Comment) %>
            <%: Html.ValidationMessageFor(model => model.Comment) %>
        </div>

        <%: Html.HiddenFor(model => model.ApplicationId) %>

        <%: Html.HiddenFor(model => model.UserName) %>

        <div class="editor-label">
            <%: Html.LabelFor(model => model.MobileAlias) %>
        </div>
        <div class="editor-field">
            <%: Html.EditorFor(model => model.MobileAlias) %>
            <%: Html.ValidationMessageFor(model => model.MobileAlias) %>
        </div>

        <%: Html.HiddenFor(model => model.IsAnonymous) %>

        <%: Html.HiddenFor(model => model.LastActivityDate) %>

        <p>
            <input type="submit" value="Save" />
        </p>
    </fieldset>
<% } %>

<div>
    <%: Html.ActionLink("Back to List", "Index") %>
</div>

</asp:Content>
