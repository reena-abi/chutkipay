<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeFile="Gpay.aspx.cs" Inherits="Gpay" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">

    <section id="Broadband">
    <div class="container">
         <div class="row">
            <div class="col-lg-12 text-center" >
                <h2>Gpay</h2>
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
                      <label>Enter contact number</label>
                      <asp:TextBox ID="txtnumber" runat="server" class="form-control" placeholder="Enter Contact number"></asp:TextBox>  
                     <label>Or</label>
                     <asp:TextBox ID="txtid" runat="server" class="form-control" placeholder="Enter Upi Id"></asp:TextBox>  
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

