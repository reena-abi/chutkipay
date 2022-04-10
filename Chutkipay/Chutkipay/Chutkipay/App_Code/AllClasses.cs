using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.IO;
using System.Linq;
using System.Web;


#region Default



/*
public class Users
{
    public Users()
    {

    }
    public Users(DataRow dr)
    {
        this._ManualCode = dr["ManualCode"].ToString();
        this._UserCode = dr["UserCode"].ToString();
        this._UserName = dr["UserName"].ToString();
        this._Password = dr["Password"].ToString();
        this._ManualCode = dr["ManualCode"].ToString();
        this._Status = byte.Parse(dr["Status"].ToString());
        this._UserId = long.Parse(dr["UserId"].ToString());
        this._UserId = long.Parse(dr["UserId"].ToString());
        this.Role = dr["UserRole"].ToString();
        this.TPassword = dr["TPassword"].ToString();
        this.TPassword = dr["TPassword"].ToString();
        this.MemberID = int.Parse(dr["MemberID"].ToString());
        this.Designation = dr["Designation"].ToString();
        this.Name = dr["MemberName"].ToString();
        //  this.RoleId = int.Parse( dr["RoleID"].ToString());
    }

    public String Role { get; set; }
    public int RoleId { get; set; }
    long _UserId = -1;

    public string Designation { get; set; }
    public long UserId
    {
        get { return _UserId; }
        set { _UserId = value; }
    }
    string _UserCode = "";
    public string Name { get; set; }
    public string UserCode
    {
        get { return _UserCode; }
        set { _UserCode = value; }
    }
    string _UserName = "";

    public string UserName
    {
        get { return _UserName; }
        set { _UserName = value; }
    }
    string _Password = "";

    public string Password
    {
        get { return _Password; }
        set { _Password = value; }
    }
    string _ManualCode = "";

    public string ManualCode
    {
        get { return _ManualCode; }
        set { _ManualCode = value; }
    }
    byte _Status;

    public byte Status
    {
        get { return _Status; }
        set { _Status = value; }
    }

    public string TPassword { get; set; }
    public int MemberID { get; set; }
    public static Users Current
    {
        get
        {
            HttpContext.Current.Session["__User"] = 1;
            if (HttpContext.Current.Session["__User"] != null)
            {
                return HttpContext.Current.Session["__User"] as Users;
            }
            else
            {
                //    throw new Exception(" User not logedin");
                return HttpContext.Current.Session["__User"] as Users;
            }
        }

    }
}
 */
public class Users
{
    public Users()
    {

    }
    public Users(DataRow dr)
    {
        this._ManualCode = dr["ManualCode"].ToString();
        this._UserCode = dr["UserCode"].ToString();
        this._UserName = dr["UserName"].ToString();
        this._Password = dr["Password"].ToString();
        this._Status = byte.Parse(dr["Status"].ToString());
        this._UserId = int.Parse(dr["UserId"].ToString());
        this.TPassword = dr["TPassword"].ToString();
       // this.DesignationID = short.Parse(dr["DesignationId"].ToString());
        this.EmployeeID = int.Parse(dr["EmployeeID"].ToString());
        this.Name = dr["Name"].ToString();
        this.RoleID = int.Parse(dr["RoleID"].ToString());
        this.Role = dr["Role"].ToString();
        this.MaxLimitDiscount = decimal.Parse(dr["MaxLimitDiscount"].ToString());
        this.MemberID = int.Parse(dr["MemberID"].ToString());
        this.Mobile = (dr["Mobile"].ToString());
        this.Address = (dr["Address"].ToString());
        this.PinCode = (dr["PinCode"].ToString());
        this.Email = (dr["Email"].ToString());

    }


    int _UserId = -1;
    public int UserId
    {
        get { return _UserId; }
        set { _UserId = value; }
    }
    string _UserCode = "";
    public string UserCode
    {
        get { return _UserCode; }
        set { _UserCode = value; }
    }
    string _UserName = "";

    public string UserName
    {
        get { return _UserName; }
        set { _UserName = value; }
    }
    string _Password = "";

    public string Password
    {
        get { return _Password; }
        set { _Password = value; }
    }
    string _ManualCode = "";

    public string ManualCode
    {
        get { return _ManualCode; }
        set { _ManualCode = value; }
    }
    byte _Status;

    public byte Status
    {
        get { return _Status; }
        set { _Status = value; }
    }

    public string TPassword { get; set; }
    public long MemberID { get; set; }
    public short DesignationID { get; set; }
    public int EmployeeID { get; set; }
    public string Name { get; set; }
    public int RoleID { get; set; }
    public string Role { get; set; }
    public decimal MaxLimitDiscount { get; set; }
    public string Mobile { get; set; }
    public string Address { get; set; }
    public string PinCode { get; set; }
    public string Email { get; set; }

