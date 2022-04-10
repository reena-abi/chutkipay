<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeFile="GetLIC.aspx.cs" Inherits="GetLIC" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <div class="row bg-white" >
        <div class="col-md-12 form-area pt-5">
            <h2 class="text-4 mb-3">Bill Recharge</h2>
             <div class="mb-3"> 
                 <a href="#" data-target="#view-plans" data-toggle="modal" class="view-plans">View Plans</a>
             </div>
             <div class="form-row">
                  <div class="col-md-6 col-lg-3 form-group">
                       <asp:TextBox ID="txtres" class="form-control"   placeholder="Enter Card Number" runat="server" ></asp:TextBox>
                  </div>
                 <div class="col-md-6 col-lg-3 form-group">
                              <asp:TextBox ID="canumber" class="form-control"  placeholder="Enter canumber"  runat="server" ></asp:TextBox>
                                
                            </div>
                            <div class="col-md-6 col-lg-3">
                                <div class="form-group input-group">
                                    <div class="input-group-prepend"> <span class="input-group-text">Rs</span> </div>
                                     <asp:TextBox ID="ad1" class="form-control"   placeholder="Enter ad1"  runat="server" ></asp:TextBox>
                                </div>
                            </div>

                            <div class="col-md-6 col-lg-3 form-group">
                                <asp:Button ID="save" runat="server" class="btn btn-default btn-block rounded-0" Text="Bill Pay" OnClick="save_Click" />
                               
                            </div>
                        </div>
                   
                </div>
            </div>

    

</asp:Content>

