<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ShowProduct.aspx.cs" Inherits="part3.ShowProduct" %>

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
             <table align="center" cellpadding="10">
       <tr>
         <td>
             <asp:Button ID="Button1" runat="server" Text="&lt;&lt;" Width="60px" 
                 onclick="Button1_Click" Visible="False" />
         </td>
         <td>
             <asp:Button ID="Button2" runat="server" Text="&gt;&gt;" Width="60px" 
                 onclick="Button2_Click" Visible="False" />
         </td>
          <td>
              <asp:Label ID="Label4" runat="server"></asp:Label>
          </td>
       </tr>
     </table>

     <center style="margin-top:60px">
         <asp:Label ID="Label3" runat="server" Font-Names="Algerian" Font-Size="Large" Visible="False">No product in the Cart</asp:Label>
     </center>


     <table align="center" style="margin-top:50px;font-size:18px" cellpadding="10" runat="server" id="pd"> 
      <tr>
       <td>Product name</td>
       <td>
           <asp:Label ID="Label2" runat="server" Font-Size="Large" ForeColor="Blue"></asp:Label>
       </td>
      </tr>

      <tr>
       <td>Product photo</td>
       <td>
           <asp:Image ID="Image1" runat="server" Width="100px" />
       </td>
      </tr>

      <tr>
       <td>Product price</td>
       <td>
           <asp:Label ID="Label1" runat="server" Font-Bold="False" Font-Size="Large" 
               ForeColor="Blue"></asp:Label>
       </td>
      </tr>
      </table>


    </div>
    </form>
</body>

</html>