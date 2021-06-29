<%@ Page Title="" Language="C#" MasterPageFile="~/Admin.Master" AutoEventWireup="true" CodeBehind="AdminYetenekGuncelle.aspx.cs" Inherits="BlogWeb.AdminYetenekGuncelle" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">

    <form id="Form1" runat="server">
        <div class="form-group">


            <div>
                <asp:Label ID="Label2" runat="server" Text="Id"></asp:Label>
                <asp:TextBox ID="txtId" runat="server" CssClass="form-control"></asp:TextBox>
            </div>

            <br />

            <div>
                <asp:Label ID="Label1" runat="server" Text="Yetenek"></asp:Label>
                <asp:TextBox ID="txtYetenek" runat="server" CssClass="form-control"></asp:TextBox>
            </div>

            

            <br />

            <asp:Button ID="btnYetenekGuncelle" runat="server" Text="Güncelle" CssClass="btn btn-primary" OnClick="btnYetenekGuncelle_Click"  />

        </div>
    </form>

</asp:Content>
