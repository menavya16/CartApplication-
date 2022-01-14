<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Add.aspx.cs" Inherits="part3.Add" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
             <table align:"center" Style="margin-top:60px" cellpadding:"19">
                <tr>
                    <td>
                        <asp:HyperLink ID="HyperLink1" runat="server" Font-Size="Large" NavigateUrl="~/shopping.aspx">HOME</asp:HyperLink>
                     </td>
                    <td>
                        <asp:HyperLink ID="HyperLink2" runat="server" Font-Size="Large" NavigateUrl="~/AddProduct.aspx">ADD PRODUCT</asp:HyperLink>
                     </td>
                    <td>
                        <asp:HyperLink ID="HyperLink3" runat="server" Font-Size="Large" NavigateUrl="~/ShowProduct.aspx">SHOW PRODUCT</asp:HyperLink>
                     </td>
                </tr>
                </table>
           <hr />
            <h1 style="text-align: center; margin-top:70px">Welcome to Shopping center </h1>
        </div>
    </form>
</body>
</html>
