<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeFile="Broadband.aspx.cs" Inherits="Broadband" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
<section id="Broadband">
    <div class="container">
         <div class="row">
            <div class="col-lg-12 text-center" >
                <h2>Broadband</h2>
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
                      <label>Broadband/Landline Operator</label>
                       <asp:DropDownList ID="ddlupi" runat="server" class="form-control custom-select browser-default" OnSelectedIndexChanged="ddlupi_SelectedIndexChanged" >
                          <asp:ListItem Value="0">Select Broadband/Landline Operator</asp:ListItem>
                          <asp:ListItem Value="Account">ACT Broadband</asp:ListItem>
                          <asp:ListItem Value="UPI">Activeline</asp:ListItem>
                      </asp:DropDownList> 
                 </div>
                 <div class="col-md-6 col-lg-3 form-group">
                      <label>Username</label>
                      <asp:TextBox ID="txtoperator" runat="server" class="form-control" placeholder="Enter Name"></asp:TextBox>                                                    
                 </div>
                 <div class="col-md-6 col-lg-3 form-group" style="margin-top:40px">
                      <asp:Button ID="btnsave" runat="server" class="btn btn-default btn-block rounded-0" Text="Get Bill"/>
                 </div>
                 

                 </div>            
                 </div>
            </div>
     </asp:Panel>

</section>
</asp:Content>

