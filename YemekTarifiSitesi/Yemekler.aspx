﻿<%@ Page Title="" Language="C#" MasterPageFile="~/Admin.Master" AutoEventWireup="true" CodeBehind="Yemekler.aspx.cs" Inherits="YemekTarifiSitesi.Yemekler" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .auto-style4 {
            background-color: #99CCFF;
        }

        .auto-style5 {
            background-color: #5887C1;
        }

        .auto-style6 {
            width: 288px;
        }

        .auto-style12 {
            width: 45px;
            text-align: center;
        }
        .auto-style13 {
            height: 29px;
        }
        .auto-style14 {
            font-size: medium;
            font-weight: bold;
        }
        .auto-style15 {
            height: 34px;
        }
        .auto-style16 {
            background-color: #0099FF;
        }
        .auto-style17 {
            background-color: #3399FF;
        }
        .auto-style18 {
            height: 34px;
            text-align: right;
        }
        .auto-style19 {
            height: 29px;
            text-align: right;
        }
        .auto-style20 {
            text-align: right;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:Panel ID="Panel1" runat="server" CssClass="auto-style4">
        <table class="auto-style1">
            <tr>
                <td class="auto-style12">
                    <asp:Button ID="Button1" runat="server" Text="+" Height="30px" Width="30px" OnClick="Button1_Click" />
                </td>
                <td class="auto-style12">
                    <asp:Button ID="Button2" runat="server" Height="30px" Text="-" Width="30px" OnClick="Button2_Click" />
                </td>
                <td><strong>YEMEK LİSTESİ</strong></td>
            </tr>
        </table>
    </asp:Panel>
    <asp:Panel ID="Panel2" runat="server" CssClass="auto-style5">
        <asp:DataList ID="DataList1" runat="server" Width="450px" CssClass="auto-style16">
            <ItemTemplate>
                <table class="auto-style1">
                    <tr>
                        <td class="auto-style6">
                            <asp:Label ID="Label1" runat="server" CssClass="auto-style8" Text='<%# Eval("Yemek_ad") %>'></asp:Label>
                        </td>
                        <td class="auto-style7">
                            <a href="Yemekler.aspx?Yemek_id=<%#Eval("Yemek_id")%>&islem=sil"><asp:Image ID="Image2" runat="server" Height="30px" ImageUrl="~/Iconlar/delete.png" Width="30px" /></a>
                        </td>
                        <td class="auto-style9">
                            <a href="YemekDuzenle.aspx?Yemek_id=<%#Eval("Yemek_id")%>"><asp:Image ID="Image3" runat="server" Height="30px" ImageUrl="~/Iconlar/update.png" Width="30px" /></a>
                        </td>
                    </tr>
                </table>
            </ItemTemplate>
        </asp:DataList>
    </asp:Panel>
    <asp:Panel ID="Panel3" runat="server" CssClass="auto-style4">

        <table class="auto-style1">
            <tr>
                <td class="auto-style12">
                    <asp:Button ID="Button3" runat="server" Text="+" Height="30px" Width="30px" OnClick="Button3_Click" />
                </td>
                <td class="auto-style12">
                    <asp:Button ID="Button4" runat="server" Height="30px" Text="-" Width="30px" OnClick="Button4_Click" />
                </td>
                <td><strong>YEMEK EKLEME</strong></td>
            </tr>
        </table>
    </asp:Panel>
    <asp:Panel ID="Panel4" runat="server" CssClass="auto-style17">
        <table class="auto-style1">
            <tr>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style20"><strong>Yemek Ad:</strong></td>
                <td>
                    <asp:TextBox ID="TextBox1" runat="server" Height="30px" Width="250px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style19"><strong>Malzemeler:</strong></td>
                <td class="auto-style13">
                    <asp:TextBox ID="TextBox2" runat="server" Height="100px" TextMode="MultiLine" Width="250px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style18"><strong>Yemek Tarifi:</strong></td>
                <td class="auto-style15">
                    <asp:TextBox ID="TextBox3" runat="server" Height="200px" TextMode="MultiLine" Width="250px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style18"><strong>Kategori:</strong></td>
                <td class="auto-style15">
                    <asp:DropDownList ID="DropDownList1" runat="server" Height="30px" Width="250px">
                    </asp:DropDownList>
                </td>
            </tr>
            <tr>
                <td class="auto-style15"></td>
                <td class="auto-style15"><strong>
                    <asp:Button ID="Button5" runat="server" CssClass="auto-style14" Height="30px" OnClick="Button5_Click" Text="Ekle" Width="100px" />
                    </strong></td>
            </tr>
        </table>

    </asp:Panel>
</asp:Content>