    public static Users Current
    {
        get
        {
            HttpContext.Current.Session["__User"] = 1;
            if (HttpContext.Current.Session["__User"] != null)
            {
                return HttpContext.Current.Session["__User"] as Users;
            }
            else
            {
                return HttpContext.Current.Session["__User"] as Users;
            }
        }
    }
}
#endregion

#region BS03

public class S01_ProductType
{
    public long ProductTypeId { get; set; }
    public string Product { get; set; }
    public string Status { get; set; }
    public string Code { get; set; }
    public bool IsDel { get; set; }
    public short S01_ParentID { get; set; }
    public int Vw_ProductCatId { get; set; }
    public string BussinessType { get; set; }
}
public class M06_TechinalData
{
    public long TechinalDataId { get; set; }
    public string TechinalData { get; set; }
    public string Status { get; set; }
    public bool IsDel { get; set; }
    public long @M06_ParentID { get; set; }
}

public class M23_Specification
{
    public long SpecificationId { get; set; }
    public string Specification { get; set; }
    public string Status { get; set; }
    public string Code { get; set; }
    public bool IsDel { get; set; }
    public long @ParentID { get; set; }
}


public class S02_ProductTechnical
{
    public long ProductTechnicalId { get; set; }
    public long M06_TechinalId { get; set; }
    public long S01_ProductTypeId { get; set; }
}
#endregion

public class paysprint
{
    public string id { get; set; }
    public string name { get; set; }
    public string amount { get; set; }
    public string status { get; set; }
    public string datetime { get; set; }
    public string duedate { get; set; }
    public string services { get; set; }
    public string ClientId { get; set; }
    public string eord { get; set; }
}
     
public class addservice
{
    public string services { get; set; }
    public string ClientId { get; set; }
    public string eord { get; set; }
}

public class AddPackage
{
    public int id { get; set; }
    public int PK_id { get; set; }

    public string CreateBy { get; set; }
    public string network { get; set; }
    public string abicomtype { get; set; }
    public string comtype { get; set; }
    public decimal rt_amt { get; set; }
    public decimal FromAmt { get; set; }
    public decimal ToAmt { get; set; }
    public decimal admin_amt { get; set; }
    public decimal com_amt { get; set; }
    public string ClientId { get; set; }
    public string status { get; set; }
    public decimal mycom { get; set; }
}

public class AEPS_Comm
{
    public int id { get; set; }
    public string DBname { get; set; }
    public string network { get; set; }
    public string abicomtype { get; set; }
    public decimal md_amt { get; set; }
    public string comtype { get; set; }
    public decimal dt_amt { get; set; }
    public string leval { get; set; }
    public decimal rt_amt { get; set; }
    public decimal FromAmt { get; set; }
    public decimal ToAmt { get; set; }
    public decimal admin_amt { get; set; }
    public decimal com_amt { get; set; }
    public string ClientId { get; set; }
    public string status { get; set; }
    public decimal myCommission { get; set; }
    public string sql { get; set; }
    public decimal mycom { get; set; }
}


public class adhar_Comm
{
    public int id { get; set; }
    public string DBname { get; set; }
    public string network { get; set; }
    public string abicomtype { get; set; }
    public string comtype { get; set; }
    public decimal md_amt { get; set; }
    public decimal dt_amt { get; set; }
    public string leval { get; set; }
    public decimal rt_amt { get; set; }
    public decimal FromAmt { get; set; }
    public decimal ToAmt { get; set; }
    public decimal admin_amt { get; set; }
    public decimal com_amt { get; set; }
    public string ClientId { get; set; }
    public string status { get; set; }
    public decimal myCommission { get; set; }
    public string sql { get; set; }
    public decimal mycom { get; set; }
}

public class bbps_Comm
{
    public int id { get; set; }
    public string DBname { get; set; }
    public string network { get; set; }
    public string abicomtype { get; set; }
    public string comtype { get; set; }
    public decimal md_amt { get; set; }
    public decimal dt_amt { get; set; }
    public string leval { get; set; }
    public decimal rt_amt { get; set; }
    public string opname { get; set; }
    public decimal ToAmt { get; set; }
    public decimal admin_amt { get; set; }
    public decimal com_amt { get; set; }
    public string ClientId { get; set; }
    public string status { get; set; }
    public decimal myCommission { get; set; }
    public string sql { get; set; }
    public decimal mycom { get; set; }
}


public class recharge_Comm
{
    public int id { get; set; }
    public string DBname { get; set; }
    public string network { get; set; }
    public string abicomtype { get; set; }
    
