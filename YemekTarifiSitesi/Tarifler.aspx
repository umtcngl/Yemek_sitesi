<%@ Page Title="" Language="C#" MasterPageFile="~/Admin.Master" AutoEventWireup="true" CodeBehind="Tarifler.aspx.cs" Inherits="YemekTarifiSitesi.Tarifler" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .auto-style7 {
            text-align: right;
        }
        .auto-style8 {
            width: 68px;
        }
        .auto-style9 {
            width: 43px;
        }
        .auto-style10 {
            width: 45px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
     <asp:Panel ID="Panel1" runat="server" CssClass="auto-style4">
        <table class="auto-style1">
            <tr>
                <td class="auto-style9">
                    <asp:Button ID="Button1" runat="server" Text="+" Height="30px" Width="30px" OnClick="Button1_Click" />
                </td>
                <td class="auto-style10">
                    <asp:Button ID="Button2" runat="server" Height="30px" Text="-" Width="30px" OnClick="Button2_Click" />
                </td>
                <td><strong>ONAYLI TARİF LİSTESİ</strong></td>
            </tr>
        </table>
    </asp:Panel>
    <asp:Panel ID="Panel2" runat="server" CssClass="auto-style5">
        <asp:DataList ID="DataList1" runat="server" Width="450px" CssClass="auto-style16">
            <ItemTemplate>
                <table class="auto-style1">
                    <tr>
                        <td class="auto-style11">
                            <asp:Label ID="Label1" runat="server" CssClass="auto-style8" Text='<%# Eval("Tarif_ad") %>'></asp:Label>
                        </td>
                        <td class="auto-style7">
                            <asp:Image ID="Image3" runat="server" Height="30px" ImageUrl="~/Iconlar/goruntule.png" Width="30px" />
                        </td>
                    </tr>
                </table>
            </ItemTemplate>
        </asp:DataList>
    </asp:Panel>
    <asp:Panel ID="Panel3" runat="server" CssClass="auto-style4">
        <table class="auto-style1">
            <tr>
                <td class="auto-style9">
                    <asp:Button ID="Button3" runat="server" Text="+" Height="30px" Width="30px" OnClick="Button3_Click" />
                </td>
                <td class="auto-style10">
                    <asp:Button ID="Button4" runat="server" Height="30px" Text="-" Width="30px" OnClick="Button4_Click" />
                </td>
                <td><strong>ONAYSIZ TARİF LİSTESİ</strong></td>
            </tr>
        </table>
    </asp:Panel>
    <asp:Panel ID="Panel4" runat="server" CssClass="auto-style5">
        <asp:DataList ID="DataList2" runat="server" Width="450px" CssClass="auto-style16">
            <ItemTemplate>
                <table class="auto-style1">
                    <tr>
                        <td class="auto-style11">
                            <asp:Label ID="Label2" runat="server" CssClass="auto-style8" Text='<%# Eval("Tarif_ad") %>'></asp:Label>
                        </td>
                        <td class="auto-style7">
                            <a href="TarifOnerDetay.aspx?Tarif_id=<%#Eval("Tarif_id") %>"><asp:Image ID="Image1" runat="server" Height="30px" ImageUrl="~/Iconlar/goruntule.png" Width="30px" /></a>
                        </td>
                    </tr>
                </table>
            </ItemTemplate>
        </asp:DataList>
    </asp:Panel>
</asp:Content>
