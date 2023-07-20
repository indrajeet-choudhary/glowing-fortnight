<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Register.aspx.cs" Inherits="Appointment.Register" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Appointment Scheduler
    </title>
    <script type="text/Javascript">
        function validate() {
            var pass1 = document.getElementById("txtpass").value;
            var pass2 = document.getElementById("txtpass2").value;
            if (pass2 != pass1) {
                alert("Please enter same Password as above");
            }
    </script>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="lblname" runat="server" Text="Name"></asp:Label>
            <asp:TextBox ID="txtname" runat="server"></asp:TextBox><br />
            <asp:Label ID="lblemail" runat="server" Text="Mail Id"></asp:Label>
            <asp:TextBox ID="txtemail" runat="server"></asp:TextBox><br />
            <asp:Label ID="lblpass" runat="server" Text="Create Password"></asp:Label>
            <asp:TextBox ID="txtpass" runat="server"></asp:TextBox><br />
            <asp:Label ID="lblpass2" runat="server" Text="Confirm Password"></asp:Label>
            <asp:TextBox ID="txtpass2" runat="server"></asp:TextBox><br />
            <asp:Button ID="btnSubmit" runat="server" Text="Submit" OnClick="btnSubmit_Click" />
            <asp:Button ID="btncancel" runat="server" Text="Cancel" /><br />
            <asp:Label ID="Message" runat="server" ></asp:Label>
        </div>
    </form>
</body>
</html>
