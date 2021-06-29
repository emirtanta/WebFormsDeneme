<%@ Page Title="" Language="C#" MasterPageFile="~/Admin.Master" AutoEventWireup="true" CodeBehind="Yorumlar.aspx.cs" Inherits="DiziYorumProje.AdminSayfalar.Yorumlar" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">


    <a href="YeniYorumlar.Aspx" class="btn btn-primary">Yeni Yorum</a>

    <br />

    <table class="table table-hover table-responsive">
        <tr>
            <th>#</th>
            <th>Kullanıcı Adı</th>
            <th>Blog</th>
            <th>Sil</th>
            <th>Güncelle</th>
        </tr>
        <asp:Repeater ID="Repeater1" runat="server">
            <ItemTemplate>
                <tr>
                    <td><%# Eval("YORUMID") %></td>
                    <td><%# Eval("KULLANICIAD") %></td>
                    <td><%# Eval("BLOGBASLIK") %></td>
                    <td>
                        <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl='<%# "YorumSil.Aspx?YORUMID="+Eval("YORUMID") %>' CssClass="btn btn-danger">Sil</asp:HyperLink>
                        <asp:HyperLink ID="HyperLink2" runat="server" NavigateUrl='<%# "YorumGuncelle.Aspx?YORUMID="+Eval("YORUMID") %>' CssClass="btn btn-warning">Güncelle</asp:HyperLink>
                    </td>
                </tr>
            </ItemTemplate>
        </asp:Repeater>
    </table>


</asp:Content>
