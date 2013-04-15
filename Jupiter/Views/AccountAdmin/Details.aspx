<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/Site.master" Inherits="System.Web.Mvc.ViewPage<ERUTC.Models.vw_aspnet_MembershipUsers>" %>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">

<h2>Details</h2>

<fieldset>
    <legend>vw_aspnet_MembershipUsers</legend>

    <div class="display-label">MobilePIN</div>
    <div class="display-field">
        <%: Html.DisplayFor(model => model.MobilePIN) %>
    </div>

    <div class="display-label">Email</div>
    <div class="display-field">
        <%: Html.DisplayFor(model => model.Email) %>
    </div>

    <div class="display-label">LoweredEmail</div>
    <div class="display-field">
        <%: Html.DisplayFor(model => model.LoweredEmail) %>
    </div>

    <div class="display-label">PasswordQuestion</div>
    <div class="display-field">
        <%: Html.DisplayFor(model => model.PasswordQuestion) %>
    </div>

    <div class="display-label">PasswordAnswer</div>
    <div class="display-field">
        <%: Html.DisplayFor(model => model.PasswordAnswer) %>
    </div>

    <div class="display-label">Comment</div>
    <div class="display-field">
        <%: Html.DisplayFor(model => model.Comment) %>
    </div>

    <div class="display-label">MobileAlias</div>
    <div class="display-field">
        <%: Html.DisplayFor(model => model.MobileAlias) %>
    </div>
</fieldset>
<p>
    <%: Html.ActionLink("Edit", "Edit", new { /* id=Model.PrimaryKey */ }) %> |
    <%: Html.ActionLink("Back to List", "Index") %>
</p>

</asp:Content>
