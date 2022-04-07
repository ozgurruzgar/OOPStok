<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="UrunEkle.aspx.cs" Inherits="OOPStok.UrunEkle" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">

          <form runat="server" class ="form-group">
        <div>
            <%--<asp:Label ID="Label1" runat="server" Text="Departman Adı:" Font-Bold="true"></asp:Label>--%>
            <asp:TextBox ID="TextBox1" runat="server" CssClass="form-control" placeholder="Ürün Adı...">
            </asp:TextBox>
        </div>
        <br />
          <div>
            <asp:TextBox ID="TextBox2" runat="server" CssClass="form-control" placeholder="Ürün Fiyatı...">
            </asp:TextBox>
          </div>
          <br />
          <div>
            <asp:TextBox ID="TextBox3" runat="server" CssClass="form-control" placeholder="Ürün Adeti...">
            </asp:TextBox>
          </div>
        <div>
            <asp:Button ID="Button1" runat="server" Text="Ürünü Ekle" CssClass="btn btn-primary" OnClick="Button1_Click"  />
        </div>
    </form>
</asp:Content>