    public decimal md_amt { get; set; }
    public decimal dt_amt { get; set; }
    public string comtype { get; set; }
    public string leval { get; set; }
    public decimal rt_amt { get; set; }
    public string opname { get; set; }
    public string opcode { get; set; }
    public decimal admin_amt { get; set; }
    public decimal com_amt { get; set; }
    public string ClientId { get; set; }
    public string status { get; set; }
    public decimal myCommission { get; set; }
    public string sql { get; set; }
    public decimal mycom { get; set; }
}
#region BS05



public class M25_ProductPriority
{
    public int S01_SuperProductType { get; set; }
    public int S03_ProductId { get; set; }
    public string Status { get; set; }

}

public class M19_News
{
    public short NewsID { get; set; }
    public string NewsTypeID { get; set; }
    public string News { get; set; }
    public DateTime Date { get; set; }
    public bool IsDel { get; set; }
    public string Heading { get; set; }
    public string status { get; set; }
    public int Priority { get; set; }
    public string Type { get; set; }
    public string path { get; set; }
    
}

public class S16_ProductRelatedTax
{
    public int ProductRealatedTaxID { get; set; }
    public int S03_ProductId { get; set; }
    public int M18_TaxTypeId { get; set; }
    public string Unit { get; set; }
    public string Status { get; set; }
    public bool IsDel { get; set; }
}
public class Q03_QuotationStatus
{
    public int StatusID { get; set; }
    public int RequestId { get; set; }
    public int QuotationID { get; set; }
    public string Description { get; set; }
    public string RoleCode { get; set; }
    public string Status { get; set; }
    public int MemberID { get; set; }
}
public class Q01
{
    public int @QuatationID { get; set; }
    public decimal @DiscountAmount { get; set; }
    public decimal @TotalAmount { get; set; }
    public decimal @DesignationalDiscount { get; set; }
    public decimal TotalTax { get; set; }
    public decimal @AddDisAmt { get; set; }
}

public class Q02
{
    public int @QuatationID { get; set; }
    public decimal @MRP { get; set; }
    public int @M24_BrandID { get; set; }
    public decimal @Discount { get; set; }
    public int TaxAmount { get; set; }
    public int M18_TaxId { get; set; }
}
public class S15_ProductCost
{
    public int S03_ProductID { get; set; }
    public int M24_BrandID { get; set; }
    public int S12_ProductSizeID { get; set; }
    public decimal MRP { get; set; }
    public decimal Discount { get; set; }
    public string Status { get; set; }

}
public class S17_PersonalProductCost
{
    public int S03_ProductID { get; set; }
    public int M24_BrandID { get; set; }
    public int S12_ProductSizeID { get; set; }
    public decimal MRP { get; set; }
    public decimal Discount { get; set; }
    public string Status { get; set; }

}
public class S14_ProductBrand
{
    public int BrandID { get; set; }
    public int PrroductID { get; set; }
    public string Status { get; set; }

}

public class M24_Brand
{
    public int BrandId { get; set; }
    public string BrandName { get; set; }
    public string Descption { get; set; }
    public string Status { get; set; }
    public string Code { get; set; }
    public string BussType { get; set; }

}
public class T05_ProductSerial
{
    public int S12_ProductSizeId { get; set; }
    public int S03_ProductId { get; set; }
    public int M10_TranstypeId { get; set; }
    public string FromSrNo { get; set; }
    public string ToSrNo { get; set; }
    public int U01_UserId { get; set; }
}
public class Q01_Quotation
{
    public long QuotationID { get; set; }
    public string TransactionNo { get; set; }
    public decimal TotalAmount { get; set; }
    public long M03_VenderID { get; set; }
    public DateTime TransactionDate { get; set; }
    public string InvoiceNo { get; set; }
    public DateTime BillDate { get; set; }
    public string TrasportName { get; set; }
    public string ModeOfTransport { get; set; }
    public short M10_TransTypeId { get; set; }
    public bool Paidstatus { get; set; }
    public DateTime PaymentDate { get; set; }
    public string VehicleNo { get; set; }
    public decimal TotalTax { get; set; }
    public decimal TotalDiscount { get; set; }
    public decimal TransportCharge { get; set; }
    public string DriverName { get; set; }
    public string Status { get; set; }
    public int EmployeeID { get; set; }
    public string discription { get; set; }
    public string RecivedBy { get; set; }
    public DateTime ExpectedDate { get; set; }
    public int M01_OperationID { get; set; }
    public string VendorCode { get; set; }
    public string VendorName { get; set; }
    public string LotNo { get; set; }
    public decimal DesignationDiscount { get; set; }
    public decimal AdditionalDiscount { get; set; }
    public long RefID { get; set; }
    public string TermsAndCon { get; set; }
    public string PinCode { get; set; }
    public string Address { get; set; }
    public string Name { get; set; }
    public string Mobile{ get; set; }
    public string email { get; set; }
}


