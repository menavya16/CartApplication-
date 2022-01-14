<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="slideshow.aspx.cs" Inherits="part2.slideshow" %>

<!DOCTYPE html>
<!--Ctrl K and Ctrl D toformat things ;; gives you partial page postbacks with no screen flickers, is why we needs update panel and 
    contenttemplate-->
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    
    <form id="form1" runat="server">
             <asp:ScriptManager ID="ScriptManager1" runat="server"></asp:ScriptManager>
            <asp:UpdatePanel ID="UpdatePanel1" runat="server">
                <ContentTemplate>
                    <asp:Timer ID="Timer1" runat="server" Interval="1000" OnTick="Timer1_Tick" Enabled="false"></asp:Timer>
                    <asp:Timer ID="Timer2" runat="server" Interval="1000" OnTick="Timer2_Tick" Enabled="false"></asp:Timer>
                    <asp:Timer ID="Timer3" runat="server" Interval="1000" OnTick="Timer3_Tick" Enabled="true">
                    </asp:Timer>
                    <asp:Image ID="Image1" height="500px" Width="800px" runat="server" />
                    <asp:Label ID="Label1" runat="server"></asp:Label>
                    <br />Description: <asp:Label ID="lblImageName" runat="server"></asp:Label><br />
                    Order: <asp:Label ID="lblImageOrder" runat="server"></asp:Label>
                    </ContentTemplate>
                </asp:UpdatePanel>
                    <p>
                    <asp:Button ID="Button1" runat="server" Text="Random" OnClick="Button1_Click" />
                    </p>
             <p>
                 <asp:Button ID="Button2" runat="server" Text="Sequential" OnClick="Button2_Click" />
             </p>
             <p>
                    <asp:Button ID="Button3" runat="server" Text="Stop" OnClick="Button3_Click" />
                    </p>
         <p>
                    <asp:Button ID="Button4" runat="server" Text="<<" OnClick="Button4_Click" />
                    </p>
    </form>
</body>
</html>
