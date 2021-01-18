<%@ Page Language="C#"  AutoEventWireup="true" CodeBehind="EmployeeLogin.aspx.cs" Inherits="EmployeeWebSite.EmployeeLogin" %>

<!DOCTYPE html>

<html lang="en">
<head runat="server">
     <meta charset="utf-8" />
    <meta name="viewport" content="width=device-width, initial-scale=1, shrink-to-fit=no" />
    <link rel="stylesheet" href="https://stackpath.bootstrapcdn.com/bootstrap/4.4.1/css/bootstrap.min.css" >
   
    <title></title>
        <%-- CSS CODE RETRIEVED FROM BOOTSTRAP.COM --%>
</head>



    <body class="text-center" style="display: -ms-flexbox;
  display: -webkit-box;
  display: flex;
  -ms-flex-align: center;
  -ms-flex-pack: center;
  -webkit-box-align: center;
  align-items: center;
  -webkit-box-pack: center;
  justify-content: center;
  padding-top: 40px;
  padding-bottom: 40px;
  background-color: #f5f5f5;">
       
           
        <form id="form1" runat="server" style="width: 330px;">
       
           
              <asp:Label ID="Label1" runat="server" Text="Label" class ="h3 mb-3 font-weight-normal">Straight Walls Limited</asp:Label>
                <asp:TextBox ID="TextBox1" runat="server" placeholder="username" class="form-control"  style="padding: 10px;"></asp:TextBox>

             
                <asp:TextBox ID="TextBox2" runat="server" placeholder="password" class="form-control" style="padding: 10px;" TextMode="Password"></asp:TextBox>
   
                <asp:Label ID="Label2" runat="server"></asp:Label>
   
                <asp:Button ID="LoginBtn" runat="server" OnClick="LoginBtn_Click" Text="Login" class="btn btn-lg btn-primary btn-block" />
                <asp:HiddenField ID="HiddenField1" runat="server" />

        </form>
          

            
   

          

            
   

                
          
            

            
   

         
</body>
</html>
