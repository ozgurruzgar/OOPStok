<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="MusteriGuncelle.aspx.cs" Inherits="OOPStok.MusteriGuncelle" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">
          <form runat="server" class ="form-group">
        <div>
            <%--<asp:Label ID="Label1" runat="server" Text="Departman Adı:" Font-Bold="true"></asp:Label>--%>
            <div>
              <asp:TextBox ID="TextBox3" runat="server" CssClass="form-control" placeholder="Müşteri ID..." Enabled="False">
            </asp:TextBox>
        </div>
        <br />
            <asp:TextBox ID="TextBox1" runat="server" CssClass="form-control" placeholder="Müşteri Adı...">
            </asp:TextBox>
        </div>
        <br />
          <div>
            <asp:TextBox ID="TextBox2" runat="server" CssClass="form-control" placeholder="Müşteri Soyadı...">
            </asp:TextBox>
          </div>
          <br />
        <div>
            <asp:Button ID="Button1" runat="server" Text="Müşteri Güncelle" CssClass="btn btn-success" OnClick="Button1_Click"  />
        </div>
    </form>
</asp:Content>