public class Q02_Quotation
{
    public long Q01_QuotationID { get; set; }

    public long S12_ProductSizeId { get; set; }
    public decimal MRP { get; set; }
    public decimal Rate { get; set; }
   // public string sn { get; set; }
    public string opcode { get; set; }
    public string BAtch { get; set; }
    public DateTime EXPDate { get; set; }
    public DateTime MFGdate { get; set; }
    public decimal Vat { get; set; }
    public decimal Sat { get; set; }
    public decimal OtherTaxes { get; set; }
    public DateTime EntryDate { get; set; }
    public short M10_TransTypeId { get; set; }
    public decimal Discount { get; set; }
    public string Status { get; set; }
    public string @Product { get; set; }
    public short S01_ProductTypeID { get; set; }

    public string @Key { get; set; }
    public string @deSC { get; set; }
    public string @ProductCode { get; set; }
    public int M24_BrandID { get; set; }
    public int M18_TaxId { get; set; }
    public bool IsAccessory { get; set; }
    public decimal @AddProDiscount { get; set; }
    public decimal BV { get; set; }

    public string ctyp { get; set; }

    public string commis { get; set; }

    public string sn { get; set; }



    public string Clientid { get; set; }

   

    public string reply { get; set; }
    public string client_id { get; set; }
    public string message { get; set; }
    public string servicesty { get; set; }
  
    public string team { get; set; }

}
public class M20_Size
{
    public int SizeID { get; set; }
    public string Size { get; set; }
    public string Status { get; set; }


}
public class Raise
{
   
}



public class M21_Material
{
    public int MaterialID { get; set; }
    public string Material { get; set; }
    public string Status { get; set; }


}
public class C01_Company
{

    public int CompanyID { get; set; }
    public string Company { get; set; }
    public int M14_CountryID { get; set; }
    public int M15_StateID { get; set; }
    public int M16_CityID { get; set; }
    public string Address { get; set; }
    public string Pincode { get; set; }
    public String MobileNo { get; set; }
    public string AlternateNo { get; set; }
    public string EmailNo { get; set; }
    public string TINNo { get; set; }
    public string ServiceTaxNo { get; set; }
    public string SalesTaxNo { get; set; }
    public decimal CapitalAmount { get; set; }
    public DateTime EntryDate { get; set; }
    public string LogoImage { get; set; }
    public string RegistrationCode { get; set; }
    public decimal shipChg { get; set; }
    public decimal shipNotAply { get; set; }

}
public class T05_PaymentGroupDetail
{
    public long PaymentGroupId { get; set; }
    public DateTime FromClosingDate { get; set; }
    public DateTime ToClosingDate { get; set; }
    public DateTime EntryDate { get; set; }
    public long M01_MemberID { get; set; }
    public decimal OneIncome { get; set; }
    public decimal TDS { get; set; }
    public decimal AdminCom { get; set; }
    public decimal FinalAmount { get; set; }
    public string PaymentMode { get; set; }
    public DateTime PaymentDate { get; set; }
    public string PaymentNo { get; set; }
    public string ComIDs { get; set; }
    public decimal SelfRep { get; set; }
    public decimal LevelRep { get; set; }
    public decimal SponsoringRep { get; set; }
    public decimal SalesRoyalty { get; set; }
    public decimal CRP { get; set; }
    public bool IsRep { get; set; }
    public string Email { get; set; }

    public string MemberName { get; set; }
    public string Mobile { get; set; }
    public int M46_PaymentRemarkID { get; set; }
    public bool IsM01_Member { get; set; }

}
public class T02_Payment
{
    public int PaymentId { get; set; }
    public int T01_CommissionID { get; set; }
    public long T05_PaymentGroupId { get; set; }
}
public class SP_InsertUpdateCustomerLedger
{
    public int @CustomerLedgerID { get; set; }
    public int @M08_CustomerId { get; set; }
    public string @A01_AccheadCode { get; set; }
    public decimal @Cr { get; set; }
    public decimal @Dr { get; set; }
    public string @A02_LedgerType { get; set; }
    public long @RefID { get; set; }
    public string @U01_AddByUserId { get; set; }
    public string @Narration { get; set; }
}

