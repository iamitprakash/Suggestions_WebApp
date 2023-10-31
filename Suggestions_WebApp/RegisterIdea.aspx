<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="RegisterIdea.aspx.cs" Inherits="Suggestions_WebApp.RegisterIdea" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">  
 <div>  
   <table width="84%" cellpadding="0" cellspacing="0" style="border: solid 1px #3366CC;">  
         <tr>  
             <td colspan="4" style="height: 30px; background-color: #f5712b;">  
                 <span class="TextTitle" style="color: #FFFFFF;">Idea Submittion Form</span>  
             </td>  
         </tr>  
         <tr>  
             <td height="20px" colspan="0">  
             </td>  
         </tr>  
         <tr>  
             <td width="50%" valign="top">  
                 <table id="TableLogin" class="HomePageControlBGLightGray" cellpadding="4" cellspacing="4"  
                     runat="server" width="100%">  
                     <tr>  
                         <td colspan="3" align="center">  
                             <asp:Label ID="LabelMessage" ForeColor="Red" runat="server" EnableViewState="False"  
                                 Visible="False"></asp:Label><br>  
                         </td>  
                     </tr>  
                     <tr style="font-weight: normal; color: #000000">  
                         <td align="right">  
                             <span>Title:</span> 
                         </td>  
                         <td align="left" style="padding-left: 10px;">  
                             <asp:TextBox ID="TextBoxTitle"  runat="server" CssClass="textbox" Width="262px"  
                                 MaxLength="50" Height="34px" ></asp:TextBox>  
                         </td>  
                     </tr>  
                     <tr>  
                         <td align="right">  
                             <span class="TextTitle">Description:</span>  
                         </td>  
                         <td align="left" style="padding-left: 10px;">  
                             <asp:TextBox ID="TextBoxDescription" runat="server"  mode="multiline" CssClass="textbox" Width="480px"  
                                 MaxLength="50"  Height="110px"></asp:TextBox>  
                             <br />  
                         </td>  
                     </tr>  
                     <tr>  
                         <td align="right">  
                             <span class="TextTitle">Expected Duration:</span>  
                         </td>  
                         <td align="left" style="padding-left: 10px;">  
                            <%-- <asp:TextBox ID="TextBoxExpected_Duration" runat="server" CssClass="textbox" Width="258px"  
                                 MaxLength="50" Height="34px"></asp:TextBox>  --%>
                             <asp:Calendar ID="Calendar1" runat="server"></asp:Calendar>
                             <br />  
                         </td>  
                     </tr>  
                     <tr>  
                         <td align="right">  
                             <span class="TextTitle">Supported Docs:</span>  
                         </td>  
                         <td align="left" style="padding-left: 10px;">  
                             <asp:FileUpload ID="FileUpload1" runat="server" />
                             <br />  
                         </td>  
                     </tr>  
                     <tr>  
                         <td align="right">  
                         </td>  
                         <td align="left" style="padding-left: 10px;">  
                             <asp:Button ID="Button1" runat="server" Text="Submit" OnClick="Button1_Click" Width="87px" />  
                             <br />  
                         </td>  
                     </tr>  
                 </table>  
             </td>  
         </tr>  
     </table>  
 </div>  
 </form> 
</body>
</html>
