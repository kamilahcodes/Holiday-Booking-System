<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="SubmitHolidayRequest.aspx.cs" Inherits="EmployeeWebSite.SubmitHolidayRequest" %>

<!DOCTYPE html>

<html lang="en">
<head runat="server">
     <meta charset="utf-8" />
    <meta name="viewport" content="width=device-width, initial-scale=1, shrink-to-fit=no" />
    <link rel="stylesheet" href="https://stackpath.bootstrapcdn.com/bootstrap/4.4.1/css/bootstrap.min.css" >
     <%-- CSS CODE RETRIEVED FROM BOOTSTRAP.COM --%>
    <title></title>
</head>
<body style="height: 267px">
    <form id="form1" runat="server">
        <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
          

        
        <div style="position: absolute; left: 200px;">
            <asp:Label ID="Label2" runat="server" Text="Select a Start Date"></asp:Label>
            <br />
            <asp:Calendar ID="Calendar1" runat="server"></asp:Calendar>

        </div>
        <div style="position: absolute; right: 200px;">
            
            <asp:Label ID="Label3" runat="server" style="text-align: center" Text="Select an End Date"></asp:Label>
            <asp:Calendar ID="Calendar2" runat="server"></asp:Calendar>
             <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Submit Request" />
         </div>
         
     
        
            
         
     
        <p>
          
        <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="View Past Requests" />


        
        </p>
         
     
        
            
         
     
    </form>
</body>
</html>
