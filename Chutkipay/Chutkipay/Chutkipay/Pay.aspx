<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeFile="Pay.aspx.cs" Inherits="Pay" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
     <div class="main-form">
                        <h3>Mandatory Parameters</h3>
                        <hr>
                        <div class="mandatory-data">
                            <div class="form-field">
                                <label for="txnid">Transaction ID<sup>*</sup></label>
                               <%-- <input id="txnid" class="txnid" name="txnid" value="" placeholder="T31Q6JT8HB">--%>
                                <asp:TextBox ID="txnid" class="txnid" name="txnid" value="" placeholder="T31Q6JT8HB" runat="server"></asp:TextBox>
                            </div>

                            <div class="form-field">
                                <label for="amount">Amount<sup>(should be float)*</sup></label>
                                 <asp:TextBox id="amount" class="amount" name="amount" value="" placeholder="125.25" runat="server"></asp:TextBox>
                            </div>  

                            <div class="form-field">
                                <label for="firstname">First Name<sup>*</sup></label>
                                <asp:TextBox id="firstname" class="firstname" name="firstname" value="" placeholder="Easebuzz Pvt. Ltd." runat="server"></asp:TextBox>
                            </div>
                    
                            <div class="form-field">
                                <label for="email">Email ID<sup>*</sup></label>
                                 <asp:TextBox  id="email" class="email" name="email" value=""
                                placeholder="initiate.payment@easebuzz.in" runat="server"></asp:TextBox>
                            </div>
                    
                            <div class="form-field">
                                <label for="phone">Phone<sup>*</sup></label>
                             <asp:TextBox id="phone" class="phone" name="phone" value=""
                                placeholder="0123456789" runat="server"></asp:TextBox>
                            </div>
                            
                            <div class="form-field">
                                <label for="productinfo">Product Information<sup>*</sup></label>
                               <asp:TextBox id="productinfo" class="productinfo" name="productinfo" value="" placeholder="Apple Laptop" runat="server"></asp:TextBox>
                            </div>
                    
                            <div class="form-field">
                                <label for="surl">Success URL<sup>*</sup></label>
                               <asp:TextBox id="surl" class="surl" name="surl" value="http://localhost:8080/success.aspx" placeholder="http://localhost:8080/success.aspx" runat="server"></asp:TextBox>
                            </div>
                            
                            <div class="form-field">
                                <label for="furl">Failure URL<sup>*</sup></label>
                                <asp:TextBox id="furl" class="furl" name="furl" value="http://localhost:8080/success.aspx"
                                placeholder="http://localhost:8080/success.aspx" runat="server"></asp:TextBox>
                            </div>

                        </div>

                        <h3>Optional Parameters</h3>
                        <hr>
                        <div class="optional-data">

                            <div class="form-field">
                                <label for="udf1">UDF1</label>
                                <asp:TextBox id="udf1" class="udf1" name="udf1" value="" placeholder="User description1" runat="server"></asp:TextBox>

                            </div>
                        
                            <div class="form-field">
                                <label for="udf2">UDF2</label>
                                <asp:TextBox id="udf2" class="udf2" name="udf2" value="" placeholder="User description2" runat="server"></asp:TextBox>
                            </div>
                    
                            <div class="form-field">
                                <label for="udf3">UDF3</label>
                                <input id="udf3" class="udf3" name="udf3" value="" placeholder="User description3">
                            </div>
                    
                            <div class="form-field">
                                <label for="udf4">UDF4</label>
                                <input id="udf4" class="udf4" name="udf4" value="" placeholder="User description4">
                            </div>
                    
                            <div class="form-field">
                                <label for="udf5">UDF5</label>
                                <input id="udf5" class="udf5" name="udf5" value="" placeholder="User description5">
                            </div>
                            
                            <div class="form-field">
                                <label for="address1">Address 1</label>
                                <input id="address1" class="address1" name="address1" value="" 
                                placeholder="#250, Main 5th cross,">
                            </div>
                    
                            <div class="form-field">
                                <label for="address2">Address 2</label>
                                <input id="address2" class="address2" name="address2" value="" 
                                placeholder="Saket nagar, Pune">
                            </div>
                            
                            <div class="form-field">
                                <label for="city">City</label>
                                <input id="city" class="city" name="city" value="" placeholder="Pune">
                            </div>
                    
                            <div class="form-field">
                                <label for="state">State</label>
                                <input id="state" class="state" name="state" value="" placeholder="Maharashtra">
                            </div>
                    
                            <div class="form-field">
                                <label for="country">Country</label>
                                <input id="country" class="country" name="country" value="" placeholder="India">
                            </div>
                            
                            <div class="form-field">
                                <label for="zipcode">Zip-Code</label>
                                <input id="zipcode" class="zipcode" name="zipcode" value="" placeholder="123456">
                            </div>

                              <div class="form-field">
                                <label for="show_payment_mode">Show Payment Mode</label>
                                <<asp:TextBox id="show_payment_mode" class="show_payment_mode" name="show_payment_mode" value="" placeholder="NB,DC,CC,DAP,MW,UPI,OM,EMI" runat="server"></asp:TextBox>
                            </div>

                        </div>
                
                        <asp:TextBox type="hidden" name="initiatePaymentAPI" value="initiatePaymentAPI" runat="server"></asp:TextBox>
                        <div class="btn-submit">
                           
                            <asp:Button  id="button1" runat="server" Text="initiate payment" OnClick="button1_Click" />
                        </div>
                    </div>
</asp:Content>

