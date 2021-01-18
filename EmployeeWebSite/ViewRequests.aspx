<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ViewRequests.aspx.cs" Inherits="EmployeeWebSite.ViewRequests" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Panel ID="Panel1" runat="server" BorderColor="#3399FF">
                <asp:Label ID="Label3" runat="server" Text="View Holiday Bookings" Font-Bold="True" Font-Size="Large" Font-Underline="True"></asp:Label>
            </asp:Panel>
        </div>
        <asp:Label ID="Label1" runat="server" Text="Approved"></asp:Label>
        <asp:GridView ID="GridView1" runat="server">
        </asp:GridView>
        <asp:Label ID="Label2" runat="server" Text="Rejected"></asp:Label>
        <asp:GridView ID="GridView2" runat="server">
        </asp:GridView>
    </form>
</body>
</html>
