<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeFile="Muncipality.aspx.cs" Inherits="Muncipality" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <section id="Broadband">
        <div class="container">
            <div class="row">
                <div class="col-lg-12 text-center">
                    <h2>Muncipality</h2>
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
                            <label>Select billers in UP</label>
                            <asp:DropDownList ID="ddlbill" runat="server" class="form-control">
                                <asp:ListItem Value="0">Municipal Corporation-Meerut</asp:ListItem>
                                <asp:ListItem Value="1">Nagar Nigam Agra</asp:ListItem>
                                <asp:ListItem Value="2">Nagar Nigam Aligarh</asp:ListItem>
                                <asp:ListItem Value="3">Nagar Nigam Mathura-Vrindavan</asp:ListItem>
                                <asp:ListItem Value="4">Nagar Palika Parishad lalitpur</asp:ListItem>
                                <asp:ListItem Value="5">Prayagraj  Nagar Nigam</asp:ListItem>
                            </asp:DropDownList>
                        </div>
                         <div class="col-md-6 col-lg-3 form-group">
                            <label>Select billers</label>
                            <asp:DropDownList ID="DropDownList1" runat="server" class="form-control">
                                <asp:ListItem Value="0">Ahmedabad Municipal Corporation</asp:ListItem>
                                <asp:ListItem Value="1">Bicholim Municipal Council</asp:ListItem>
                                <asp:ListItem Value="2">Canacona Municipal Council</asp:ListItem>
                                <asp:ListItem Value="3">Corporation Of City Panaji</asp:ListItem>
                                <asp:ListItem Value="4">Cuncolim Municipal Council</asp:ListItem>
                                <asp:ListItem Value="5">Curchorem Cacora Municipal Council</asp:ListItem>
                                <asp:ListItem Value="6">Directorate Of Municipal Administration Karnataka</asp:ListItem>
                                <asp:ListItem Value="7">Greater Chennai Corporation</asp:ListItem>
                                <asp:ListItem Value="8">Gulbarga City Corporation</asp:ListItem>
                                <asp:ListItem Value="9">Hubli-Dharwad Municipal Corporation</asp:ListItem>
                                <asp:ListItem Value="10">Jejuri Nagarparishad</asp:ListItem>
                                <asp:ListItem Value="11">Kalyan Dombivali Municipal Corporation</asp:ListItem>
                                <asp:ListItem Value="13">Kolhapur Municipal Corporation-Property tax</asp:ListItem>
                                <asp:ListItem Value="14">MCGM Property Tax</asp:ListItem>
                                <asp:ListItem Value="15">Madhya Pradesh Urban(e-Nagarpalika)-Property Tax</asp:ListItem>
                                <asp:ListItem Value="16">Margao Municipal Council</asp:ListItem>
                                <asp:ListItem Value="17">Mhapsa Municipal Council</asp:ListItem>
                                <asp:ListItem Value="18">Mira Bhayander Municipal Corporation</asp:ListItem>
                                <asp:ListItem Value="19">Mormugao Municpal Council</asp:ListItem>
                                <asp:ListItem Value="20">Municipal Corporation-Meerut</asp:ListItem>
                                <asp:ListItem Value="21">Municipal Corporation Rohtak</asp:ListItem>
                                <asp:ListItem Value="22">Municipal Corporation Shimla</asp:ListItem>
                                <asp:ListItem Value="23">Nagar Nigam Agra</asp:ListItem>
                                <asp:ListItem Value="24">Nagar Nigam Aligarh</asp:ListItem>
                                <asp:ListItem Value="25">Nagar Nigam Mathura-Vrindavan</asp:ListItem>
                                <asp:ListItem Value="26">Nagar Palika Palia Kalan</asp:ListItem>

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

