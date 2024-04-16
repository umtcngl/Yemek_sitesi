<%@ Page Title="" Language="C#" MasterPageFile="~/Admin.Master" AutoEventWireup="true" CodeBehind="TarifOnerDetay.aspx.cs" Inherits="YemekTarifiSitesi.TarifOnerDetay" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .auto-style7 {
            text-align: left;
            margin-left: 80px;
            width: 280px;
        }

        .auto-style9 {
            height: 26px;
            margin-left: 40px;
            width: 280px;
        }

        .auto-style10 {
            text-align: right;
            margin-left: 40px;
            font-weight: bold;
        }

        .auto-style14 {
            width: 158px;
            margin-left: 40px;
        }

        .auto-style15 {
            height: 26px;
            text-align: right;
            width: 158px;
            margin-left: 40px;
        }

        .auto-style16 {
            text-align: right;
            width: 158px;
            margin-left: 40px;
        }
        .auto-style17 {
            width: 280px;
            margin-left: 40px;
            text-align: center;
        }
        .auto-style18 {
            width: 280px;
        }
        .auto-style19 {
            text-align: left;
            width: 280px;
        }
        .auto-style20 {
            width: 280px;
            margin-left: 40px;
        }
        .auto-style21 {
            text-align: right;
        }
        .auto-style22 {
            width: 280px;
            margin-left: 40px;
            text-align: left;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:Panel runat="server">
        <table class="auto-style4">
            <tr>
                <td class="auto-style14">&nbsp;</td>
                <td class="auto-style18">&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style15"><strong>Tarif Adı:</strong></td>
                <td class="auto-style19">
                    <asp:TextBox ID="TextBox1" runat="server" Height="20px" Width="200px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style15"><strong>Malzemeler:</strong></td>
                <td class="auto-style19">
                    <asp:TextBox ID="TextBox2" runat="server" Height="20px" Width="200px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style15"><strong>Yapılış:</strong></td>
                <td class="auto-style7">
                    <asp:TextBox ID="TextBox3" runat="server" Height="100px" TextMode="MultiLine" Width="200px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style16"><strong>Tarif Resim:</strong></td>
                <td class="auto-style20">
                    <asp:FileUpload ID="FileUpload1" runat="server" Width="200px" />
                </td>
            </tr>
            <tr>
                <td class="auto-style15"><strong>Tarif Öneren:</strong></td>
                <td class="auto-style9">
                    <asp:TextBox ID="TextBox4" runat="server" Width="200px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style16"><strong>Öneren Mail:</strong></td>
                <td class="auto-style20">
                    <asp:TextBox ID="TextBox5" runat="server" Width="200px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style21"><strong>Kategori:</strong></td>
                <td class="auto-style22">
                    <asp:DropDownList ID="DropDownList1" runat="server" Width="200px">
                    </asp:DropDownList>
                    </td>
            </tr>
            <tr>
                <td></td>
                <td class="auto-style17">
                    <asp:Button ID="Button1" runat="server" CssClass="auto-style10" OnClick="Button1_Click" Text="Onayla" Width="156px" />
                </td>
            </tr>
        </table>
    </asp:Panel>
</asp:Content>
