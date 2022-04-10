<%@ Page Title="" Language="C#" MasterPageFile="~/Admin/Retailer.master" AutoEventWireup="true" CodeFile="ViewOwnCommition.aspx.cs" Inherits="Admin_ViewOwnCommition" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
      <style>.table td, .table th {
    padding: 1px;
    vertical-align: top;
    border-top: 1px solid #dee2e6;
   font-size: 13px;
}
          </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <div class="content-wrapper">

				
					<div class="fixedBodyScroll" style="width:12px">

						<!-- Row start -->
						<div class="row gutters">
							<div class="col-xl-12 col-lg-12 col-md-12 col-sm-12 col-12">
								
								<!-- Card start -->
								<div class="card">
									<div class="card-body">
									
										
										
	
										<!-- Row start -->
							<div class="row gutters">
                           
                                <div class="col-sm-12">
                                    <div class="control-group">
                                        <asp:Panel ID="pnlGrid" runat="server">
                                           <asp:GridView ID="grid2" runat="server" CellPadding="1" GridLines="Horizontal"   Width="100%"
                                                CssClass="table table-bordered" BackColor="White" BorderColor="#E7E7FF" BorderStyle="None" BorderWidth="1px" AutoGenerateColumns="False">
                                                <AlternatingRowStyle BackColor="White"/>
                                                <Columns>
                                                    <asp:BoundField HeaderText="S.No." DataField="sno" />
                                                    <asp:BoundField HeaderText="Account NO" DataField="Accountno" />
                                                    <asp:BoundField HeaderText="Credit" DataField="Cr" />
                                                      <asp:BoundField HeaderText="Amount" DataField="txnamount" />
                                                    <asp:BoundField HeaderText="RRN No" DataField="bankrrn" />
                                                    <asp:BoundField HeaderText="Date" DataField="date" />
                                                    <asp:BoundField HeaderText="PayMode" DataField="Payment_mode" />
                                                    
                                                    <asp:BoundField HeaderText="Status" DataField="Status" />
                                                    
                                                </Columns>
                                                <EditRowStyle BackColor="#2461BF" />
                                                <FooterStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
                                                <HeaderStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
                                                <PagerStyle BackColor="#2461BF" ForeColor="White" HorizontalAlign="Center" />
                                                <RowStyle BackColor="#EFF3FB" />
                                                <SelectedRowStyle BackColor="#D1DDF1" Font-Bold="True" ForeColor="#333333" />
                                                <SortedAscendingCellStyle BackColor="#F5F7FB" />
                                                <SortedAscendingHeaderStyle BackColor="#6D95E1" />
                                                <SortedDescendingCellStyle BackColor="#E9EBEF" />
                                                <SortedDescendingHeaderStyle BackColor="#4870BE" />
                                            </asp:GridView>
                                        </asp:Panel>
                                    </div>
                                </div>
                            </div>
                                      
                                        </div>
                                    </div>
                                </div>
                            </div>
                        </div>
    </div>
</asp:Content>

