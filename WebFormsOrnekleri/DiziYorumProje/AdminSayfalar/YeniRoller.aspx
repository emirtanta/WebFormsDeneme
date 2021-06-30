<%@ Page Title="" Language="C#" MasterPageFile="~/Admin.Master" AutoEventWireup="true" CodeBehind="YeniRoller.aspx.cs" Inherits="DiziYorumProje.AdminSayfalar.YeniRoller" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <form runat="server" class="form-group">
        
        <asp:TextBox ID="txtRolAd" runat="server" CssClass="form-control" placeholder="Rol Adı" ></asp:TextBox>


        <br />

        <asp:Button ID="btnEkle" runat="server" Text="Ekle" CssClass="btn btn-info" OnClick="btnEkle_Click"  />

    </form>

</asp:Content>
