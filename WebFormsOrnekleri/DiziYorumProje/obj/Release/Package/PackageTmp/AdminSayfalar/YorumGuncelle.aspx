<%@ Page Title="" Language="C#" MasterPageFile="~/Admin.Master" AutoEventWireup="true" CodeBehind="YorumGuncelle.aspx.cs" Inherits="DiziYorumProje.AdminSayfalar.YorumGuncelle" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

     <form runat="server" class="form-group">
        
        <asp:TextBox ID="txtBlogBaslik" runat="server" CssClass="form-control" placeholder="Blog Başlık" Enabled="false"></asp:TextBox>


        <br />

         <asp:TextBox ID="txtKullaniciAdi" runat="server" CssClass="form-control" placeholder="Kullanıcı Adı" ></asp:TextBox>

         <br />

        <asp:TextBox ID="txtYorumIcerik" runat="server" CssClass="form-control" placeholder="Yorum İçerik" Height="100px" TextMode="MultiLine"></asp:TextBox>

        <br />

        <asp:Button ID="btnYorumGuncelle" runat="server" Text="Güncelle" CssClass="btn btn-info" OnClick="btnYorumGuncelle_Click"   />

    </form>


</asp:Content>
