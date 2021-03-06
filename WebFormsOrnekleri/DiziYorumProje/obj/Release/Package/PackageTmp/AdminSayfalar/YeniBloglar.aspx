<%@ Page Title="" Language="C#" MasterPageFile="~/Admin.Master" AutoEventWireup="true" CodeBehind="YeniBloglar.aspx.cs" Inherits="DiziYorumProje.AdminSayfalar.YeniBloglar" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <form runat="server" class="form-group">
        
        <asp:TextBox ID="txtBaslik" runat="server" CssClass="form-control" placeholder="Blog Başlık"></asp:TextBox>

        <br />

        <asp:TextBox ID="txtTarih" runat="server" CssClass="form-control" placeholder="Blog Tarih"></asp:TextBox>

        <br />

        <asp:TextBox ID="txtGorsel" runat="server" CssClass="form-control" placeholder="Blog Görsel"></asp:TextBox>
        
        <br />

        <asp:Label ID="Label2" runat="server" Text="Tür Seçin"></asp:Label>
        <asp:DropDownList ID="drpTur" runat="server" CssClass="form-control" DataTextField="TURAD" DataValueField="TURID"></asp:DropDownList>

        <br />

        <asp:Label ID="Label1" runat="server" Text="Kategori Seçin"></asp:Label>
        <asp:DropDownList ID="drpKategori" runat="server" DataTextField="KATEGORIAD" DataValueField="KATEGORIID" CssClass="form-control"></asp:DropDownList>

        <br />

        <asp:TextBox ID="txtIcerik" runat="server" CssClass="form-control" placeholder="Blog İçerik" Height="100px" TextMode="MultiLine"></asp:TextBox>

        <br />

        <asp:Button ID="btnEkle" runat="server" Text="Ekle" CssClass="btn btn-info" OnClick="btnEkle_Click" />

    </form>

</asp:Content>
