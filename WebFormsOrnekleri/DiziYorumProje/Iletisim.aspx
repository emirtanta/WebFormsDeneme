<%@ Page Title="" Language="C#" MasterPageFile="~/Kullanici.Master" AutoEventWireup="true" CodeBehind="Iletisim.aspx.cs" Inherits="DiziYorumProje.Iletisim" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <div class="contact-content">
	 <div class="container">
		     <div class="contact-info">
			 <h2>İletişim</h2>
			 <p>Blog sayfamızda bulunan film ve dizilere eklemek istedikleriniz için veya yorumlarda yaşayacağınız herhangi bir sorun olursa bu panelden bize mesaj gönderebilirsiniz.</p>
		     </div>
			 <div class="contact-details">				 
			 <form runat="server">

                 <asp:TextBox ID="txtAdSoyad" runat="server" placeholder="Ad Soyad" required=""></asp:TextBox>

                 <asp:TextBox ID="txtMail" runat="server" placeholder="Mail" required=""></asp:TextBox>

				 <asp:TextBox ID="txtTelefon" runat="server" placeholder="Telefon" required=""></asp:TextBox>

				 <asp:TextBox ID="txtKonu" runat="server" placeholder="Konu" required=""></asp:TextBox>

				 <asp:TextBox ID="txtMesaj" runat="server" placeholder="Konu" required="" Height="100px" TextMode="MultiLine"></asp:TextBox>

                 

				 <asp:Button ID="btnGonder" runat="server" Text="Gönder" OnClick="btnGonder_Click" />
			 </form>
		  </div>
		  <div class="contact-details">
			  <div class="col-md-6 contact-map">
				 <h4>Neredeyiz</h4>
				 <div class="mapouter"><div class="gmap_canvas"><iframe width="600" height="500" id="gmap_canvas" src="https://maps.google.com/maps?q=izmit%20belsa%20plaza&t=&z=13&ie=UTF8&iwloc=&output=embed" frameborder="0" scrolling="no" marginheight="0" marginwidth="0"></iframe><a href="https://www.whatismyip-address.com/divi-discount/"></a><br><style>.mapouter{position:relative;text-align:right;height:500px;width:600px;}</style><a href="https://www.embedgooglemap.net"></a><style>.gmap_canvas {overflow:hidden;background:none!important;height:500px;width:600px;}</style></div></div>
			  </div>
			  
			  <div class="clearfix"></div>
	     </div>		 


			 </div>
	 </div>


</asp:Content>
