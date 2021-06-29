<%@ Page Title="" Language="C#" MasterPageFile="~/Kullanici.Master" AutoEventWireup="true" CodeBehind="BlogDetay.aspx.cs" Inherits="DiziYorumProje.BlogDetay" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">


    <div class="single">
        <div class="container">
            <div class="col-md-8 single-main">
                <div class="single-grid">
                    <asp:Repeater ID="Repeater1" runat="server">
                        <ItemTemplate>
                            <img src="<%# Eval("BLOGGORSEL") %>" alt="" style="height:350px;width:700px;margin-bottom:20px;" />
                    <p>
                        <h3><%# Eval("BLOGBASLIK") %></h3>
                        <%# Eval("BLOGICERIK") %>
                    </p>
                        </ItemTemplate>
                    </asp:Repeater>
                    
                </div>

                <!-- yorum bölümü --->
                <asp:Repeater ID="Repeater2" runat="server">
                    <ItemTemplate>
                        <ul class="comment-list">
                    <li>
                        <img src="Content/web/images/avatar.png" />
                        <div class="desc">
                            <p><b><%# Eval("KULLANICIAD") %></b>: <%# Eval("YORUMICERIK") %></p>
                        </div>
                        <div class="clearfix"></div>
                    </li>
                </ul>
                    </ItemTemplate>
                </asp:Repeater>
                

                <div class="content-form">
                    <h3>Yorum Yazın</h3>
                    <form runat="server">

                        <asp:TextBox ID="txtKullaniciAd" runat="server" placeholder="Kullanıcı Adınız" required=""></asp:TextBox>

                        <asp:TextBox ID="txtMail" runat="server" placeholder="Mail Adresiniz"  required=""></asp:TextBox>

                        <asp:TextBox ID="txtAciklama" runat="server" placeholder="Yorumunuz" Height="100px" TextMode="MultiLine" required=""></asp:TextBox>

                        
                        <asp:Button ID="btnYorumYap" runat="server" Text="Yorum Yap" OnClick="btnYorumYap_Click" />
                    </form>
                </div>
            </div>

        </div>
    </div>

</asp:Content>
