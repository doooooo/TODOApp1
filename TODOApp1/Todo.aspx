<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Todo.aspx.cs" Inherits="TODOApp1.Todo" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <table style="width:100%;">
            <tr>
                <td style="font-weight: bold">ToDo List</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td>Add Item</td>
                <td>
                    <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
                    <asp:Button ID="Add" runat="server" Text="Add" OnClick="Add_Click" />
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td>Search</td>
                <td>
                    <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
                    <asp:Button ID="Search" runat="server" Text="Search" OnClick="Search_Click" />
                </td>
                <td>&nbsp;</td>
            </tr>
             <tr>
                <td>Check Last Item</td>
                <td>
                    <asp:Button ID="Last" runat="server" Text="Check" OnClick="Last_Click" />
                 </td>
                <td>&nbsp;</td>
            </tr>
             <tr>
                <td>Remove Item</td>
                <td>
                    <asp:Button ID="Remove" runat="server" Text="Remove" OnClick="Remove_Click" />
                 </td>
                <td>&nbsp;</td>
            </tr>
             <tr>
                <td>Clear</td>
                <td>
                    <asp:Button ID="Clr" runat="server" Text="Clear" OnClick="Clr_Click" />
                 </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td>&nbsp;</td>
                <td>
                    
                    <asp:Button ID="Save" runat="server" OnClick="Save_Click" Text="Save" />
                    
                 </td>
                <td>&nbsp;</td>
            </tr>
             <tr>
                <td>&nbsp;</td>
                <td>
                    <asp:Label ID="Output" runat="server"></asp:Label>
                 </td>
                <td>&nbsp;</td>
            </tr>
             <tr>
                <td>&nbsp;</td>
                <td>
                    <asp:ListBox ID="ListBox1" runat="server"></asp:ListBox>
                 </td>
                <td>&nbsp;</td>
            </tr>
        </table>
    
    </div>
    </form>
</body>
</html>
