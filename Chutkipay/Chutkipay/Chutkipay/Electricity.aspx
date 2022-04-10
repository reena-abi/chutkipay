<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeFile="Electricity.aspx.cs" Inherits="Electricity" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <section id="Broadband">
    <div class="container">
         <div class="row">
            <div class="col-lg-12 text-center" >
                <h2>Electricity</h2>
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
                 <div class="col-md-6 col-lg-3 form-group" runat="server" id="ebillpay">
                     <label>Pay Electricity Bill</label>
                     <asp:DropDownList ID="bpbill" runat="server" class="form-control custom-select browser-default" OnSelectedIndexChanged="bpbill_SelectedIndexChanged" AutoPostBack="true">
                        <asp:ListItem Value="0">Select Electricity Board</asp:ListItem>
                        <asp:ListItem Value="1">Electricity Boards</asp:ListItem>
                        <asp:ListItem Value="2">Appartments</asp:ListItem>
                       
                     </asp:DropDownList> 
                 </div>
                 <div class="col-md-6 col-lg-3 form-group" runat="server" id="ddstates" >
                      <label>States</label>
                      <asp:DropDownList ID="ddlstates" runat="server" class="form-control custom-select browser-default" >
                          <asp:ListItem Value="0">Select States</asp:ListItem>
                          <asp:ListItem Value="1">Uttar Pradesh</asp:ListItem>
                          <asp:ListItem Value="2">Andhra Pradesh</asp:ListItem>
                          <asp:ListItem Value="3">Arunachal Pradesh</asp:ListItem>
                          <asp:ListItem Value="4">Assam</asp:ListItem>
                      </asp:DropDownList>  
                 </div>
                  <div class="col-md-6 col-lg-3 form-group" runat="server" id="ddboards" visible="false" >
                      <label>Electricity Board</label>
                      <asp:DropDownList ID="ddlboards" runat="server" class="form-control custom-select browser-default" >
                          <asp:ListItem Value="0">Select Boards</asp:ListItem>
                          <asp:ListItem Value="1">Noida Power Corporation Ltd(NPCL)</asp:ListItem>
                          <asp:ListItem Value="2">Kanpur Electricity Supply Company</asp:ListItem>
                          <asp:ListItem Value="3">TP Renewables Microgrid LTd</asp:ListItem>
                          <asp:ListItem Value="4">Uttar Pradesh Power Corporation Ltd(UPPCL)</asp:ListItem>
                      </asp:DropDownList>  
                 </div>
                 <div class="col-md-6 col-lg-3 form-group" runat="server" id="distype" visible="false">
                      <label>District/Type</label>
                      <asp:DropDownList ID="ddldistype" runat="server" class="form-control custom-select browser-default" >
                          <asp:ListItem Value="0">Select District/Type</asp:ListItem>
                          <asp:ListItem Value="1">Prepaid Meter Recharge</asp:ListItem>
                          <asp:ListItem Value="2">Rural</asp:ListItem>
                          <asp:ListItem Value="3">Urban- RAPDRP / Smart Meters</asp:ListItem>
                      </asp:DropDownList>  
                 </div>
                 <div class="col-md-6 col-lg-3 form-group" runat="server" id="division" visible="false">
                      <label>Division/District/ERO</label>
                      <asp:DropDownList ID="ddldiv" runat="server" class="form-control custom-select browser-default" >
                          <asp:ListItem Value="0">Select District/Division/ERO</asp:ListItem>
                          <asp:ListItem Value="1">Dakshinanchal Vidyut Vitran Nigam Ltd.(DVVNL)</asp:ListItem>
                          <asp:ListItem Value="2">Madhyanchal Vidyut Vitaran Nigam Ltd. (MVVNL)</asp:ListItem>
                          <asp:ListItem Value="3">Paschimanchal Vidyut Vitran Nigam Ltd. (PVVNL)</asp:ListItem>
                          <asp:ListItem Value="4">Purvanchal Vidyut Vitaran Nigam Ltd. (PUVVNL)</asp:ListItem>
                      </asp:DropDownList> 
                 </div>
                 <div class="col-md-6 col-lg-3 form-group" runat="server" visible="false">
                      <label>Consumer Number</label>
                      <asp:TextBox ID="txtnum" runat="server" class="form-control" placeholder="Enter Consumer Number" ></asp:TextBox>  
                 </div>
                 <div class="col-md-6 col-lg-3 form-group" runat="server" visible="false">
                      <label>View Sample Bill</label>
                      <asp:TextBox ID="txtbill" runat="server" class="form-control" placeholder="View Sample Bill" ></asp:TextBox>  
                 </div>
                 <div class="col-md-6 col-lg-3 form-group" runat="server" visible="false">
                      <label>ABC Code</label>
                      <asp:TextBox ID="txtcode" runat="server" class="form-control" placeholder="Selcet Code" ></asp:TextBox>  
                 </div>
                 
                 <div class="col-md-6 col-lg-3 form-group" style="margin:40px">
                      <asp:Button ID="btnproceed" runat="server" class="btn btn-default btn-block rounded-0" Text="Proceed"/>
                 </div>
                 
                </div>            
                 </div>
            </div>
     </asp:Panel>

</section>

</asp:Content>