public class M13_Designation
{
    public short DesignationId { get; set; }
    public string Designation { get; set; }
    public decimal @DiscountLimit { get; set; }
    public string Code { get; set; }
    public string @Status { get; set; }

}
public class T11_DistPayment
{
    public long DistPaymentId { get; set; }
    public long M01_MemberId { get; set; }
    public decimal Amount { get; set; }
    public string Narration { get; set; }
    public long U01_AddedBy { get; set; }
    public string PayMode { get; set; }
    public bool IsMember { get; set; }
}
public class M08_Vendor
{
    public long VendorID { get; set; }
    public string VendorCode { get; set; }
    public string VendorName { get; set; }
    public string CompanyName { get; set; }
    public string MobileNo { get; set; }
    public string AlternateMob { get; set; }
    public string Address { get; set; }
    public int M02_CountryID { get; set; }
    public int M03_StateID { get; set; }
    public int M04_CityID { get; set; }
    public string Email { get; set; }
    public string Gender { get; set; }
    public string IsCustomer { get; set; }
    public string Tin { get; set; }
    public string PanNo { get; set; }
    public string PinCode { get; set; }
    public string IFSCCode { get; set; }
    public string AccountNo { get; set; }
    public string BranchName { get; set; }
    public int M13_BankID { get; set; }
    public string ExciseCode { get; set; }
    public string ServiceTaxNo { get; set; }
    public string GSTNo { get; set; }
    public string RTGSNo { get; set; }
    public string NEFTNo { get; set; }
    public string AccountName { get; set; }
    public string ContPerson1 { get; set; }
    public string C1Email { get; set; }
    public string C1Phone { get; set; }
    public string C1Desig { get; set; }
    public string ContPerson2 { get; set; }
    public string C2Email { get; set; }
    public string C2Phone { get; set; }
    public string C2Desig { get; set; }
    public string BranchAddress { get; set; }
}


public class M18_Tax
{
    public int TaxId { get; set; }
    public int M17_TaxTypeId { get; set; }
    public Decimal @TaxRate { get; set; }
    public string @Status { get; set; }
    public bool IsDel { get; set; }

}
public class S06_ProductCost
{
    public int ProductSizeID { get; set; }
    public int ProductCostID { get; set; }
    public int S03_ProductId { get; set; }
    public Decimal ProductCost { get; set; }
    public int MinimumQty { get; set; }
    public int U01_UserID { get; set; }
    public Decimal Discount { get; set; }

}

public class T01_Stock
{
    public long StockID { get; set; }
    public string TransactionNo { get; set; }
    public decimal TotalAmount { get; set; }
    public long M03_VenderID { get; set; }
    public DateTime TransactionDate { get; set; }
    public string InvoiceNo { get; set; }
    public DateTime BillDate { get; set; }
    public string TrasportName { get; set; }
    public string ModeOfTransport { get; set; }
    public short M10_TransTypeId { get; set; }
    public bool Paidstatus { get; set; }
    public int M01_SellerId { get; set; }
    public DateTime PaymentDate { get; set; }
    public string VehicleNo { get; set; }
    public decimal TotalTax { get; set; }
    public decimal TotalDiscount { get; set; }
    public decimal TransportCharge { get; set; }
    public string DriverName { get; set; }
    public string Status { get; set; }
    public long EmployeeID { get; set; }
    public string discription { get; set; }
    public string RecivedBy { get; set; }
    public DateTime ExpectedDate { get; set; }
    public int M01_OperationID { get; set; }
    public string @VendorCode { get; set; }
    public string @VendorName { get; set; }
    public string LotNo { get; set; }
    public decimal DesignationDiscount { get; set; }
    public decimal AdditionalDiscount { get; set; }
    public long @RefID { get; set; }
    public int M29_CouponID  { get; set; }
}

public class T03_Stock
{
    public long T01_StockId { get; set; }
    public long S12_ProductSizeId { get; set; }
    public long S03_ProductId { get; set; }
    public decimal MRP { get; set; }
    public decimal Rate { get; set; }
    public int Quantity { get; set; }
    public string BAtch { get; set; }
    public DateTime EXPDate { get; set; }
    public DateTime MFGdate { get; set; }
    public decimal Vat { get; set; }
    public decimal Sat { get; set; }
    public decimal OtherTaxes { get; set; }
    public DateTime EntryDate { get; set; }
    public short M10_TransTypeId { get; set; }
    public decimal Discount { get; set; }
    public string Status { get; set; }
    public string @Product { get; set; }
    public short S01_ProductTypeID { get; set; }
    public short Vw_ProductCategory { get; set; }
    public string @Key { get; set; }
    public string @deSC { get; set; }
    public string @ProductCode { get; set; }
    public string Brand { get; set; }
    public int BrandID { get; set; }
    public decimal BV { get; set; }

}


public class T04_StockBalance
{
    public long S03_ProductTypeId { get; set; }
    public int QuantityBalance { get; set; }
    public decimal SalingPrice { get; set; }
    public decimal Vat { get; set; }
    public decimal Sat { get; set; }
    public decimal OtherTaxes { get; set; }

}

