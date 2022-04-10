<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master"  CodeBehind="Default.aspx.cs" Inherits="RajBillPay.Default"%>


<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link href="style.css" rel="stylesheet" />
    <script>
        function onlyNumbers(evt) {
            evt = (evt) ? evt : window.event;
            var charCode = (evt.which) ? evt.which : evt.keyCode;
            if (charCode > 31 && (charCode < 48 || charCode > 57)) {
               // alert(charCode);
                return false;
            }
            return true;
        }
    </script>

</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
  <div class="row bg-white">
                      <div class="col-md-3 form-area pt-5">
                        <h2 class="text-4 mb-3">Mobile Recharge</h2>
                     
                            <div class="mb-3">
                                <div class="custom-control custom-radio custom-control-inline">
                                    <input id="prepaid" name="rechargProbillpayment" class="custom-control-input" checked="" required="" type="radio"/>
                                    <label class="custom-control-label" for="prepaid">Prepaid</label>
                                </div>
                                <div class="custom-control custom-radio custom-control-inline">
                                    <input id="postpaid" name="rechargProbillpayment" class="custom-control-input" required="" type="radio"/>
                                    <label class="custom-control-label" for="postpaid">Postpaid</label>
                                </div>
                             <%--   <a href="#" data-target="#view-plans" data-toggle="modal" class="view-plans">View Plans</a>--%>
                            </div>
    
                            <div class="form-row">
                                <div class="col-md-12 form-group">
                                    <asp:TextBox  ID="txtmobile" class="form-control"  placeholder="Enter Mobile Number" required="" runat="server" MaxLength="10" onKeypress="return onlyNumbers(event);"></asp:TextBox>
                                    </div>
                                <div class="col-md-12 form-group">
                                   <asp:DropDownList ID="ddlop" runat="server" class="custom-select">
                                        <asp:ListItem Value="1">VI</asp:ListItem>
                                        <asp:ListItem Value="2">JIO</asp:ListItem>
                                           <asp:ListItem Value="3">BSNL</asp:ListItem>
                                        <asp:ListItem Value="4">Airtel</asp:ListItem>
                                    </asp:DropDownList>
                
                                </div>
                                <div class="col-md-12">
                                    <div class="form-group input-group">
                                        <div class="input-group-prepend"> <span class="input-group-text">Rs</span> </div>
                                      <asp:TextBox  ID="txtamount" class="form-control"  placeholder="Enter Amount" required="" runat="server" onKeypress="return onlyNumbers(event);"></asp:TextBox>

                                    </div>
                                </div>
                                <div class="col-md-12 form-group">
                                    <asp:Button ID="btnrechage" runat="server" Text="Rechage" CssClass="btn btn-primary" />
                                    </div>
                            </div>
                        </div>
                    <div class="col-md-9">
                        <section class="featured-offer pb-0">
                            <div class="">
                                <div class="row">
                                    <div class=" col-md-12 m-auto text-left">
                                        <div class="sec-heading mb-3">
                                            <span class="tagline">Featured Offer</span>
                                        </div>
                                    </div>
                                </div>
                                <div class="row">
                                    <div class="col-md-12 m-auto">
                                        <div class="featuredOfferBox">
                                            <div class="featuredOffer-caro fc-2 owl-carousel" data-slide="3" data-return="true">
                                                <a href="#" class="fItems">
                                                    <img src="https://demo.themeies.com/probill/images/feature/1.jpg" alt="" class="featuredimg">
                                                </a>
                                                <a href="#" class="fItems">
                                                    <img src="https://demo.themeies.com/probill/images/feature/2.png" alt="" class="featuredimg">
                                                </a>
                                                <a href="#" class="fItems">
                                                    <img src="https://demo.themeies.com/probill/images/feature/3.png" alt="" class="featuredimg">
                                                </a>
                                                <a href="#" class="fItems">
                                                    <img src="https://demo.themeies.com/probill/images/feature/4.png" alt="" class="featuredimg">
                                                </a>
                                                <a href="#" class="fItems">
                                                    <img src="https://demo.themeies.com/probill/images/feature/5.jpg" alt="" class="featuredimg">
                                                </a>
                                                <a href="#" class="fItems">
                                                    <img src="https://demo.themeies.com/probill/images/feature/6.png" alt="" class="featuredimg">
                                                </a>
                                                <a href="#" class="fItems">
                                                    <img src="https://demo.themeies.com/probill/images/feature/7.png" alt="" class="featuredimg">
                                                </a>
                                                <a href="#" class="fItems">
                                                    <img src="https://demo.themeies.com/probill/images/feature/8.png" alt="" class="featuredimg">
                                                </a>
                                                <a href="#" class="fItems">
                                                    <img src="https://demo.themeies.com/probill/images/feature/9.png" alt="" class="featuredimg">
                                                </a>
                                                <a href="#" class="fItems">
                                                    <img src="https://demo.themeies.com/probill/images/feature/10.png" alt="" class="featuredimg">
                                                </a>
                                            </div>
                                        </div>
                                    </div>
                                </div>
                            </div>
                        </section>
                    </div>
                </div>
           
    <!-- Main form end -->

    <!-- Feature section start -->
    <section class="feature ">
        <div class="container">
            <div class="row">
                <div class="col-md-4">
                    <div class="iconBox">
                        <i class="fas fa-globe"></i>
                        <h5><a href="#">Recharge Service</a></h5>
                        <p>We also provide a wide service in mobile bills payments. Such payments include Airtel, Bsnl, Jio, Idea and Vodafone, etc.</p>
                    </div>
                </div>
                <div class="col-md-4">
                    <div class="iconBox">
                        <i class="fas fa-hand-holding-usd"></i>
                        <h5><a href="#">Bill Pay</a></h5>
                        <p>We also provide a wide service in utility bills payments. Such payments include mobile bills, electricity bills, water bill, gas bills, etc.</p>
                    </div>
                </div>
                <div class="col-md-4">
                    <div class="iconBox">
                        <i class="fas fa-times-circle"></i>
                        <h5><a href="#">Rent Pay</a></h5>
                        <p>Can their wherein own upon female without saying made in second them male own you. Him fill good last seasons hath moved and</p>
                    </div>
                </div>
            </div>
        </div>
    </section>
    <!-- Feature section end -->


    <!-- Start We feature Section -->
  <%--  <section class="we-feature bg-offwhite">
        <div class="container">
            <div class="row">
                <div class=" col-md-12 m-auto text-center">
                    <div class="sec-heading mb-4">
                        <span class="tagline">featured</span>
                        <h3 class="sec-title"> We were featured on </h3>
                    </div>
                </div>
            </div>
            <div class="cl row">
                <ul class="col-md-12 nav nav-tabs cmn-carousel owl-carousel cspage">
                    <li class="item">
                        <button data-tag="tab1" class="caroBtn single-evnt caro-item active">
                            <img src="https://demo.themeies.com/probill/images/protal/client01.png" alt="">
                        </button>
                    </li>
                    <li class="item">
                        <button data-tag="tab2" class="caroBtn single-evnt caro-item">
                            <img src="https://demo.themeies.com/probill/images/protal/client02.png" alt="">
                        </button>
                    </li>
                    <li class="item">
                        <button data-tag="tab3" class="caroBtn single-evnt caro-item">
                            <img src="https://demo.themeies.com/probill/images/protal/client03.png" alt="">
                        </button>
                    </li>
                    <li class="item">
                        <button data-tag="tab4" class="caroBtn single-evnt caro-item">
                            <img src="https://demo.themeies.com/probill/images/protal/client04.png" alt="">
                        </button>
                    </li>
                    <li class="item">
                        <button data-tag="tab5" class="caroBtn single-evnt caro-item">
                            <img src="https://demo.themeies.com/probill/images/protal/client05.png" alt="">
                        </button>
                    </li>
                    <li class="item">
                        <button data-tag="tab6" class="caroBtn single-evnt caro-item">
                            <img src="https://demo.themeies.com/probill/images/protal/client06.png" alt="">
                        </button>
                    </li>
                </ul>

                <div class="cmn-caro-tab">
                    <div id="tab1C" class="tcontent active">
                        <div class="single-event-con">
                            <p>Standard chunk of Lorem Ipsum used since the 1500s is reproduced below for those interested. Sections 1.10.32 and 1.10.33 from "de Finibus Bonorum et Malorum" by Cicero are also reproduced in their exact original form, accompanied by English versions from the 1914 translation by H. Rackham.</p>
                            <a href="#" class="btn btn-default">Learn More</a>
                        </div>
                    </div>
                    <div id="tab2C" class="tcontent">
                        <div class="single-event-con">
                            <p>Standard chunk of Lorem Ipsum used since the 1500s is reproduced below for those interested. Sections 1.10.32 and 1.10.33 from "de Finibus Bonorum et Malorum" by Cicero are also reproduced in their exact original form, accompanied by English versions from the 1914 translation by H. Rackham.</p>
                            <a href="#" class="btn btn-default">Learn More</a>
                        </div>
                    </div>
                    <div id="tab3C" class="tcontent">
                        <div class="single-event-con">
                            <p>Chunk of Lorem Ipsum used since the 1500s is reproduced below for those interested. Sections 1.10.32 and 1.10.33 from "de Finibus Bonorum et Malorum" by Cicero are also reproduced in their exact original form, accompanied by English versions from the 1914 translation by H. Rackham.</p>
                            <a href="#" class="btn btn-default">Learn More</a>
                        </div>
                    </div>
                    <div id="tab4C" class="tcontent">
                        <div class="single-event-con">
                            <p>Lorem Ipsum used since the 1500s is reproduced below for those interested. Sections 1.10.32 and 1.10.33 from "de Finibus Bonorum et Malorum" by Cicero are also reproduced in their exact original form, accompanied by English versions from the 1914 translation by H. Rackham.</p>
                            <a href="#" class="btn btn-default">Learn More</a>
                        </div>
                    </div>
                    <div id="tab5C" class="tcontent">
                        <div class="single-event-con">
                            <p>Chunk of Lorem Ipsum used since the 1500s is reproduced below for those interested. Sections 1.10.32 and 1.10.33 from "de Finibus Bonorum et Malorum" by Cicero are also reproduced in their exact original form, accompanied by English versions from the 1914 translation by H. Rackham.</p>
                            <a href="#" class="btn btn-default">Learn More</a>
                        </div>
                    </div>

                    <div id="tab6C" class="tcontent">
                        <div class="single-event-con">
                            <p>Standard chunk of Lorem Ipsum used since the 1500s is reproduced below for those interested. Sections 1.10.32 and 1.10.33 from "de Finibus Bonorum et Malorum" by Cicero are also reproduced in their exact original form, accompanied by English versions from the 1914 translation by H. Rackham.</p>
                            <a href="#" class="btn btn-default">Learn More</a>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </section>--%>
    <!-- End  We feature Section -->

    <!-- Work section start -->
 <%--   <section class="work bg-bluewhite">
        <div class="container">
            <div class="row">
                <div class="col-lg-6 col-md-9 m-auto text-center">
                    <div class="sec-heading">
                        <span class="tagline">What We Do </span>
                        <h3 class="sec-title">Simple, fast and Hassle Free payments </h3>
                    </div>
                </div>
            </div>
            <div class="row">
                <div class="col-lg-6">
                    <div class="process">
                        <ul>
                            <li class="card">
                                <span class="icon-bg">
                                    <i class="ti-signal"></i>
                                </span>
                                <h5>Phone Recharge & DTH</h5>
                                <p>Their over fly creature first fish fruitful fourth our very thing said man our land</p>
                            </li>
                            <li class="card">
                                <span class="icon-bg">
                                    <i class="ti-calendar"></i>
                                </span>
                                <h5>Bill Payments </h5>
                                <p>Their over fly creature first fish fruitful fourth our very thing said man our land</p>
                            </li>
                            <li class="card">
                                <span class="icon-bg">
                                    <i class="ti-user"></i>
                                </span>
                                <h5>Bus Tickets </h5>
                                <p>Their over fly creature first fish fruitful fourth our very thing said man our land</p>
                            </li>
                        </ul>
                    </div>

                </div>
                <div class="col-lg-6">
                    <div class="process">
                        <ul>
                            <li class="card">
                                <span class="icon-bg">
                                    <i class="ti-palette"></i>
                                </span>
                                <h5>Shopping in Local Stores </h5>
                                <p>Their over fly creature first fish fruitful fourth our very thing said man our land</p>
                            </li>
                            <li class="card">
                                <span class="icon-bg">
                                    <i class="ti-home"></i>
                                </span>
                                <h5>Boost your finances</h5>
                                <p>Their over fly creature first fish fruitful fourth our very thing said man our land</p>
                            </li>
                            <li class="card">
                                <span class="icon-bg">
                                    <i class="ti-layers"></i>
                                </span>
                                <h5>Transfer money to Bank</h5>
                                <p>Their over fly creature first fish fruitful fourth our very thing said man our land</p>
                            </li>
                        </ul>
                    </div>

                </div>
            </div>
        </div>
    </section>--%>
    <!-- Work section end -->

    <!-- Start Partner Section -->
    <%--<section class="partners">
        <div class="container">
            <div class="row">
                <div class=" col-md-12 m-auto text-center">
                    <div class="sec-heading mb-4">
                        <span class="tagline">Partners</span>
                        <h3 class="sec-title"> Our Trusted Partners </h3>
                    </div>
                </div>
            </div>
            <div class="row">
                <div class="col-md-12 m-auto">
                    <div class="featuredOfferBox">
                        <div class="featuredOffer-caro fc-3 owl-carousel" data-slide="4" data-return="false">
                            <a href="#" class="fItems">
                                <img src="https://demo.themeies.com/probill/images/partners/1.png" alt="" class="featuredimg">
                            </a>
                            <a href="#" class="fItems">
                                <img src="https://demo.themeies.com/probill/images/partners/2.png" alt="" class="featuredimg">
                            </a>
                            <a href="#" class="fItems">
                                <img src="https://demo.themeies.com/probill/images/partners/3.png" alt="" class="featuredimg">
                            </a>
                            <a href="#" class="fItems">
                                <img src="https://demo.themeies.com/probill/images/partners/4.png" alt="" class="featuredimg">
                            </a>

                        </div>
                    </div>
                </div>
            </div>
        </div>
    </section>--%>
    <!-- End Partner Section -->

    <!-- Counter Section -->
   <%-- <section class="countersection bg-blue text-white">
        <div class="container">
            <div class="row" id="counter">
                <div class="col-md-3">
                    <div class="iconBox">
                        <i class="fas fa-globe"></i>
                        <h5><span class="counter-value" data-count="1203">0</span>M</h5>
                        <p>Transactions</p>
                    </div>
                </div>
                <div class="col-md-3">
                    <div class="iconBox">
                        <i class="fas fa-hand-holding-usd"></i>
                        <h5><span class="counter-value" data-count="7820">0</span>M</h5>
                        <p>Users</p>
                    </div>
                </div>
                <div class="col-md-3">
                    <div class="iconBox">
                        <i class="fas fa-arrow-alt-circle-down"></i>
                        <h5><span class="counter-value" data-count="90066">0</span></h5>
                        <p>App Downloads</p>
                    </div>
                </div>
                <div class="col-md-3">
                    <div class="iconBox">
                        <i class="fas fa-comments"></i>
                        <h5><span class="counter-value" data-count="4000">0</span></h5>
                        <p>App Review</p>
                    </div>
                </div>
            </div>

        </div>
    </section>--%>
    <!-- End Counter Section -->

    <!-- App Section start -->
  <%--  <section class="app-section">
        <div class="container-fluid">

            <div class="row align-items-center">
                <div class="col leftside  text-md-right text-sm-center">
                    <div class="app-inner-block">
                        <div class="contentBox">
                            <h3>Go Probill - Download the IOS Super App </h3>
                            <p>Download the app now &amp; make convenience a part of your life.</p>
                            <a title="Google Play" target="_blank" href="#" class="btn-google-store">
                                <img src="https://demo.themeies.com/probill/images/app/app-store.png" alt="" class="googleplay">
                            </a>
                        </div>

                    </div>
                </div>
                <div class="col middleside">
                    <img src="https://demo.themeies.com/probill/images/app/phone.png" alt="" id="app">
                </div>
                <div class="col rightside">
                    <div class="app-inner-block text-md-left text-sm-center">
                        <div class="contentBox">
                            <h3>Go Probill - Download the Android Super App </h3>
                            <p>Download the app now &amp; start earning <br>smartly.</p>
                            <a title="Google Play" target="_blank" href="#" class="btn-google-store">
                                <img src="https://demo.themeies.com/probill/images/app/google-play-store.png" alt="" class="googleplay">
                            </a>
                        </div>

                    </div>
                </div>
            </div>
        </div>
    </section>--%>
    <!-- App Section End -->


    <!-- Start Testimonial Section -->
  <%--  <section class="testimonial">
        <div class="container">
            <div class="row">
                <div class="col-lg-7 col-md-9 m-auto text-center">
                    <div class="sec-heading">
                        <span class="tagline text-white">Testimonials</span>
                        <h3 class="sec-title text-white">What About <br> Our Users Say About Service</h3>
                    </div>
                </div>
            </div>
            <div class="row">
                <div class="col-lg-10 col-md-12 m-auto">
                    <div class="testimonialBox">
                        <div class="test-caro owl-carousel owl-loaded owl-drag" data-slider-id="1">
                            <div class="owl-stage-outer">
                                <div class="owl-stage" style="transform: translate3d(0px, 0px, 0px); transition: all 0s ease 0s; width: 2580px;">
                                    <div class="owl-item active" style="width: 860px;">
                                        <div class="single-testimonial">
                                            <p>Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore eco dolore magna aliqua. Quis ipsum suspendisse ultrices gravida. Risus commodo viverra maecenas accumsan lacus vel facilisis.</p>
                                            <div class="testimonial-user">
                                                <img src="https://demo.themeies.com/probill/images/client/client-1.jpg" class="avatar-medium circle" alt="">
                                                <strong>Sansa Stark</strong>
                                            </div>
                                            <i class="ti-quote-left"></i>
                                        </div>
                                    </div>
                                    <div class="owl-item" style="width: 860px;">
                                        <div class="single-testimonial">
                                            <p>Ypsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore eco dolore magna aliqua. Quis ipsum suspendisse ultrices gravida. Risus commodo viverra maecenas accumsan lacus vel facilisis.</p>
                                            <div class="testimonial-user">
                                                <img src="https://demo.themeies.com/probill/images/client/client-2.jpg" class="avatar-medium circle" alt="">
                                                <strong>Linda heiday</strong>
                                            </div>
                                            <i class="ti-quote-left"></i>
                                        </div>
                                    </div>
                                    <div class="owl-item" style="width: 860px;">
                                        <div class="single-testimonial">
                                            <p>Qonsectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore eco dolore magna aliqua. Quis ipsum suspendisse ultrices gravida. Risus commodo viverra maecenas accumsan lacus vel facilisis.</p>
                                            <div class="testimonial-user">
                                                <img src="https://demo.themeies.com/probill/images/client/client-3.jpg" class="avatar-medium circle" alt="">
                                                <strong>Anna Gunn</strong>
                                            </div>
                                            <i class="ti-quote-left"></i>
                                        </div>
                                    </div>
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </section>--%>
    <!-- End Testimonial Section -->

   <%-- <section class="section bg-light shadow-md pt-4 pb-3">
        <div class="container">
            <div class="row">
                <div class="col-md-3">
                    <div class="iconBox">
                        <i class="fas fa-lock"></i>
                        <h5>Secure Payments</h5>
                        <p>Moving your card details to a much more secured place.</p>
                    </div>
                </div>
                <div class="col-md-3">
                    <div class="iconBox">
                        <i class="fas fa-hand-holding-usd"></i>
                        <h5>Trust pay</h5>
                        <p>100% Payment Protection. Easy Return Policy.</p>
                    </div>
                </div>
                <div class="col-md-3">
                    <div class="iconBox">
                            <i class="fas fa-retweet"></i>
                        <h5>Refer &amp; Earn</h5>
                        <p>Invite a friend to sign up and earn up to $125.</p>
                    </div>
                </div>
                <div class="col-md-3">
                    <div class="iconBox">
                        <i class="fab fa-superpowers"></i>
                        <h5>24/7 Support</h5>
                        <p>We're here to help. Have a query and need help ? <a href="https://demo.themeies.com/probill/contact.html">Click here</a></p>
                    </div>
                </div>
            </div>
        </div>
    </section>--%>
    <div id="login" class="modal fade" role="dialog">
  <div class="modal-dialog">
    
    <div class="modal-content">
      <div class="modal-body">
        <button data-dismiss="modal" class="close">&times;</button>
        <div class="container" id="container">
						<div class="form-container sign-up-container">
							<form action="#">
								<h1>Create Account</h1>
								<div class="social-container">
									<a href="#" class="social"><i class="fab fa-facebook-f"></i></a>
									<a href="#" class="social"><i class="fab fa-google-plus-g"></i></a>
									<a href="#" class="social"><i class="fab fa-linkedin-in"></i></a>
								</div> 
								<span>or use your email for registration</span>
								<input type="text" placeholder="Name" />
								<input type="email" placeholder="Email" />
								<input type="password" placeholder="Password" />
								<button>Sign Up</button>
							</form>
						</div>
						<div class="form-container sign-in-container">
							
								<h1>Sign in</h1>
								<div class="social-container">
									<a href="#" class="social"><i class="fab fa-facebook-f"></i></a>
									<a href="#" class="social"><i class="fab fa-google-plus-g"></i></a>
									<a href="#" class="social"><i class="fab fa-linkedin-in"></i></a>
								</div>
								<span>or use your account</span>
								<input type="email" placeholder="Email" />
								<input type="password" placeholder="Password" />
								<a href="#">Forgot your password?</a>
								<button>Sign In</button>
						
						</div>
						<div class="overlay-container">
							<div class="overlay">
								<div class="overlay-panel overlay-left">
									<h1>Welcome Back!</h1>
									<p>To keep connected with us please login with your personal info</p>
									<button class="ghost" id="signIn">Sign In</button>
								</div>
								<div class="overlay-panel overlay-right">
									<h1>Hello, Friend!</h1>
									<p>Enter your personal details and start journey with us</p>
									<button class="ghost" id="signUp">Sign Up</button>
								</div>
							</div>
						</div>
					  </div>
      </div>
    </div>
  </div>  
</div> 
</asp:Content>
