<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="PersonelEkle.aspx.cs" Inherits="OOPStok.PersonelEkle" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">
      <form runat="server" class ="form-group">
        <div>
            <%--<asp:Label ID="Label1" runat="server" Text="Departman Adı:" Font-Bold="true"></asp:Label>--%>
            <asp:TextBox ID="TextBox1" runat="server" CssClass="form-control" placeholder="Personel Adı...">
            </asp:TextBox>
        </div>
        <br />
          <div>
            <asp:TextBox ID="TextBox2" runat="server" CssClass="form-control" placeholder="Personel Soyadı...">
            </asp:TextBox>
          </div>
          <br />
          <div>
            <asp:TextBox ID="TextBox3" runat="server" CssClass="form-control" placeholder="Personel Maaşı...">
            </asp:TextBox>
          </div>        
          <br />
          <div>
              <asp:DropDownList ID="DropDownList1" runat="server" CssClass ="form-control"></asp:DropDownList>
          </div>
           <br />
        <div>
            <asp:Button ID="Button1" runat="server" Text="Personeli Ekle" CssClass="btn btn-primary" OnClick="Button1_Click" />
        </div>
    </form>
</asp:Content>