public class SP_InsertUpdateCompanyLedger
{
    public int @ComLedgerID { get; set; }
    public int @C01_CompanyId { get; set; }
    public string @A01_AccheadCode { get; set; }
    public decimal @Cr { get; set; }
    public decimal @Dr { get; set; }
    public string @A02_LedgerType { get; set; }
    public long @RefID { get; set; }
    public string @U01_AddByUserId { get; set; }
    public string @Narration { get; set; }
}

public class SP_InsertUpdateVendorLedger
{
    public int @VendorLedgerID { get; set; }
    public int @M07_VendorId { get; set; }
    public string @A01_AccheadCode { get; set; }
    public decimal @Cr { get; set; }
    public decimal @Dr { get; set; }
    public string @A02_LedgerType { get; set; }
    public long @RefID { get; set; }
    public string @U01_AddByUserId { get; set; }
    public string @Narration { get; set; }

}

public class SP_InsertUpdatePatientLedger
{
    public int @PatientLedgerID { get; set; }
    public int @M07_PatientId { get; set; }
    public string @A01_AccheadCode { get; set; }
    public decimal @Cr { get; set; }
    public decimal @Dr { get; set; }
    public string @A02_LedgerType { get; set; }
    public long @RefID { get; set; }
    public string @U01_AddByUserId { get; set; }
    public string @Narration { get; set; }
}
public class ALLReciept
{
    public string M01_SellerCode { get; set; }
    public string VendorCode { get; set; }
    public string M01_SellerName { get; set; }
    public string VendorName { get; set; }
    public DateTime FromDate { get; set; }
    public DateTime ToDate { get; set; }
    public string InvoiceNo { get; set; }
    public int M10_TransTypeId { get; set; }
    public string custMobile { get; set; }


    public string PaidStatus { get; set; }

}


public class E01_Employee
{
    public int EmployeeID { get; set; }
    public int @M06_DesignationID { get; set; }
    public string RegistrationCode { get; set; }
    public int Title { get; set; }
    public string FirstName { get; set; }
    public string MiddleName { get; set; }
    public string LastName { get; set; }
    public DateTime DOB { get; set; }
    public DateTime DOJ { get; set; }
    public bool IsHusband { get; set; }
    public string HFName { get; set; }
    public char Gender { get; set; }
    public string EMail { get; set; }
    public string MobileNo { get; set; }
    public string Address { get; set; }
    public string Pincode { get; set; }
    public int CountryId { get; set; }
    public int @StateId { get; set; }
    public int @CityId { get; set; }
    public string Photo { get; set; }
    public int @IDProof { get; set; }
    public int @AddProof { get; set; }
    public string MaritalStatus { get; set; }
    public string PanNo { get; set; }
    public string Status { get; set; }
    public string DocNumber { get; set; }
    public string IdProofNumber { get; set; }
    public string BankName { get; set; }
    public string AccNo { get; set; }
    public string IFSCCode { get; set; }
    public decimal MaxDicountLimit { get; set; }
    public int BankID { get; set; }
    public string AlternateMobile { get; set; }
    public string ShoppeName { get; set; }
    public string Branch { get; set; }
    public int BranchiD { get; set; }
    public string password { get; set; }

}
public class U05_RoleForm
{
    public int U04_RoleID { get; set; }
    public int S02_FormID { get; set; }
    public int U01_FrId { get; set; }
    public bool Status { get; set; }
}
public class FormMaker
{

    public short FormID { get; set; }
    public short S01_MenuID { get; set; }
    public string FormName { get; set; }
    public string MenuName { get; set; }
    public string DisplayName { get; set; }
    public short OrderBy { get; set; }
    public string URL { get; set; }
}

public class S02_Form
{
    public short FormID { get; set; }
    public short S01_MenuID { get; set; }
    public string FormName { get; set; }
    public string DisplayName { get; set; }
    public short OrderBy { get; set; }
    public string URL { get; set; }
    public string Role { get; set; }

}

public class MenuMaker
{
    public short MenuId { get; set; }
    public string MenuName { get; set; }
    public short ParentId { get; set; }
    public string ParentName { get; set; }
    public string OrderBy { get; set; }
}

public class S07_RelatedProduct
{
    public int @MainProductID { get; set; }
    public int @RelatedProductID { get; set; }
    public bool IsDel { get; set; }
    public string IsAccessory { get; set; }
}
public class T06_OrderStatus
{
    public long OrderID { get; set; }
    public string Status { get; set; }
    public string Narration { get; set; }
    public long UserId { get; set; }

}
#endregion

