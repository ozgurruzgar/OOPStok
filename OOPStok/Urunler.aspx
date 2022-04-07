<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="Urunler.aspx.cs" Inherits="OOPStok.Urunler" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">
    <table class="table table-bordered">
        <tr>
            <th>ÜRÜN ID</th>
            <th>ÜRÜN ADI</th>
            <th>ÜRÜN FİYATI</th>
            <th>ÜRÜN ADETİ</th>
        </tr>
        <tbody>
            <asp:Repeater ID="Repeater1" runat="server">
                <ItemTemplate>
            <tr>
                <td><%#Eval("URUNID")%></td>
                <td><%#Eval("URUNAD")%></td>
                <td><%#Eval("URUNFIYAT")%></td>
                <td><%#Eval("URUNADET")%></td>
               </tr>
                </ItemTemplate>
            </asp:Repeater>
        </tbody>
    </table>
        <a href="UrunEkle.aspx" class="btn btn-info">Yeni Ürün Ekle</a>
</asp:Content>
