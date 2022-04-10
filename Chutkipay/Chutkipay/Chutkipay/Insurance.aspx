
<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeFile="Insurance.aspx.cs" Inherits="Insurance" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
<link rel="stylesheet" href="https://cdnjs.cloudflare.com/ajax/libs/normalize/5.0.0/normalize.min.css"/>
<link rel='stylesheet' href="https://cdnjs.cloudflare.com/ajax/libs/twitter-bootstrap/4.0.0-beta.2/css/bootstrap.css"/>
<link rel='stylesheet' href="https://cdnjs.cloudflare.com/ajax/libs/intl-tel-input/12.1.2/css/intlTelInput.css"/>
<link rel='stylesheet' href="https://code.ionicframework.com/ionicons/2.0.1/css/ionicons.min.css"/>
<link rel='stylesheet' href="https://cdnjs.cloudflare.com/ajax/libs/jquery-nice-select/1.1.0/css/nice-select.min.css"/><link rel="stylesheet" href="style12.css"/>

</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
<section id="portfolio">
    <div class="container">
        <div class="row">
            <div class="col-lg-12 text-center" >
                <h2>Insurance</h2>
                <hr class="star-primary" />
            </div>
        </div>
        
        <asp:Panel ID="pnlmyshow" runat="server" Visible="true">
            <div class="row">
                <div class="col-xs-6 col-md-3">
                    <div class="col-xs-6 col-md-3">
                        <asp:ImageButton ID="LIC" runat="server" ImageUrl="img/LIC.png" width="265" height="156" OnClick="LIC_Click" />
                    </div>
                </div>
                <div class="col-xs-6 col-md-3">
                    <div class="col-xs-6 col-md-3">
                        <asp:ImageButton ID="CAR" runat="server" ImageUrl="img/car.png" alt="CAR" width="265" height="156" />
                    </div>
                </div>
                <div class="col-xs-6 col-md-3">
                    <div class="col-xs-6 col-md-3">
                        <asp:ImageButton ID="Home" runat="server" ImageUrl="img/home.png" alt="Home Insurance" width="265" height="156" />
                    </div>
                </div>

                <div class="col-xs-6 col-md-3">
                    <div class="col-xs-6 col-md-3">
                        <asp:ImageButton ID="Health" runat="server" ImageUrl="img/Health.png" alt="Health Insurance" width="265" height="156" />
                    </div>
                </div>
            </div>
        </asp:Panel>
        <asp:Panel ID="pnlLICD" runat="server" Visible="false">
            <div class="row">
                <div class="col-md-12">
                    <div class="bg">
                        <div class="processs1">
                            <ul class="bg11">
                                <li class="card">
                                    <span class="icon-bg1">
                                        <img src="img/rs.png" style="width: 66px;" />
                                    </span>
                                    <h5>Direct Pay</h5>
                                </li>
                            </ul>
                        </div>
                    </div>
                </div>
            </div>
            <div class="row">
                <div class="col-lg-6">
                    <div class="process">
                        <ul>
                            <li class="card">
                                <span class="icon-bg">
                                    <i class="fas fa-user-alt" style="color: white;"></i>
                                </span>
                                <h5>Direct Pay</h5>
                                <p>No Registraion Required</p>
                            </li>
                        </ul>
                    </div>
                    <asp:DropDownList ID="ddlliclist" runat="server" class="form-control custom-select browser-default" OnTextChanged="ddlliclist_TextChanged" AutoPostBack="true">
                        <asp:ListItem Value="0">Select Item</asp:ListItem>
                        <asp:ListItem Value="1">Renewal Premium/Revival</asp:ListItem>
                        <asp:ListItem Value="2">Advance Premium Payment</asp:ListItem>
                        <asp:ListItem Value="3">Loan Repayment</asp:ListItem>
                        <asp:ListItem Value="4">Loan Interest Payment</asp:ListItem>
                    </asp:DropDownList>
                </div>
                <div class="col-lg-6">
                    <div class="process">
                        <ul>
                            <li class="card">
                                <span class="icon-bg">
                                    <i class="fas fa-calendar-alt" style="color: white;"></i>
                                </span>
                                <h5><u>View/Daownload Receipt</u></h5>
                                <p>(Completed Transactions Only)</p>
                            </li>
                        </ul>
                    </div>
                </div>
            </div>
              <div class="row text-center" style="margin-top:5px">
                 <div class="col-md-12">
                     <asp:Button ID="btnbacktohome" runat="server" CssClass="btn btn-primary" Text="Back TO Home" OnClick="btnbacktohome_Click"
                    />
                 </div>
             </div>
              <br />
               <br />
        </asp:Panel>
        <asp:Panel ID="Pnlddl1" runat="server" Visible="false">
            <div class="row"; border: 1px solid; style="border:ridge" >
                 <div class="col-xs-12 col-md-4">
                    <img src="img/Col4.png" alt="chutkipay" style="height: 172px;width: 178px;margin-top:13px;" />
                </div>
                <div class="col-xs-12 col-md-8 text-center">
                    <img src="img/icon3.png" alt="chutkipay" style="height: 65px; width: 65px;"/>
                    <h5 style="margin-top:-42px; margin-right:30px;" >Simple steps to complete the</h5>
                    <h4><b>Advance Premium Payment</b></h4>
                    <table border="0" style="align-content:center">
                    <tr>
                    <td><img src="https://bill.chutkipay.com/img/col1.png" alt="chutkipay" style="height:105px; width: 105px;"/></td>
                    <td><img src="https://bill.chutkipay.com/img/col2.png" alt="chutkipay" style="height: 105px; width: 105px;" /></td>
                    <td><img src="https://bill.chutkipay.com/img/col3.png" alt="chutkipay" style="height: 105px; width: 105px;" /></td>
                    </tr>
                    </table>
                 </div>
                 </div>
        

            <div class="row" style="border-style:ridge" >
                <div class="col-12">
                    <div class="entry-content">
                        <p style="color:blue">Customer Consent</p>
                                <p style="color:black">Advance Premium can be accepted only if:</p>
                                <ul style="color:black">
                                    <li><i class="fas fa-check" style="color:blue"></i>Due date of the premium payment is in the same financial year.</li>
                                    <li><i class="fas fa-check" style="color:blue"></i>Due date is in the next financial year but is not more than three months from advance premium payment date.</li>
                                    <li><i class="fas fa-check" style="color:blue"></i>Policy is not registered for standing instructions through NACH/ECS/Direct Debit.</li>
                                    <li><i class="fas fa-check" style="color:blue"></i>Policy is not registered for standing instructions through NACH/ECS/Direct Debit.</li>
                                    <li><i class="fas fa-check" style="color:blue"></i>Plan number of the Policy is not included in the exempted plans which are : 128-Jeevan Sneha,160 &amp; 192 -Jeevan Bharati (I &amp; II), 805 &amp; 806 –Bima Account(I &amp; II) and 51- Capital Redemption.</li>
                                </ul>    
                    </div>
                </div>
            </div>
            <div class="row text-center" style="margin-top:5px">
                 <div class="col-md-12">
                      <asp:Button ID="btnback" runat="server" CssClass="btn btn-primary" Text="Back" />
                      <asp:Button ID="btnproced" runat="server" CssClass="btn btn-primary" Text="Next" OnClick="btnproced_Click"/>
                      </div>
                 </div>
                   
     </asp:Panel>

         <asp:Panel ID ="PnlForm" runat="server" Visible="false">
         <div class="row bg-white">
         <div class="col-md-12 form-area pt-5">
         <div class="mb-3"> 
         </div>
             <div class="form-row">
                  <div class="col-md-6 col-lg-3 form-group">
                      <label> Policy No.</label>
                      <asp:TextBox ID="canumber" class="form-control"  placeholder="Enter Policy No."  runat="server" ></asp:TextBox>
                 </div>
                  <div class="col-md-6 col-lg-3">
                       <label> Email ID.</label>
                       <asp:TextBox ID="ad1" class="form-control"  placeholder="Enter Email"  runat="server" ></asp:TextBox>
                       </div>
                    <div class="col-md-6 col-lg-3">
                       <label> PanCard No.</label>
                       <asp:TextBox ID="txtpan" class="form-control"  placeholder="Enter PanCard No"  runat="server" ></asp:TextBox>
                       </div>
                 <div class="col-md-6 col-lg-3 form-group">
                      <label>&nbsp;</label>
                      <asp:Button ID="save" runat="server" class="btn btn-default btn-block rounded-0" Text="Get Details" OnClick="save_Click"/>
                 </div>
                 <div class="col-md-6 col-lg-3 form-group">
                     <asp:TextBox ID="txtres" class="form-control"   placeholder="Enter Card Number" runat="server"  Visible="false"></asp:TextBox>
                 </div>
             </div>
         </div>
         </div>
     </asp:Panel>

          <asp:Panel ID ="pnlpayoption" runat="server" Visible="false">
         <div class="row bg-white">
         <div class="col-md-12 form-area pt-5">
         <div class="mb-3"> 
         </div>
            
         </div>
         </div>
     </asp:Panel>
         <asp:Panel ID ="getdatails" runat="server" Visible="false">
         <div class="row bg-white">
             <div class="col-md-12 form-area pt-5">
                 <div class="mb-3"> 
                
             </div>
             <div class="form-row">
                  <div class="col-md-6 col-lg-3 form-group">
                      <label>Name</label>
                      <asp:Label ID="lblname" runat="server" class="form-control"></asp:Label>
                     
                  </div>
                 <div class="col-md-6 col-lg-3 form-group">
                      <label>Due Amount</label>
                      <asp:Label ID="lblant" runat="server" class="form-control"></asp:Label>
                 </div>
                 <div class="col-md-6 col-lg-3 form-group">
                      <label>Duedate</label>
                      <asp:Label ID="lbldd" runat="server" class="form-control"></asp:Label>
                 </div>
                 <div class="col-md-6 col-lg-3 form-group">
                      <label>Status</label>
                      <asp:Label ID="lblstatus" runat="server" class="form-control"></asp:Label>
                 </div>

                </div>
                <div class="form-row">
                      <div class="col-md-6 col-lg-3 form-group">
                         <label>Enter Amount</label>
                       <asp:TextBox ID="txtamt" class="form-control"   placeholder="Enter Amount" runat="server" ></asp:TextBox>
                  </div>
                 <div class="col-md-6 col-lg-3 form-group">
                     <label>Enter Email</label>
                      <asp:TextBox ID="txtemail" class="form-control"  placeholder="Enter canumber"  runat="server" ></asp:TextBox>
                 </div>
                  <div class="col-md-6 col-lg-3 form-group">
                     <label>Enter Contact</label>
                      <asp:TextBox ID="txtphone" class="form-control"  placeholder="Enter canumber"  runat="server"  MaxLength="10"></asp:TextBox>
                 </div>
                    </div>





                  <div class="form-row">
                  <div class="col-md-6 col-lg-3 form-group">
                      <label> CashFree.</label>
                      <asp:CheckBox ID="cashfree" runat="server" class="form-control" Text="CashFree" />
                      
                 </div>
                  <div class="col-md-6 col-lg-3">
                       <label> EaseBuzz</label>
                     <asp:CheckBox ID="EaseBuzz" runat="server" class="form-control" Text="EaseBuzz" />
                       </div>
                    <div class="col-md-6 col-lg-3">
                       <label> ChutkiPay.</label>
                       <asp:CheckBox ID="paysprint" runat="server" class="form-control" Text="ChutkiPay" />
                       </div>
                 <div class="col-md-6 col-lg-3">
                       <label> WorldLine.</label>
                       <asp:CheckBox ID="WorldLine" runat="server" class="form-control" Text="WorldLine" />
                       </div>
                 
             </div>


                      <div class="form-row">
                    <div class="col-md-6 col-lg-3 form-group">
                      <asp:Button ID="btnbillpay" runat="server" class="btn btn-default btn-block rounded-0" Text="Pay" OnClick="btnbillpay_Click"/>
                 </div>
                   <div class="col-md-6 col-lg-3 form-group">
                     <label>&nbsp;</label>
                      <asp:TextBox ID="lblsms" class="form-control"  placeholder="Enter canumber"  runat="server" Visible="false" ></asp:TextBox>
                 </div>
                    </div>
                
                  </div>
            </div>
     </asp:Panel>
        <asp:Panel ID="pnlPAybill" runat="server">   
         <div class="row bg-white">
             <div class="col-md-12 form-area pt-5">
                 <div class="mb-3"> 
                 
             </div>
             <%--<div class="form-row">
                  
                 <div class="col-md-6 col-lg-2 form-group">
                      <label>Amount</label>
                      <asp:TextBox ID="txtamount" class="form-control"  placeholder="Enter customer No."  runat="server" ></asp:TextBox>
                 </div>
                  <div class="col-md-6 col-lg-3">
                       <label>Name</label>
                       <asp:TextBox ID="userName" class="form-control"  placeholder="Enter Mode"  runat="server" ></asp:TextBox>
                       </div>
                 <div class="col-md-6 col-lg-3 form-group">
                      <label>Duedate</label>
                      <asp:TextBox ID="txtduedate" class="form-control"  placeholder="Enter amount"  runat="server" ></asp:TextBox>
                 </div>
                 <asp:Label ID="billAmount" runat="server"></asp:Label>

                   <asp:Label ID="billnetamount" runat="server"></asp:Label>
                   <asp:Label ID="dueDate" runat="server"></asp:Label>
                   <asp:Label ID="maxBillAmount" runat="server"></asp:Label>
                   <asp:Label ID="cellNumber" runat="server"></asp:Label>


                   
                 <div class="col-md-6 col-lg-3 form-group">
                      <label>&nbsp;</label>
                      <asp:Button ID="btnlicpay" runat="server" class="btn btn-default btn-block rounded-0" Text="Paysprint Pay" OnClick="btnlicpay_Click" />
                 </div>
                 <div class="col-md-6 col-lg-3 form-group">
                        
                       <asp:TextBox ID="TextBox3" class="form-control"   placeholder="Enter Card Number" runat="server"  Visible="false"></asp:TextBox>
                  </div>
                  </div>--%>
                  </div>
            </div>
    


        </asp:Panel>

        </div>
</section>
<script src='https://cdnjs.cloudflare.com/ajax/libs/jquery/3.2.1/jquery.min.js'></script>
<script src='https://cdnjs.cloudflare.com/ajax/libs/twitter-bootstrap/4.0.0-beta/js/bootstrap.min.js'></script>
<script src='https://cdnjs.cloudflare.com/ajax/libs/jquery-easing/1.3/jquery.easing.min.js'></script>
<script src='https://cdnjs.cloudflare.com/ajax/libs/intl-tel-input/12.1.2/js/intlTelInput.js'></script>
<script src='https://cdnjs.cloudflare.com/ajax/libs/popper.js/1.12.9/umd/popper.min.js'></script>
<script src='https://cdnjs.cloudflare.com/ajax/libs/jquery-nice-select/1.1.0/js/jquery.nice-select.min.js'></script><script  src="script.js"></script>


</asp:Content>

