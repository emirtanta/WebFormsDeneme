<%@ Page Title="" Language="C#" MasterPageFile="~/Admin.Master" AutoEventWireup="true" CodeBehind="Roller.aspx.cs" Inherits="DiziYorumProje.AdminSayfalar.Roller" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <a href="YeniRoller.Aspx" class="btn btn-primary">Rol Ekle</a>

    <br />

    <table class="table table-hover table-responsive">
        <tr>
            <th>#</th>
            <th>Rol Adı</th>
            <th>Sil</th>
            <th>Güncelle</th>
        </tr>
        <asp:Repeater ID="Repeater1" runat="server">
            <ItemTemplate>
                <tr>
                    <td><%# Eval("ROLID") %></td>
                    <td><%# Eval("ROLAD") %></td>
                    <td>
                        <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl='<%# "RolSil.Aspx?ROLID="+Eval("ROLID") %>' CssClass="btn btn-danger">Sil</asp:HyperLink>
                        <asp:HyperLink ID="HyperLink2" runat="server" NavigateUrl='<%# "RolGuncelle.Aspx?ROLID="+Eval("ROLID") %>' CssClass="btn btn-warning">Güncelle</asp:HyperLink>
                    </td>
                </tr>
            </ItemTemplate>
        </asp:Repeater>
    </table>


</asp:Content>
