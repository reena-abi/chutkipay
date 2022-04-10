<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeFile="Cable.aspx.cs" Inherits="Cable" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <section id="Broadband">
        <div class="container">
            <div class="row">
                <div class="col-lg-12 text-center">
                    <h2>Cable</h2>
                    <hr class="star-primary" />
                </div>
            </div>

        </div>
        <asp:Panel ID="getdata" runat="server" Visible="true">
            <div class="row bg-white">
                <div class="col-md-12 form-area pt-5">
                    <div class="mb-3">
                    </div>

                    <div class="form-row">
                        <div class="col-md-6 col-lg-3 form-group">
                            <label>Enter contact number</label>
                            <asp:TextBox ID="txtnumber" runat="server" class="form-control" placeholder="Enter contact number"></asp:TextBox>
                        </div>
                        <div class="col-md-6 col-lg-3 form-group">
                            <label>Selct cable billers/DTH</label>
                            <asp:DropDownList ID="ddlbill" runat="server" class="form-control">
                                <asp:ListItem Value="0">Select Biller/DTH</asp:ListItem>
                                <asp:ListItem Value="1">ACT Digital TV</asp:ListItem>
                                <asp:ListItem Value="2">Airtel Digital TV</asp:ListItem>
                                <asp:ListItem Value="3">Ambiga Digital Vision</asp:ListItem>
                                <asp:ListItem Value="4">Asianet Digital TV</asp:ListItem>
                                <asp:ListItem Value="5">D2H</asp:ListItem>
                                <asp:ListItem Value="6">Dish TV</asp:ListItem>
                                <asp:ListItem Value="7">GTPL Hathway Digital TV </asp:ListItem>
                                <asp:ListItem Value="8">Hathway Digital TV</asp:ListItem>
                                <asp:ListItem Value="9">INDigital</asp:ListItem>
                                <asp:ListItem Value="10">Sun Direct</asp:ListItem>
                                <asp:ListItem Value="11">Tata Play (formerly Tata Sky )</asp:ListItem>
                            </asp:DropDownList>
                        </div>

                        <div class="col-md-6 col-lg-3 form-group">
                            <label>Payment</label>
                            <asp:TextBox ID="txtpayment" runat="server" class="form-control" placeholder="Enter payment"></asp:TextBox>
                        </div>
                        <div class="col-md-6 col-lg-3 form-group">
                            <asp:Button ID="btnpay" runat="server" class="btn btn-default btn-block rounded-0" Style="margin-top: 43px;" Text="Pay" />
                        </div>


                    </div>
                </div>
            </div>
        </asp:Panel>

    </section>
</asp:Content>

