<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="parcelPriceCalculator.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <strong>Parcel Price Calculator </strong>
            <br />
            <br />
            Width: <asp:TextBox ID="widthBox" runat="server"></asp:TextBox>
            <br />
            <br />
            Height:
            <asp:TextBox ID="heightBox" runat="server"></asp:TextBox>
            <br />
            <br />
            Length:
            <asp:TextBox ID="lengthBox" runat="server"></asp:TextBox>
            <br />
            <br />
            <asp:RadioButton ID="groundRadio" runat="server" GroupName="radioButtons" Text="Ground" />
            <br />
            <asp:RadioButton ID="airRadio" runat="server" GroupName="radioButtons" Text="Air" />
            <br />
            <asp:RadioButton ID="nextDayRadio" runat="server" GroupName="radioButtons" Text="Next Day" />
            <br />
            <br />
            <asp:Button ID="calculateBtn" runat="server" OnClick="calculateBtn_Click" Text="Calculate " />
&nbsp;<asp:Label ID="resultLabel" runat="server"></asp:Label>
            <br />
            <br />
            <asp:Label ID="errorLabel" runat="server"></asp:Label>
        </div>
    </form>
</body>
</html>
