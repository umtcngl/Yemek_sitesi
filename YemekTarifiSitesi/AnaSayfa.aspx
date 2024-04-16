<%@ Page Title="" Language="C#" MasterPageFile="~/Kullanici.Master" AutoEventWireup="true" CodeBehind="AnaSayfa.aspx.cs" Inherits="YemekTarifiSitesi.AnaSayfa" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .auto-style3 {
            width: 100%;
        }

        .auto-style5 {
            font-size: x-large;
            color: #FF5050;
            background-color: #FFFF99;
        }

        .auto-style6 {
            height: 26px;
            width: 417px;
        }

        .auto-style7 {
            height: 26px;
            width: 417px;
            background-color: #FFFF99;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <p>
        <asp:DataList ID="DataList2" runat="server" Width="445px">
            <ItemTemplate>
                <table class="auto-style3">
                    <tr>
                        <td class="auto-style7">&nbsp;
                            <a href="YemekDetay.aspx?Yemek_id=<%#Eval("Yemek_id") %>">
                                <strong>
                                    <asp:Label ID="Label3" runat="server" CssClass="auto-style5" Text='<%# Eval("Yemek_ad") %>'></asp:Label>
                                </strong>
                            </a>
                        </td>
                    </tr>
                    <tr>
                        <td class="auto-style6"><strong>Malzemeler:</strong>
                            <asp:Label ID="Label4" runat="server" Text='<%# Eval("Yemek_malzeme") %>'></asp:Label>
                        </td>
                    </tr>
                    <tr>
                        <td class="auto-style6"><strong>Tarif:</strong>
                            <asp:Label ID="Label5" runat="server" Text='<%# Eval("Yemek_tarif") %>'></asp:Label>
                        </td>
                    </tr>
                    <tr>
                        <td class="auto-style6"><strong>Eklenme Tarihi:
                            <asp:Label ID="Label6" runat="server" Text='<%# Eval("Yemek_tarih") %>'></asp:Label>
                            &nbsp;-</strong> <em><strong>Puan:
                            <asp:Label ID="Label7" runat="server" Text='<%# Eval("Yemek_puan") %>'></asp:Label>
                            </strong></em></td>
                    </tr>
                </table>
            </ItemTemplate>
        </asp:DataList>
    </p>
</asp:Content>
