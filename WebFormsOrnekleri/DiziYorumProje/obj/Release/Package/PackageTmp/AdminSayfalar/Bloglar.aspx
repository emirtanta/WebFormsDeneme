<%@ Page Title="" Language="C#" MasterPageFile="~/Admin.Master" AutoEventWireup="true" CodeBehind="Bloglar.aspx.cs" Inherits="DiziYorumProje.AdminSayfalar.Bloglar" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <a href="YeniBloglar.Aspx" class="btn btn-primary">Yeni Blog</a>

    <br />

    <table class="table table-hover table-responsive">
        <tr>
            <th>#</th>
            <th>Başlık</th>
            <th>Tür</th>
            <th>Kategori</th>
            <th>Tarih</th>
            <th>Sil</th>
            <th>Güncelle</th>
        </tr>
        <asp:Repeater ID="Repeater1" runat="server">
            <ItemTemplate>
                <tr>
                    <td><%# Eval("BLOGID") %></td>
                    <td><%# Eval("BLOGBASLIK") %></td>
                    <td><%# Eval("BLOGTUR") %></td>
                    <td><%# Eval("BLOGKATEGORI") %></td>
                    <td><%# Eval("BLOGTARIH") %></td>
                    <td>
                        <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl='<%# "BlogSil.Aspx?BLOGID="+Eval("BLOGID") %>' CssClass="btn btn-danger">Sil</asp:HyperLink>
                        <asp:HyperLink ID="HyperLink2" runat="server" NavigateUrl='<%# "BlogGuncelle.Aspx?BLOGID="+Eval("BLOGID") %>' CssClass="btn btn-warning">Güncelle</asp:HyperLink>
                    </td>
                </tr>
            </ItemTemplate>
        </asp:Repeater>
    </table>

</asp:Content>
