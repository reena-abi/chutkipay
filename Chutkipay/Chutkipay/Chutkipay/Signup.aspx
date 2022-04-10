<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Signup.aspx.cs" Inherits="Signup" %>


<!DOCTYPE>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <link rel="stylesheet" href="https://cdnjs.cloudflare.com/ajax/libs/normalize/5.0.0/normalize.min.css"/>
<link rel='stylesheet' href='https://maxcdn.bootstrapcdn.com/bootstrap/3.3.5/css/bootstrap.min.css'/><link rel="stylesheet" href="src/style.css"/>

</head>
<body style="background-color:blue">
      <form id="form1" runat="server">
           <div id="login" class="modal fade" role="dialog">
                <div class="modal-dialog">
                     <div class="modal-content">
                         <div class="modal-body">
                              <button data-dismiss="modal" class="close">&times;</button>
                               <div class="container" id="container">
                                   <div class="form-container sign-up-container">
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
         </form>
<!-- partial -->
 <script src='https://cdnjs.cloudflare.com/ajax/libs/jquery/2.1.3/jquery.min.js'></script>
<script src='https://maxcdn.bootstrapcdn.com/bootstrap/3.3.5/js/bootstrap.min.js'></script><script  src="src/script.js"></script>
   
    
     <script>
      $(window).load(function () {
          $('#login').modal('show');
      });
  </script>
         

</body>
</html>