<%@ Page Title="" Language="C#" MasterPageFile="~/Kullanici.Master" AutoEventWireup="true" CodeBehind="GununYemegi.aspx.cs" Inherits="YemekTarifiSitesi.GununYemegi" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .auto-style3 {
            width: 137px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:DataList ID="DataList2" runat="server">
        <ItemTemplate>
            <table class="auto-style1">
                <tr>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td>
                        <asp:Label ID="Label8" runat="server" style="font-weight: 700; font-size: x-large" Text='<%# Eval("Yemek_ad") %>'></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td><strong>Malzemeler: </strong>
                        <asp:Label ID="Label9" runat="server" Text='<%# Eval("Yemek_malzeme") %>'></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td><strong>Tarif:</strong>
                        <asp:Label ID="Label10" runat="server" Text='<%# Eval("Yemek_tarif") %>'></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:Image ID="Image1" runat="server" Height="220px" Width="422px" ImageUrl='<%# Eval("Yemek_resim") %>' />
                    </td>
                </tr>
                <tr>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td>
                        <table class="auto-style1">
                            <tr>
                                <td class="auto-style3"><strong>Puan:</strong>&nbsp;<asp:Label ID="Label11" runat="server" Text='<%# Eval("Yemek_puan") %>'></asp:Label>
                                </td>
                                <td style="text-align: right"><strong>Eklenme Tarihi:</strong>&nbsp;<asp:Label ID="Label12" runat="server" style="font-style: italic" Text='<%# Eval("Yemek_tarih") %>'></asp:Label>
                                </td>
                            </tr>
                        </table>
                    </td>
                </tr>
                <tr>
                    <td>&nbsp;</td>
                </tr>
            </table>
        </ItemTemplate>
    </asp:DataList>
</asp:Content>