#region BS01
public class M10_Bank
{
    public int BankId { get; set; }
    public string Bank { get; set; }
    public string BankCode { get; set; }
    public string Status { get; set; }
}
public class M04_City
{
    public int CountryId { get; set; }
    public int StateId { get; set; }
    public long CityId { get; set; }
    public string City { get; set; }
    public string Status { get; set; }
}


public class M10_State
{
    public int CountryId { get; set; }
    public int StateId { get; set; }
   
    public string @name { get; set; }
    public string Status { get; set; }
}

public class M17_TaxType
{
    public short TypeID { get; set; }
    public string Type { get; set; }
    

}



public class M15_Banner
{
    public int @ClientID { get; set; }
    public string @Adhar { get; set; }
    public string @Pan { get; set; }
    public string @Bank { get; set; }

}



public class Q04_Feedback
{
    public long @Q01_QuotationID { get; set; }
    public long @M08_CustomerID { get; set; }
    public string @Feedback { get; set; }
    public string @Status { get; set; }
}

public class ViewCart
{
    public long ProductSizeID { get; set; }
    public long ProductID { get; set; }
    public string ProductName { get; set; }
    public string Image { get; set; }
    public int QTY { get; set; }
    public long SpecificationID { get; set; }
    public string Specification { get; set; }
    public bool IsAccessory { get; set; }
    public string Accessory { get; set; }
    public short BrandID { get; set; }
    public decimal Price { get; set; }
}
public class M07_Photo
{
    public int PhotoId { get; set; }
    public string PhotoPath { get; set; }
    public bool IsDel { get; set; }
    public string @Status { get; set; }
    public long S03_ProductID { get; set; }
    public long M24_BrandID { get; set; }
    public bool IsPrimary { get; set; }

}

public class S03_Product
{
    public int ProductId { get; set; }
    public string Product { get; set; }
    public int S01_ProductTypeId { get; set; }
    public string Features { get; set; }
    public string Description { get; set; }
    public string Status { get; set; }
    public bool IsDel { get; set; }
    public decimal ProductCost { get; set; }
    public int MinimumQty { get; set; }
    public string @ProductCode { get; set; }
    public int U01_UserID { get; set; }
    public Decimal Discount { get; set; }
    public string @Accessory { get; set; }
    public long @SuperProductID { get; set; }
    public string @ProTypeCode { get; set; }
    public string @ProdCode { get; set; }
    public string @BussType { get; set; }

}

public class S04_ProductTechinalData
{
    public int ProductTechinalDataId { get; set; }
    public int S03_ProductId { get; set; }
    public int M06_TechinalDataId { get; set; }
    public string TechinalData { get; set; }
    public string Status { get; set; }
    public bool IsDel { get; set; }

}
public class S13_ProductSpecification
{
    public long S12_ProductSizeID { get; set; }
    public DateTime Entrydate { get; set; }
    public string Status { get; set; }
    public long S03_ProductID { get; set; }
    public long M23_SpecificationID { get; set; }

}







#endregion

#region BS06
public class M01_Member
{
    private int _MemberID;
    public int MemberID
    {
        get { return _MemberID; }
        set { _MemberID = value; }
    }
    public string RegistrationCode { get; set; }
    public short Title { get; set; }
    public string FName { get; set; }
    public string MName { get; set; }
    public string LName { get; set; }
    public DateTime DOB { get; set; }
    public DateTime DOJ { get; set; }
    public string FatherName { get; set; }
    public string Gender { get; set; }
    public string EMail { get; set; }
    public string MobileNo { get; set; }
    public string landLineNo { get; set; }
    public string Address { get; set; }
    public string Pincode { get; set; }
    public short StateId { get; set; }
    public short CityId { get; set; }
    public string NName { get; set; }
    public string NGender { get; set; }
    public string Relation { get; set; }
    public string PanCardNo { get; set; }
    public string MemberStatus { get; set; }
    public string AadharImg { get; set; }
    public string PANImg { get; set; }
    public string IFSC { get; set; }
    public string AccNo { get; set; }
    public short BankID { get; set; }
    public string BranchName { get; set; }
    public DateTime NDOB { get; set; }
    public long AddedById { get; set; }
    public long IntroducerID { get; set; }
    public int M05_PlanProductId { get; set; }
    public string UserImg { get; set; }
    public int M04_PlanId { get; set; }
    public string Password { get; set; }
    public string Leg { get; set; }
    public int ParentID { get; set; }
    public long PinID { get; set; }
    public bool IsTopUp { get; set; }
    public string AadharNo { get; set; }
    public string Paymode { get; set; }
    public string PaymentNo { get; set; }
    public long M01_TransferedById { get; set; }
    public decimal PackageAmt { get; set; }
}

