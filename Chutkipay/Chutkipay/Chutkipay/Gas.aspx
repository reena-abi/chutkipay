<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeFile="Gas.aspx.cs" Inherits="Gas" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
<section id="Broadband">
    <div class="container">
         <div class="row">
            <div class="col-lg-12 text-center" >
                <h2>Gas</h2>
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
                      <label>Name</label>
                      <asp:TextBox ID="txtbill" runat="server" class="form-control" placeholder="Enter Name"></asp:TextBox>  
                 </div>                
                 <div class="col-md-6 col-lg-3 form-group">
                      <label>Gas Name</label>
                       <asp:DropDownList ID="bpbill" runat="server" class="form-control custom-select browser-default" >
                        <asp:ListItem Value="0">Select Gas</asp:ListItem>
                        <asp:ListItem Value="1">Bharat Gas</asp:ListItem>
                        <asp:ListItem Value="2">HP Gas</asp:ListItem>
                        <asp:ListItem Value="3">Indane Gas(Indian Oil)</asp:ListItem>
                     </asp:DropDownList>   
                 </div>                 
                 <div class="col-md-6 col-lg-3 form-group">
                      <label>Amount</label>
                      <asp:TextBox ID="txtamount" runat="server" class="form-control" placeholder="Enter Amount"></asp:TextBox>  
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

