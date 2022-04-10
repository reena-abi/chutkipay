﻿<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeFile="EMI.aspx.cs" Inherits="EMI" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">

    <section id="Broadband">
    <div class="container">
         <div class="row">
            <div class="col-lg-12 text-center" >
                <h2>EMI</h2>
                <hr class="star-primary" />
            </div>
        </div>
        
    </div>
    <asp:Panel ID ="getdata" runat="server" Visible="true">
         <div class="row bg-white">
             <div class="col-md-12 form-area pt-5">
                 <div class="mb-3">

                   </div>
                
             <div class="form-row">
                 <div class="col-md-6 col-lg-3 form-group">
                            <label>Select EMI Billers</label>
                            <asp:DropDownList ID="ddlbill" runat="server" class="form-control">
                                <asp:ListItem Value="0">AFI Gold Loan</asp:ListItem>
                                <asp:ListItem Value="1">APAC Financial</asp:ListItem>
                                <asp:ListItem Value="2">AU Small Finance Bank</asp:ListItem>
                                <asp:ListItem Value="3">AYE Finance</asp:ListItem>
                                <asp:ListItem Value="4">Adhar Housing Finance</asp:ListItem>
                                <asp:ListItem Value="5">Awas Financiers</asp:ListItem>
                            </asp:DropDownList>
                        </div>
                 <div class="col-md-6 col-lg-3 form-group">
                      <label>Link account</label>
                      <asp:TextBox ID="txtaccount" runat="server" class="form-control" placeholder="Enter Account Number" ></asp:TextBox>  
                 </div>

                 <div class="col-md-6 col-lg-3 form-group">
                      <label>Enter Name</label>
                      <asp:TextBox ID="txtname" runat="server" class="form-control" placeholder="Enter name" ></asp:TextBox>  
                 </div>
                  <div class="col-md-6 col-lg-3 form-group">
                      <label>Payment</label>
                      <asp:TextBox ID="txtpayment" runat="server" class="form-control" placeholder="Enter payment" ></asp:TextBox>  
                 </div>
                 <div class="col-md-6 col-lg-3 form-group">
                      <asp:Button ID="btnpay" runat="server" class="btn btn-default btn-block rounded-0" style="margin-top: 43px;" Text="Pay"/>
                 </div>
                 

                </div>            
            </div>
         </div>
     </asp:Panel>

</section>

</asp:Content>

