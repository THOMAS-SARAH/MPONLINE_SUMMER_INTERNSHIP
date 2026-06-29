<%@ Page Language="C#" %>

<!DOCTYPE html>
<html>
<head>
    <title>Current Time</title>
</head>
<body>
    <form runat="server">
        <asp:Button ID="Button1" runat="server" Text="Show Time" OnClick="Button1_Click" />
        <br /><br />
        <asp:Label ID="Label1" runat="server"></asp:Label>

        <script runat="server">
            protected void Button1_Click(object sender, EventArgs e)
            {
                Label1.Text = DateTime.Now.ToString();
            }
        </script>
    </form>
</body>
</html>
