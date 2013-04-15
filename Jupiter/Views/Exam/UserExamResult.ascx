<%@ Control Language="C#" Inherits="System.Web.Mvc.ViewUserControl<ERUTC.Models.UserExamResultModel>" %>
  <table width="650" border="0" cellspacing="0" cellpadding="0">
    <tr>
      <td><table width="650" border="0" cellspacing="0" cellpadding="0">
        <tr>
          <td height="91" align="center" valign="top" background="/content/images/img_box01_01.jpg"><table width="530" border="0" cellspacing="0" cellpadding="0">
            <tr>
              <td height="42">&nbsp;</td>
              </tr>
            <tr>
              <td align="center"><strong><SPAN style="FONT-SIZE: 15px; LETTER-SPACING: 0px; line-height:18px; color:#faffa4"><%: Model.ExamOfUser.Exam.Name %></SPAN></strong></td>
              </tr>
            </table></td>
          </tr>
        <tr>
          <td align="center" background="/content/images/img_box01_02.jpg"><table width="580" border="0" cellspacing="0" cellpadding="0">
            <tr>
              <td height="2" colspan="5" bgcolor="#c76b2e"></td>
              </tr>
            <tr>
              <td width="192" height="26" align="center" bgcolor="#ffeab6"><strong>점수</strong></td>
              <td width="1" rowspan="2" bgcolor="#c76b2e"></td>
              <td width="193" align="center" bgcolor="#ffeab6"><strong>맞은갯수</strong></td>
              <td width="1" rowspan="2" bgcolor="#c76b2e"></td>
              <td width="193" align="center" bgcolor="#ffeab6"><strong>틀린갯수</strong></td>
              </tr>
            <tr>
              <td height="30" align="center"><%: Model.ExamOfUser.ExamPoint %>점</td>
              <td align="center"><%: Model.ExamOfUser.CorrectCount %>개</td>
              <td align="center"><%: Model.ExamOfUser.IncorrectCount %>개</td>
              </tr>
            <tr>
              <td height="1" colspan="5" bgcolor="#c76b2e"></td>
              </tr>
            </table></td>
          </tr>
        <tr>
          <td background="/content/images/img_box01_02.jpg">&nbsp;</td>
          </tr>
        <tr>
          <td align="center" background="/content/images/img_box01_02.jpg"><table width="580" border="0" cellspacing="0" cellpadding="0">
            <tr>
              <td height="2" colspan="7" bgcolor="#b3a398"></td>
              </tr>
            <tr>
              <td width="144" height="26" align="center" bgcolor="#dfd5ce"><strong>표시</strong></td>
              <td width="1" bgcolor="#b3a398"></td>
              <td width="144" align="center" bgcolor="#dfd5ce"><strong>번호</strong></td>
              <td width="1" bgcolor="#b3a398"></td>
              <td width="144" align="center" bgcolor="#dfd5ce"><strong>정답</strong></td>
              <td width="1" bgcolor="#b3a398"></td>
              <td width="145" align="center" bgcolor="#dfd5ce"><strong>내가쓴답</strong></td>
              </tr>
          <% foreach (var item in Model.AnswersOfUser)
             {
          %>
            <tr>
              <td height="26" align="center"><strong><SPAN style="FONT-SIZE: 12px; LETTER-SPACING: 0px; line-height:18px; color:#eb1414"><%: item.IsCorrect ? "O" : "X"%></SPAN></strong></td>
              <td width="1" bgcolor="#b3a398"></td>
              <td align="center"><%: item.Answer.Chapter.Name %>- <%: item.Answer.QuestionNumber %></td>
              <td width="1" bgcolor="#b3a398"></td>
              <td align="center"><%: item.Answer.AnswerNumber%></td>
              <td width="1" bgcolor="#b3a398"></td>
              <td align="center"><%: item.AnswerNumberOfUser == 0 ? "-" : item.AnswerNumberOfUser.ToString()%></td>
            </tr>
            <tr>
              <td height="1" align="center" bgcolor="#b3a398"></td>
              <td width="1" bgcolor="#b3a398"></td>
              <td height="1" align="center" bgcolor="#b3a398"></td>
              <td width="1" bgcolor="#b3a398"></td>
              <td height="1" align="center" bgcolor="#b3a398"></td>
              <td width="1" bgcolor="#b3a398"></td>
              <td height="1" align="center" bgcolor="#b3a398"></td>
            </tr>
          <% } %>
            <tr>
              <td height="1" colspan="7" bgcolor="#b3a398"></td>
              </tr>
            </table></td>
          </tr>
        <tr>
          <td><img src="/content/images/img_box01_03.jpg" width="650" height="87" border="0" usemap="#Map_BT_OK01" /></td>
          </tr>
        </table></td>
      </tr>
    </table>