﻿<%@ Page Title="" Language="C#" MasterPageFile="~/Kullanici.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="DiziYorumProje.Default" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">


    <div class="container">
		 <div class="content-grids">
			 <div class="col-md-8 content-main">
				 <div class="content-grid">

                     <asp:Repeater ID="Repeater1" runat="server">
						 <ItemTemplate>
							 <div class="content-grid-info">
						 <img src="<%# Eval("BLOGGORSEL") %>" alt="" style="height:300px; width:600px;"/>
						 <div class="post-info">
						 <h4><a href="BlogDetay.aspx?BLOGID=<%# Eval("BLOGID") %>"><%# Eval("BLOGBASLIK") %></a>  <%# Eval("BLOGTARIH") %></h4>
						 <p><%# Eval("BLOGICERIK") %></p>
						 <a href="#"><span></span>Devamını oku</a>
						 </div>
					 </div>
						 </ItemTemplate>
                     </asp:Repeater>
					 

					 
				 </div>
			  </div>
			  <div class="col-md-4 content-right">
				 <div class="recent">
					 <h3>Son 5 Blog</h3>
					 <ul>
                         <asp:Repeater ID="Repeater3" runat="server">
							 <ItemTemplate>
								 <li><a href="#"><%# Eval("BLOGBASLIK") %></a></li>
							 </ItemTemplate>
                         </asp:Repeater>
					 </ul>
				 </div>


				 <div class="comments">
					 <h3>Son Yorumlar</h3>
					 <asp:Repeater ID="Repeater4" runat="server">
						 <ItemTemplate>
							 <ul>
					 <li><a href="#"><%# Eval("KULLANICIAD") %> :  <%# Eval("YORUMICERIK") %></a> </li>
					 </ul>
						 </ItemTemplate>
                     </asp:Repeater>
					 
				 </div>
				 <div class="clearfix"></div>

				 


				 <div class="categories">
					 <h3>Kategoriler</h3>
					 <ul>
                         <asp:Repeater ID="Repeater2" runat="server">
							 <ItemTemplate>
								 <li>
									 <a href="KategoriDetay.Aspx?KATEGORIID=<%# Eval("KATEGORIID") %>"><%# Eval("KATEGORIAD") %></a>

								 </li>
							 </ItemTemplate>
                         </asp:Repeater>
					 </ul>
				 </div>
				 <div class="clearfix"></div>
			  </div>
			  <div class="clearfix"></div>
		  </div>
	  </div>


</asp:Content>
