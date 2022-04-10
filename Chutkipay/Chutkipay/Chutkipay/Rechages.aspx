<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="Rechages.aspx.cs" Inherits="RajBillPay.Rechages" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
       <div class="container">
     <h2 class="text-center">Mobile Rechage</h2>
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
                               <asp:Button ID="btnrechage" runat="server" CssClass="btn btn-primary" Text="Rechage" />
                               </div>
                          </div>
            </asp:Panel>
            </div>
           

            
        </div>
       
    </div>
</asp:Content>
