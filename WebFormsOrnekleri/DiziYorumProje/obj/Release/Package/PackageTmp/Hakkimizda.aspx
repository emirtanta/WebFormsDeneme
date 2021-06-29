<%@ Page Title="" Language="C#" MasterPageFile="~/Kullanici.Master" AutoEventWireup="true" CodeBehind="Hakkimizda.aspx.cs" Inherits="DiziYorumProje.Hakkimizda" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <div class="about-content">
	 <div class="container">
		 <div class="about-section">
			 <div class="about-grid">
				 <h3>Hakkımızda</h3>
                 <asp:Repeater ID="Repeater1" runat="server">
					 <ItemTemplate>
						 <p><%# Eval("ACIKLAMA") %></p>
					 </ItemTemplate>
                 </asp:Repeater>
				 
			 </div>
			 
			 			 
		  </div>		 
	  </div>
</div>

</asp:Content>
