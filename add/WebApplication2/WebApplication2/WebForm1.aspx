<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="WebApplication2.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            Visitor Number:
            <asp:Label ID="lblcount" runat="server"></asp:Label><br/>
            <asp:Label ID="Label1" runat="server"></asp:Label>
            <br />
            <br />
            <asp:Label ID="Label2" runat="server" Text="Current Date and Time : "></asp:Label>
            <asp:Label ID="lblDateTime" runat="server"></asp:Label>
            <br />
            <br />
            <br />
        </div>      
    </form>
</body>
</html>
