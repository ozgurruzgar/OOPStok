<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="Satis.aspx.cs" Inherits="OOPStok.Satis" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">
        <table class="table table-bordered">
        <tr>
            <th>SATIŞ ID</th>
            <th>ÜRÜN AD</th>
            <th>PERSONEL</th>
            <th>MÜŞTERİ</th>
            <th>TUTAR</th>
        </tr>
        <tbody>
            <asp:Repeater ID="Repeater1" runat="server">
                <ItemTemplate>
            <tr>
                <td><%#Eval("SATISID")%></td>
                <td><%#Eval("URUNAD")%></td>
                <td><%#Eval("PERSONELAD")%></td>
                <td><%#Eval("MUSTERIAD")%></td>
                <td><%#Eval("Fiyat")%></td>
               </tr>
                </ItemTemplate>
            </asp:Repeater>
        </tbody>
    </table>
    <a href="SatisEkle.aspx" class="btn btn-info">Yeni Satış Ekle</a>
</asp:Content>
