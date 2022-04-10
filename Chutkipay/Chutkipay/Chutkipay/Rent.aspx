<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeFile="Rent.aspx.cs" Inherits="Rent" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
<div class="row bg-white" >
        <div class="col-md-12 form-area pt-5">
            <h2 class="text-4 mb-3">Rent Pay</h2>
             <div class="mb-3"> 
                  </div>
            <div class="form-row">
                 <div class="col-md-6 col-lg-6 form-group">
                      <label for="name-f">Select Biller</label>
                     <asp:DropDownList ID="ddlbillnmame" runat="server" class="form-control custom-select browser-default" OnSelectedIndexChanged="ddlbillnmame_SelectedIndexChanged" AutoPostBack="true" >
                     <asp:ListItem Value="0">Select list</asp:ListItem>
                          <asp:ListItem Value="1">Milk Man</asp:ListItem>
                          <asp:ListItem Value="2">Land Loard</asp:ListItem>
                          <asp:ListItem Value="3">Chai Wala</asp:ListItem>
                          <asp:ListItem Value="4">News Paper</asp:ListItem>
                          <asp:ListItem Value="5">Water Man</asp:ListItem>
                          <asp:ListItem Value="6">Vegetable Man</asp:ListItem>
                          <asp:ListItem Value="7">Garbage Man</asp:ListItem>
                      </asp:DropDownList>
                      </div>
                <div class="col-md-6 col-lg-6 form-group" id="divupi" >
                      <label for="name-f">&nbsp;  </label>
                      <asp:DropDownList ID="ddlupi" runat="server" class="form-control custom-select browser-default" Visible="false" OnSelectedIndexChanged="ddlupi_SelectedIndexChanged" AutoPostBack="true" >
                          <asp:ListItem Value="0">Select Payment By</asp:ListItem>
                          <asp:ListItem Value="Account">Account</asp:ListItem>
                          <asp:ListItem Value="UPI">UPI</asp:ListItem>
                      </asp:DropDownList>
                      </div>
                </div>
              <div >
                  <asp:Panel ID="pnlAccount" runat="server" CssClass="mypnl" Visible="false">
                    <div class="form-row">
                    <div class="col-md-6 col-lg-3 form-group">
                        <label for="name-l">Name</label>
                        <asp:TextBox ID="txtholname" runat="server" class="form-control" placeholder="Enter Account Holder Name."></asp:TextBox>
                    </div>
                    <div class="col-md-6 col-lg-3 form-group">
                       <label for="address-1">Email ID</label>
                       <asp:TextBox ID="txtemail" runat="server" class="form-control" placeholder="Enter Email Id"></asp:TextBox>           
                    </div>
                    <div class="col-md-6 col-lg-3">
                     <label for="address-1">Contact No.</label>
                       <asp:TextBox ID="txtmob" runat="server" class="form-control" placeholder="Enter Contect No" MaxLength="10"></asp:TextBox>
                    </div>
                    <div class="col-md-6 col-lg-3 form-group">
                           <label for="address-1">Amount</label>
                           <asp:TextBox ID="txtamount" runat="server" class="form-control" placeholder="Enter Amount"></asp:TextBox>
                    </div>
                    </div>

                    <div class="form-row mb-1">

                    <div class="col-md-6 col-lg-3 form-group">
                    <label for="name-l">Payment Mode</label>
                           <asp:DropDownList ID="DropDownList1" runat="server" class="form-control">
                                <asp:ListItem Value="0">Select list</asp:ListItem>
                                 <asp:ListItem Value="1">IMPS</asp:ListItem>
                                <asp:ListItem Value="2">NEFT</asp:ListItem>
                                 <asp:ListItem Value="3">RTGS</asp:ListItem>                            
                            </asp:DropDownList>
                   </div> 
                   <div class="col-md-6 col-lg-3 form-group">
                          <label for="address-1">Name of Account</label>
                          <asp:TextBox ID="txtacname" runat="server" class="form-control" placeholder="Enter Account name"></asp:TextBox>
                   </div>
                        <div class="col-md-6 col-lg-3 form-group">
                          <label for="address-1">Account No.</label>
                          <asp:TextBox ID="txtacnumber" runat="server" class="form-control" placeholder="Enter Account No"></asp:TextBox>
                   </div>
                   <div class="col-md-6 col-lg-3 form-group">
                           <label for="address-1">IFSC Code</label>
                           <asp:TextBox ID="txtifsc" runat="server" class="form-control" placeholder="Enter IFSC Code"></asp:TextBox>
                   </div>    
                       <div class="col-md-6 col-lg-3 form-group" style="margin-top:34px">
                         <div class="form-group input-group">
                            <div class="input-group-prepend"> <span class="input-group-text">Rs</span> </div>
                            <asp:TextBox ID="txtamt" class="form-control" data-bv-field="number"  required="" placeholder="Enter Amount"  runat="server" onKeypress="return onlyNumbers(event);"></asp:TextBox>
                            </div>
                       </div>
                  
                       <div class="col-md-6 col-lg-3 form-group" style="margin-top:42px">
                             <asp:Button ID="btnrechage" runat="server" CssClass="btn btn-default btn-block rounded-0" Text="Bill Pay" />
                       </div>
                       </div>
                      </asp:Panel>
                 <asp:Panel ID="pnlUPI" runat="server" Visible="false">
                     <div class="form-row">
                        <div class="col-md-6 col-lg-3 form-group">
                        <label for="name-l">Payee Name</label>
                        <asp:TextBox ID="Txtname" runat="server" class="form-control" placeholder="Enter Name"></asp:TextBox>
                        </div>
                        <div class="col-md-6 col-lg-3 form-group">
                        <label for="name-l">UPI ID</label>
                        <asp:TextBox ID="txtid" runat="server" class="form-control" placeholder="Enter UPI ID"></asp:TextBox>
                        </div>
                        <div class="col-md-6 col-lg-3 form-group" style="margin-top:40px">
                        <asp:Button ID="btnpaybill" runat="server" CssClass="btn btn-default btn-block rounded-0" Text="Submit" />
                      </div>
                    </div> 
                 </asp:Panel>
                    </div>
                   
              </div>
           
     </div>
</asp:Content>

