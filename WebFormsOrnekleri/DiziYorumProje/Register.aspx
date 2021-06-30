<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Register.aspx.cs" Inherits="DiziYorumProje.Register" %>

<!DOCTYPE html>
<html lang="en">
   <head>
      <title>Admin Giriş Paneli </title>
      <!-- Meta tags -->
      <meta name="viewport" content="width=device-width, initial-scale=1" />
      <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
      <meta name="keywords" content="Gaze Sign up & login Form Responsive Widget, Audio and Video players, Login Form Web Template, Flat Pricing Tables, Flat Drop-Downs, Sign-Up Web Templates, Flat Web Templates, Login Sign-up Responsive Web Template, Smartphone Compatible Web Template, Free Web Designs for Nokia, Samsung, LG, Sony Ericsson, Motorola Web Design"
         />
      <script>
         addEventListener("load", function () { setTimeout(hideURLbar, 0); }, false); function hideURLbar() { window.scrollTo(0, 1); }
      </script>
      <!-- Meta tags -->
      <!--stylesheets-->
       <link href="Content/web/css/bootstrap.css" rel="stylesheet" />
       <link href="Content/web2/css/style.css" rel="stylesheet" />
      <!--//style sheet end here-->
      <link href="//fonts.googleapis.com/css?family=Source+Sans+Pro:400,600,700" rel="stylesheet">
   </head>
   <body>
      <div class="mid-class">
         <div class="art-right-w3ls">
            <h2>Admin Register Paneli</h2>
            <form action="#" method="post" runat="server">

               <div class="main">

                   <%-- kullanıcı adı bölümü --%>
                  <div class="form-left-to-w3l">
                      <asp:TextBox ID="txtKullaniciAdi" runat="server" placeholder="Kullanıcı Adınız" required=""></asp:TextBox>
                  </div>

                   <%-- şifre bölümü --%>
                  <div class="form-left-to-w3l ">
                      <asp:TextBox ID="txtSifre" runat="server" placeholder="Şifreniz" required="" TextMode="Password"></asp:TextBox>
                     
                     <div class="clear"></div>
                  </div>

                   <br />

                   <%-- şehir bölümü --%>
                   <div class="form-left-to-w3l ">
                       <asp:DropDownList ID="dpdSehir" runat="server">
                           <asp:ListItem Text="Şehir Seçin" Value="Select" Selected="True"></asp:ListItem>
                           <asp:ListItem Text="İstanbul" Value="İstanbul"></asp:ListItem>
                           <asp:ListItem Text="Kocaeli" Value="Kocaeli"></asp:ListItem>
                       </asp:DropDownList>
                     
                     <div class="clear"></div>
                  </div>


                   <%-- cinsiyet bölümü --%>
                   <div class="form-left-to-w3l ">
                       <asp:Label ID="Label1" runat="server" Text="Cinsiyet" style="color:#00a1ff"></asp:Label>
                       <br />
                       <asp:RadioButtonList ID="rbCinsiyet" runat="server">  
                            <asp:ListItem>Male</asp:ListItem>  
                            <asp:ListItem>Female</asp:ListItem>  
                        </asp:RadioButtonList> 
                     
                     <div class="clear"></div>
                  </div>

               </div>

               <div class="left-side-forget">
                  <input type="checkbox" class="checked">
                  <span class="remenber-me">Beni hatırla </span>
               </div>

               <div class="right-side-forget">
                  <a href="#" class="for">Şifremi unuttum?</a>
                  <a href="Login.Aspx" class="for">Zaten üyeyim?</a>
               </div>

               <div class="clear"></div>
               <div class="btnn">
                   <br />
                   <asp:Button ID="btnKayitOl" runat="server" Text="Kayıt Ol" CssClass="btn btn-default" BackColor="#00a1ff" ForeColor="White" OnClick="btnKayitOl_Click" />
               </div>
            </form>
            <%--<div class="w3layouts_more-buttn">
               <h3>Don't Have an account..?
                  <a href="#content1">Sign Up Here
                  </a>
               </h3>
            </div>--%>
            <!-- popup-->
            <%--<div id="content1" class="popup-effect">
               <div class="popup">
                  <!--login form-->
                  <div class="letter-w3ls">
                     <form action="#" method="post">
                        <div class="form-left-to-w3l">
                           <input type="text" name="name" placeholder="Username" required="">
                        </div>
                        <div class="form-left-to-w3l">
                           <input type="text" name="name" placeholder="Phone" required="">
                        </div>
                        <div class="form-left-to-w3l">
                           <input type="email" name="email" placeholder="Email" required="">
                        </div>
                        <div class="form-left-to-w3l">
                           <input type="password" name="password" placeholder="Password" required="">
                        </div>
                        <div class="form-left-to-w3l margin-zero">
                           <input type="password" name="password" placeholder="Confirm Password" required="">
                        </div>
                        <div class="btnn">
                           <button type="submit">Sign Up</button>
                           <br>
                        </div>
                     </form>
                     <div class="clear"></div>
                  </div>
                  <!--//login form-->
                  <a class="close" href="#">&times;</a>
               </div>
            </div>--%>
            <!-- //popup -->
         </div>
         <div class="art-left-w3ls">
            <h1 class="header-w3ls">
               Film & Dizi Giriş Paneli
            </h1>
         </div>
      </div>
      <footer class="bottem-wthree-footer">
         <p>
            © 2021 Tüm hakları saklıdır.| Emir Tanta
         </p>
      </footer>
   </body>
</html>
