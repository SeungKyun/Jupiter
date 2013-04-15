<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/Site.master" Inherits="System.Web.Mvc.ViewPage<PagedList<ERUTC.Models.ExamOfUserModel>>" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
  <script type="text/javascript">
    $(function () {
      $('#IsComplete').bind("change", function () {
        if ($(this).val() != "") {
          location.href = "/Exam/Index?IsComplete=" + $(this).val();
        }
        else {
          location.href = "/Exam/Index";
        }
      });
    });
  </script>

  <table width="700" border="0" cellspacing="0" cellpadding="0">
    <tr>
      <td align="left">
        &nbsp;
      </td>
    </tr>
    <tr>
      <td align="left">
        <img src="/content/images/title01.gif" width="174" height="39" />
      </td>
    </tr>
    <tr>
      <td>
        &nbsp;
      </td>
    </tr>
    <tr>
      <td align="center">
        <table width="650" border="0" cellspacing="0" cellpadding="0">
          <tr>
            <td align="right">
              <select id="IsComplete" name="IsComplete">
                <option value=""> - 선 택 - </option>
                <option value="True">완료</option>
                <option value="False">완료전</option>
              </select>
            </td>
          </tr>
          <tr>
            <td height="10">
            </td>
          </tr>
          <tr>
            <td>
              <table width="650" border="0" cellspacing="0" cellpadding="0">
                <tr>
                  <td height="2" colspan="7" bgcolor="#b3a398">
                  </td>
                </tr>
                <tr>
                  <td width="34" height="35" align="center" bgcolor="#F7F7F7">
                    <strong>번호</strong>
                  </td>
                  <td width="96" align="center" bgcolor="#F7F7F7">
                    <strong>과목</strong>
                  </td>
                  <td width="190" align="center" bgcolor="#F7F7F7">
                    <strong>시험제목</strong>
                  </td>
                  <td width="85" align="center" bgcolor="#F7F7F7">
                    <strong>시험개시일</strong>
                  </td>
                  <td width="85" align="center" bgcolor="#F7F7F7">
                    <strong>시험종료일</strong>
                  </td>
                  <td width="85" align="center" bgcolor="#F7F7F7">
                    <strong>답안오픈일</strong>
                  </td>
                  <td width="75" align="center" bgcolor="#F7F7F7">
                    <strong>응시상태</strong>
                  </td>
                </tr>
    <% int index = Model.Count();
       foreach (var item in Model)
       { %>
                <tr>
                  <td height="1" colspan="7" bgcolor="#b3a398"></td>
                </tr>
                <tr>
                  <td height="28" align="center">
                    <%: index-- %>
                  </td>
                  <td align="center">
                    <%: Html.DisplayFor(modelItem => item.BookName)%>
                  </td>
                  <td align="center">
                    <table width="219" border="0" cellspacing="0" cellpadding="0">
                      <tr>
                        <td height="5" colspan="3">
                        </td>
                      </tr>
                      <tr>
                        <td width="10">
                          &nbsp;
                        </td>
                        <td align="center">
      <% 
         if (item.IsComplete && (!item.IsPresentlyAnswerOpen && item.AnswerOpenDate > DateTime.Today))
           Response.Write(Html.DisplayFor(modelItem => item.ExamName));
         else
           Response.Write(Html.ActionLink(Html.DisplayFor(modelItem => item.ExamName).ToString(), item.IsComplete ? "Result" : "Details", new { examOfUserId = item.Id, examId = item.ExamId, examName = item.ExamName }));
      %>
                        </td>
                        <td width="10">
                          &nbsp;
                        </td>
                      </tr>
                      <tr>
                        <td height="5" colspan="3">
                        </td>
                      </tr>
                    </table>
                  </td>
                  <td align="center">
                    <%: Html.DisplayFor(modelItem => item.BeginDate)%>
                  </td>
                  <td align="center">
                    <%: Html.DisplayFor(modelItem => item.EndDate)%>
                  </td>
                  <td align="center">
                    <%: Html.DisplayFor(modelItem => item.AnswerOpenDate)%>
                  </td>
                  <td align="center">
                    <%: Html.DisplayFor(modelItem => item.IsComplete)%>
                  </td>
                </tr>
    <% } %>
                <tr>
                  <td height="1" colspan="7" bgcolor="#b3a398">
                  </td>
                </tr>
                <tr>
                  <td height="50" colspan="7" align="center">
                    <%: Html.Pager(Model, new { IsComplete = ViewData["IsComplete"] })%>
                  </td>
                </tr>
                <!--
                <tr>
                  <td height="50" colspan="7" align="center">
                    <img src="/content/images/btn_prev02.gif" alt="처음으로" width="11" height="11" border="0" />&nbsp;<img
                      src="/content/images/btn_prev01.gif" alt="이전으로" width="11" height="11" border="0" />&nbsp;&nbsp;<strong>1</strong>
                    2 3 4 5&nbsp;&nbsp;<img src="/content/images/btn_next01.gif" alt="다음으로" width="11" height="11"
                      border="0" />&nbsp;<img src="/content/images/btn_next02.gif" alt="마지막으로" width="11" height="11"
                        border="0" />
                  </td>
                </tr>
                -->
              </table>
            </td>
          </tr>
        </table>
      </td>
    </tr>
    <tr>
      <td>
        &nbsp;
      </td>
    </tr>
  </table>
</asp:Content>
