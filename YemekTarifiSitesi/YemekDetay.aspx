<%@ Page Title="" Language="C#" MasterPageFile="~/Kullanici.Master" AutoEventWireup="true" CodeBehind="YemekDetay.aspx.cs" Inherits="YemekTarifiSitesi.YemekDetay" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .auto-style3 {
            font-size: x-large;
        }
        .auto-style4 {
            width: 100%;
        }
        .auto-style5 {
            font-size: xx-large;
        }
        .auto-style8 {
            width: 141px;
        }
        .auto-style9 {
            width: 141px;
            text-align: right;
        }
        .auto-style10 {
            font-size: medium;
            font-weight: bold;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <strong>
    <asp:Label ID="Label3" runat="server" CssClass="auto-style5" Text="Label"></asp:Label>
    <br />
    </strong>
    <asp:DataList ID="DataList2" runat="server">
        <ItemTemplate>
            <table class="auto-style4">
                <tr>
                    <td>
                        <asp:Label ID="Label4" runat="server" CssClass="auto-style3" Text='<%# Eval("Yorum_adsoyad") %>'></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:Label ID="Label5" runat="server" CssClass="auto-style3" Text='<%# Eval("Yorum_icerik") %>'></asp:Label>
                        &nbsp;-
                        <asp:Label ID="Label6" runat="server" Text='<%# Eval("Yorum_tarih") %>'></asp:Label>
                    </td>
                </tr>
            </table>
        </ItemTemplate>
    </asp:DataList>
    <br />
    <div>
        Yorum Yapma Paneli
        <asp:Panel runat="server">
            <table class="auto-style4">
                <tr>
                    <td class="auto-style8">&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style9"><strong>Ad Soyad:</strong></td>
                    <td>
                        <asp:TextBox ID="TextBox1" runat="server" Height="20px" Width="200px"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style9"><strong>Mail:</strong></td>
                    <td>
                        <asp:TextBox ID="TextBox2" runat="server" Height="20px" TextMode="Email" Width="200px"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style9"><strong>Yorumunuz:</strong></td>
                    <td>
                        <asp:TextBox ID="TextBox3" runat="server" Height="100px" TextMode="MultiLine" Width="200px"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style8">&nbsp;</td>
                    <td><strong>
                        <asp:Button ID="Button1" runat="server" CssClass="auto-style10" OnClick="Button1_Click" Text="Yorum Yap" Width="200px" />
                        </strong></td>
                </tr>
            </table>
        </asp:Panel>
    </div>
</asp:Content>
