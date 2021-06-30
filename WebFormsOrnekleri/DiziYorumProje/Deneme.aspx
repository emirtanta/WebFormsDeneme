<%@ Page Title="" Language="C#" MasterPageFile="~/Kullanici.Master" AutoEventWireup="true" CodeBehind="Deneme.aspx.cs" Inherits="DiziYorumProje.Deneme" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <form id="form1" runat="server">
        <table class="table table-responsive table-hover">
            <tr>
                <td>
                    <asp:Label ID="Label1" runat="server" Text="Ülke Seçin"></asp:Label>
                </td>
                <td>
                    <asp:DropDownList ID="DropDownList1" runat="server" AutoPostBack="true" DataTextField="COUNTRYNAME" DataValueField="COUNTRYID" AppendDataBoundItems="true" OnSelectedIndexChanged="DropDownList1_SelectedIndexChanged">
                        <asp:ListItem Value="0">-Ülke Seçin-</asp:ListItem>
                    </asp:DropDownList>
                </td>
                <td></td>
                
            </tr>
            <tr>
                <td>
                    <asp:Label ID="Label2" runat="server" Text="Bölge Seçin"></asp:Label>
                </td>
                <td>
                    <asp:DropDownList ID="DropDownList2" runat="server" AppendDataBoundItems="true" DataTextField="STATENAME" DataValueField="STATEID" OnSelectedIndexChanged="DropDownList2_SelectedIndexChanged" AutoPostBack="true">
                        <asp:ListItem Value="0">-Bölge Seçin-</asp:ListItem>
                    </asp:DropDownList>
                </td>
                <td>

                </td>
            </tr>
            <tr>
                <td>
                    <asp:Label ID="Label3" runat="server" Text="İl Seçin"></asp:Label>
                </td>
                <td>
                    <asp:DropDownList ID="DropDownList3" runat="server" AppendDataBoundItems="true" DataTextField="CITYNAME" DataValueField="CITYID">
                        <asp:ListItem Value="0">-Şehir Seçin</asp:ListItem>
                    </asp:DropDownList>
                </td>
                <td>

                </td>
            </tr>
        </table>
    </form>

</asp:Content>
