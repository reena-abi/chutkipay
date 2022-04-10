<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="BillPay.aspx.cs" Inherits="RajBillPay.BillPay" %>



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
      
    <div class="row bg-white" >
        <div class="col-md-12 form-area pt-5">
            <h2 class="text-4 mb-3">Bill Recharge</h2>
             <div class="mb-3"> 
                 <a href="#" data-target="#view-plans" data-toggle="modal" class="view-plans">View Plans</a>
             </div>
             <div class="form-row">
                 <div class="col-md-6 col-lg-3 form-group">
                        <asp:label id="lbloprator" runat="server">Select Operator</asp:label>
                     <asp:DropDownList ID="ddlope" runat="server" class="form-control">
                         <asp:ListItem Value="0">Select Operator</asp:ListItem>
                         <asp:ListItem Value="Indian">Indian</asp:ListItem>
                         <asp:ListItem Value="Maharastra">Maharastra</asp:ListItem>
                     </asp:DropDownList>
                    </div>
                 <div class="col-md-6 col-lg-3 form-group">
                       <asp:Label ID="lblid" runat="server">Customer Number</asp:Label>
                       <asp:TextBox ID="txtno" class="form-control" runat="server" placeholder="Enter Customer Number"></asp:TextBox>
                  </div>
                 <div class="col-md-6 col-lg-3 form-group">
                        <asp:label id="Label1" runat="server">Select Mode</asp:label>
                     <asp:DropDownList ID="ddlmode" runat="server" class="form-control">
                         <asp:ListItem Value="0">Select Operator</asp:ListItem>
                         <asp:ListItem Value="Indian">Online</asp:ListItem>
                         <asp:ListItem Value="Maharastra">Offline</asp:ListItem>
                     </asp:DropDownList>
                    </div>
                  <div class="col-md-6 col-lg-3 form-group">
                      <asp:Label ID="lblcard" runat="server">&nbsp;</asp:Label>
                       <asp:TextBox ID="mobileNumber" class="form-control" data-bv-field="number"  required="" placeholder="Enter Card Number" runat="server" onKeypress="return onlyNumbers(event);"></asp:TextBox>
                  </div>
                 <div class="col-md-6 col-lg-3 form-group">
                             <asp:DropDownList ID="ddlop" runat="server" class="custom-select">
                                 <asp:ListItem Value="AIR">Airtel DTH </asp:ListItem>
                                  <asp:ListItem Value="AIR">Dish TV Recharge</asp:ListItem>
                                  <asp:ListItem Value="AIR">Sun Direct Recharge</asp:ListItem>
                                  <asp:ListItem Value="AIR">Tata Sky Recharge</asp:ListItem>
                                 <asp:ListItem Value="AIR">Videocon D2H</asp:ListItem>
                             </asp:DropDownList>
                                
                            </div>
                            <div class="col-md-6 col-lg-3">
                                <div class="form-group input-group">
                                    <div class="input-group-prepend"> <span class="input-group-text">Rs</span> </div>
                                     <asp:TextBox ID="txtamt" class="form-control" data-bv-field="number"  required="" placeholder="Enter Amount"  runat="server" onKeypress="return onlyNumbers(event);"></asp:TextBox>
                                </div>
                            </div>

                            <div class="col-md-6 col-lg-3 form-group" style="margin-top:10px">
                                <asp:Button ID="btnsave" runat="server" class="btn btn-default btn-block rounded-0" Text="Bill Pay"  />
                               
                            </div>
                        </div>
                   
                </div>
            </div>
       
   <%--  <div class="container">
     <h2 class="text-center">Bill Pay</h2>
        <div class="row jumbotron">
        
            <div class="row">
                 <asp:Panel ID="mypnl" runat="server" >
                      <div class="row">
            <div class="col-sm-3 form-group">
                <label for="name-l">Mobile No.</label>
    <asp:TextBox ID="txtholname" runat="server" class="form-control" placeholder="Enter Mobile No." MaxLength="10"></asp:TextBox>
                
            </div>
            <div class="col-sm-3 form-group">
                <label for="email">Amount</label>
                 <asp:TextBox ID="txtacno" runat="server" class="form-control" placeholder="Enter Amount"></asp:TextBox>
            </div>
            <div class="col-sm-3 form-group">
                <label for="address-1">Select Opretor</label>
               <asp:DropDownList ID="ddlbiller" runat="server" class="form-control custom-select browser-default">
                    <asp:ListItem Value="1">Vi</asp:ListItem>
                    <asp:ListItem Value="2">Jio</asp:ListItem>
                      <asp:ListItem Value="3">Airtel</asp:ListItem>
                    </asp:DropDownList>
            </div>
            <div class="col-sm-3 form-group">
                <label for="address-1">Select State</label>
               <asp:DropDownList ID="DropDownList1" runat="server" class="form-control custom-select browser-default">
                    <asp:ListItem Value="1">Uttar Pradesh</asp:ListItem>
                    <asp:ListItem Value="2">Asam</asp:ListItem>
                      <asp:ListItem Value="3">Bihar</asp:ListItem>
                    </asp:DropDownList>
            </div>
            </div>
                      <div class="row">
                           <div class="col-sm-3 form-group">
                               <asp:Button ID="btnrechage" runat="server" CssClass="btn btn-primary" Text="Bill Pay" />
                               </div>
                          </div>
            </asp:Panel>
            </div>
           

            
        </div>
       
    </div>--%>
</asp:Content>