public class M01_MemberPR
{
    private int _MemberID;
    public int MemberID
    {
        get { return _MemberID; }
        set { _MemberID = value; }
    }
    public string RegistrationCode { get; set; }
    public short Title { get; set; }
    public string FName { get; set; }
    public string MName { get; set; }
    public string LName { get; set; }
    public DateTime DOB { get; set; }
    public DateTime DOJ { get; set; }
    public string FatherName { get; set; }
    public string Gender { get; set; }
    public string EMail { get; set; }
    public string MobileNo { get; set; }
    public string landLineNo { get; set; }
    public string Address { get; set; }
    public string Pincode { get; set; }
    public short StateId { get; set; }
    public short CityId { get; set; }
    public string NName { get; set; }
    public string NGender { get; set; }
    public string Relation { get; set; }
    public string PanCardNo { get; set; }
    public string MemberStatus { get; set; }
    public string AadharImg { get; set; }
    public string PANImg { get; set; }
    public string IFSC { get; set; }
    public string AccNo { get; set; }
    public short BankID { get; set; }
    public string BranchName { get; set; }
    public DateTime NDOB { get; set; }
    public long AddedById { get; set; }
    public long IntroducerID { get; set; }
    public int M05_PlanProductId { get; set; }
    public string UserImg { get; set; }
    public int M04_PlanId { get; set; }
    public string Password { get; set; }
    public string Leg { get; set; }
    public int ParentID { get; set; }
    public long PinID { get; set; }
    public bool IsTopUp { get; set; }
    public string AadharNo { get; set; }
    public long M01_TransferedById { get; set; }
    public decimal PackageAmt { get; set; }
    public long M01_MemberRefId { get; set; }
}
#endregion
public class M14_CouponMaster
{
    public long CouponId { get; set; }
    public string CouponName { get; set; }
    public DateTime ValidFromDate { get; set; }
    public DateTime ValidTodate { get; set; }
    public decimal Price { get; set; }
    public decimal Discount { get; set; }
    public char Status { get; set; }
    public bool DelStatus { get; set; }
}
public class M29_MemberCoupon
{
    public long MemberCouponId { get; set; }
    public long M01_MemberId { get; set; }
    public long E01_EmployeeID { get; set; }
    public long M14_CouponId { get; set; }
    public char Status { get; set; }
    public bool DelStatus { get; set; }
}

public class M19_CustomerPdf
{
    public int CustomerPdfId { get; set; }
    public int M01_memberID { get; set; }
    public string Pdfpath { get; set; }
    public bool IsDel { get; set; }
    public string Remark { get; set; }

}
public class M30_RaftarProduct
{
    public int @RFID { get; set; }
    public int @S12_productSizeID { get; set; }
    public string @Code { get; set; }
    public bool @IsFirst { get; set; }

}
public class R01_Renewal
{
    public long RenewalId { get; set; }
    public long M01_MemberID { get; set; }
    public long U01_userID { get; set; }
}

public class T12_RaftarInstallment
{
    public int Installid { get; set; }
    public int M01_MemberID { get; set; }
    public int M31_NewLevelID { get; set; }
    public DateTime @ClosingDAte { get; set; }
}
public class GraphModel
{

    public string name { get; set; }
    public string children { get; set; }
}

public class Coupons
{
    public string @Coupon { get; set; }
    public int @MEmberID { get; set; }
    public decimal @Price { get; set; }
    public int @Count { get; set; }
    public int @AddBYID { get; set; }
 
}
public class Easebuzz
{
    public string salt = System.Configuration.ConfigurationSettings.AppSettings["UT4PWATATF"];
    public string Key = System.Configuration.ConfigurationSettings.AppSettings["K7MI260L4R"];

    public string env = "prod";
}

public class WriteLog
{
    public static void WriteLogs(string strLog)
    {
        StreamWriter log;
        FileStream fileStream = null;
        DirectoryInfo logDirInfo = null;
        FileInfo logFileInfo;

        string logFilePath = "D:\\Logs\\";
        logFilePath = logFilePath + "Logs-" + System.DateTime.Today.ToString("MM-dd-yyyy") + "." + "txt";
        logFileInfo = new FileInfo(logFilePath);
        logDirInfo = new DirectoryInfo(logFileInfo.DirectoryName);
        if (!logDirInfo.Exists) logDirInfo.Create();
        if (!logFileInfo.Exists)
        {
            fileStream = logFileInfo.Create();
        }
        else
        {
            fileStream = new FileStream(logFilePath, FileMode.Append);
        }
        log = new StreamWriter(fileStream);
        log.WriteLine(strLog);
        log.Close();

    }
}