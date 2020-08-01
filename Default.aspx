<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>

</head>
<body>
    <form id="form1" runat="server">
    
<asp:Label ID="Label1" runat="server">From Email Address:   </asp:Label>
<asp:TextBox ID="txtFrom" runat="server"></asp:TextBox>   

<asp:Label ID="lblPass" runat="server">Email Password:   </asp:Label>
<asp:TextBox ID="txtPass" runat="server" TextMode="Password" ></asp:TextBox> 

<asp:Label ID="EmailServer" runat="server">Email Server</asp:Label>
<asp:TextBox ID="txtMailServer" runat="server"></asp:TextBox>    

<asp:Label ID="Label2"  runat="server">Recipient Email Address: </asp:Label>
<asp:TextBox ID="txtTo" runat="server"></asp:TextBox>

<asp:Label ID="Label3" runat="server">Subject</asp:Label>
<asp:TextBox ID="txtSubject" runat="server"></asp:TextBox>

<asp:Label ID="Label4" runat="server">Mail Body:</asp:Label>
<textarea runat="server" id="txtContent"></textarea>

<asp:Button ID="btnSend" runat="server" Text="Send" OnClick="btnSend_Click1"></asp:Button>
<asp:Label ID="lblStatus" runat="server"> </asp:Label>

    </form>
</body>
</html>
