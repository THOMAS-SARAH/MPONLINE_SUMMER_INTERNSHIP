<%@ Page Language="C#" %>

<!DOCTYPE html>
<html>
<head>
    <title>Simple Calculator</title>
</head>
<body>
    <form runat="server">
        Enter First Number:
        <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
        <br /><br />

        Enter Second Number:
        <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
        <br /><br />

        <asp:Button ID="Button1" runat="server" Text="Add" OnClick="Button1_Click" />
        <br /><br />

        <asp:Label ID="Label1" runat="server"></asp:Label>

        <script runat="server">
            protected void Button1_Click(object sender, EventArgs e)
            {
                int a = Convert.ToInt32(TextBox1.Text);
                int b = Convert.ToInt32(TextBox2.Text);
                Label1.Text = "Sum = " + (a + b);
            }
        </script>
    </form>
</body>
</html>
