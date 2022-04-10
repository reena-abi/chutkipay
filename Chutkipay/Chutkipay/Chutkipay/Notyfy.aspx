<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeFile="Notyfy.aspx.cs" Inherits="Notyfy" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <script
src="https://ebz-static.s3.ap-south-1.amazonaws.com/easecheckout/easebuzz-checkout.js"></script>
<script>
var easebuzzCheckout = new EasebuzzCheckout(key, "prod")
document.getElementById("btnpay").onclick = function(e){
var options = {
    access_key: "K7MI260L4R:UT4PWATATF" // access key received via Initiate Payment
onResponse: (response) => {
console.log(response);
},
theme: "#123456" // color hex
}
easebuzzCheckout.initiatePayment(options);
}
</script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <button id="btnpay">Proceed to Pay</button>

</asp:Content>

