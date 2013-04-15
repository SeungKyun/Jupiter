<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/Site.master" Inherits="System.Web.Mvc.ViewPage<IEnumerable<ERUTC.Models.AnswerModel>>" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
<div class="adminbody">
  <script type="text/javascript">
  <% if (ViewData["Message"] != null) { %>
    alert('<%: (string)ViewData["Message"] %>');
  <% } %>
    var questionCount = <%: Model.Count() %>;
    function CompleteUserExam() {
      var checkedQuestionCount = $('form input:radio:checked').length;
      if (checkedQuestionCount < questionCount) {
        alert('총 ' + questionCount + '개 문제중 ' + (questionCount - checkedQuestionCount) + '개 문제가 남았습니다.');
      }
      else {
        $('form').submit();
      }
    }
  </script>
  <table width="700" border="0" cellspacing="0" cellpadding="0">
    <tr>
      <td align="left">&nbsp;</td>
    </tr>
    <tr>
      <td align="left"><img src="/content/images/title01.gif" width="174" height="39" /></td>
    </tr>
    <tr>
      <td>&nbsp;</td>
    </tr>
    <tr>
      <td align="center"><table width="650" border="0" cellspacing="0" cellpadding="0">
        <tr>
          <td><table width="650" border="0" cellspacing="0" cellpadding="0">
            <tr>
              <td height="91" align="center" valign="top" background="/content/images/img_box01_01.jpg"><table width="530" border="0" cellspacing="0" cellpadding="0">
                <tr>
                  <td height="42">&nbsp;</td>
                </tr>
                <tr>
                  <td align="center"><strong><span style="FONT-SIZE: 15px; LETTER-SPACING: 0px; line-height:18px; color:#faffa4"><%: ViewBag.ExamName %></span></strong></td>
                </tr>
              </table></td>
            </tr>
            <tr>
              <td align="center" background="/content/images/img_box01_02.jpg"><table width="580" border="0" cellspacing="0" cellpadding="0">
                <tr>
                  <td height="2" colspan="11" bgcolor="#b3a398"></td>
                </tr>
                <tr>
                  <td width="130" height="26" align="center" bgcolor="#dfd5ce"><strong>문제번호</strong></td>
                  <td width="1" rowspan="34" bgcolor="#b3a398"></td>
                  <td width="89" align="center" bgcolor="#dfd5ce"><strong>1</strong></td>
                  <td width="1" rowspan="34" bgcolor="#b3a398"></td>
                  <td width="89" align="center" bgcolor="#dfd5ce"><strong>2</strong></td>
                  <td width="1" rowspan="34" bgcolor="#b3a398"></td>
                  <td width="89" align="center" bgcolor="#dfd5ce"><strong>3</strong></td>
                  <td width="1" rowspan="34" bgcolor="#b3a398"></td>
                  <td width="89" align="center" bgcolor="#dfd5ce"><strong>4</strong></td>
                  <td width="1" rowspan="34" align="center" bgcolor="#b3a398"></td>
                  <td width="89" align="center" bgcolor="#dfd5ce"><strong>5</strong></td>
                </tr>
            <% using (Html.BeginForm()) { %>
              <%: Html.Hidden("examOfUserId", (long)ViewBag.examOfUserId)%>
              <%: Html.Hidden("examId", (int)ViewBag.ExamId)%>
              <%: Html.Hidden("examName", (string)ViewBag.ExamName)%>
              <% foreach (var item in Model) { %>
                <tr>
                  <td height="26" align="center"><%: item.Chapter.Name %>- <%: item.Answer.QuestionNumber %>번</td>
                  <% for(int i = 1; i < 6; i++) { %>
                  <td align="center"><input type="radio" name="<%: item.Answer.Id %>" id="<%: item.Answer.Id %>" value="<%: i %>" /></td>
                  <% } %>
                </tr>
                <tr>
                  <td height="1" align="center" bgcolor="#dacfc8"></td>
                  <td align="center" bgcolor="#dacfc8"></td>
                  <td align="center" bgcolor="#dacfc8"></td>
                  <td align="center" bgcolor="#dacfc8"></td>
                  <td align="center" bgcolor="#dacfc8"></td>
                  <td align="center" bgcolor="#dacfc8"></td>
                </tr>
              <% } %>
            <% } %>
                <tr>
                  <td height="1" colspan="11" bgcolor="#b3a398"></td>
                </tr>
              </table></td>
            </tr>
            <tr>
              <td><img src="/content/images/img_box01_03.jpg" width="650" height="87" border="0" usemap="#Map_BT_OK01Map" /></td>
            </tr>
          </table></td>
        </tr>
      </table></td>
    </tr>
  </table>
  <map name="Map_BT_OK01Map" id="Map_BT_OK01Map">
    <area shape="rect" coords="292,25,357,61" href="javascript:;" onclick="CompleteUserExam()" alt="확인" />
  </map>
</div>
</asp:Content>
