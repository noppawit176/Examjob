<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="Examjob.WebForm1" %>

<!DOCTYPE html>

<html>
   
<head>
    <meta charset="utf-8">
    <link rel="stylesheet" href="https://stackpath.bootstrapcdn.com/bootstrap/4.3.1/css/bootstrap.min.css" integrity="sha384-ggOyR0iXCbMQv3Xipma34MD+dH/1fQ784/j6cY/iJTQUOhcWr7x9JvoRxT2MZw1T" crossorigin="anonymous">
    <script src="https://code.jquery.com/jquery-3.3.1.slim.min.js" integrity="sha384-q8i/X+965DzO0rT7abK41JStQIAqVgRVzpbzo5smXKp4YfRvH+8abtTE1Pi6jizo" crossorigin="anonymous"></script>
    <script src="https://cdnjs.cloudflare.com/ajax/libs/popper.js/1.14.7/umd/popper.min.js" integrity="sha384-UO2eT0CpHqdSJQ6hJty5KVphtPhzWj9WO1clHTMGa3JDZwrnQq4sF86dIHNDz0W1" crossorigin="anonymous"></script>
    <script src="https://stackpath.bootstrapcdn.com/bootstrap/4.3.1/js/bootstrap.min.js" integrity="sha384-JjSmVgyd0p3pXB1rRibZUAYoIIy6OrQ6VrjIEaFf/nJGzIxFDsf4x0xIM+B07jRM" crossorigin="anonymous"></script>
            <div class="jumbotron text-center">
                    <h1>Exam for job Meyer</h1> 
                <form runat="server">

        <asp:Label id="lblText" runat="server" text="Seach User"></asp:Label>
        <asp:TextBox id="txtName" runat="server"></asp:TextBox>
        <asp:Button id="Button1" Text="Seach" runat="server"/>
            </div>
</head>
<body>




    <div runat="server" class="jumbotron text-center">
       <asp:Table runat="server" BackColor="White" BorderColor="Black" BorderWidth="1px" ForeColor="Black" HorizontalAlign="Center">
        <asp:TableHeaderRow>
            <asp:TableHeaderCell><h2>name</h2></asp:TableHeaderCell>
        </asp:TableHeaderRow>
           <asp:TableRow>
               <asp:TableCell ID="usertext" Text=""></asp:TableCell>
           </asp:TableRow>
           
       </asp:Table>
      
    </div>
       </form>
</body>
</html>
