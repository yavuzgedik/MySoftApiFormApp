using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MySoftApiFormApp.Models
{
    public class MySoftEdocument
    {
        public bool isCalculateByApi { get; set; }
        public string id { get; set; }
        public string connectorGuid { get; set; }
        public string eDocumentType { get; set; }
        public string profile { get; set; }
        public string invoiceType { get; set; }
        public string ettn { get; set; }
        public string prefix { get; set; }
        public string numeratorSetCode { get; set; }
        public string xsltSetCode { get; set; }
        public string docNo { get; set; }
        public string docDate { get; set; }
        public string docTime { get; set; }
        public string periodStartDate { get; set; }
        public string periodStartTime { get; set; }
        public DateTime periodEndDate { get; set; }
        public string periodEndTime { get; set; }
        public string periodDescription { get; set; }
        public AdditionalInvoiceInfo additionalInvoiceInfo { get; set; }
        public string currencyCode { get; set; }
        public double currencyRate { get; set; }
        public string senderType { get; set; }
        public string orderNo { get; set; }
        public string orderDate { get; set; }
        public List<WaybillInfo> waybillInfo { get; set; }
        public string billingRefInvoiceNo { get; set; }
        public string billingRefInvoiceDate { get; set; }
        public string billingRefNote { get; set; }
        public List<Note> notes { get; set; }
        public string pkAlias { get; set; }
        public string gbAlias { get; set; }
        public string deliveryTermCode { get; set; }
        public string transportModeCode { get; set; }
        public string deliveryCitySubdivisionName { get; set; }
        public string deliveryCity { get; set; }
        public string deliveryCountry { get; set; }
        public string cargoAccountName { get; set; }
        public string cargoNumber { get; set; }
        public bool isSendWithGeneralXsltIfDefaultNotExists { get; set; }
        public string xsltName { get; set; }
        public string tenantIdentifierNumber { get; set; }
        public SupplierPartyIdentifer supplierPartyIdentifer { get; set; }
        public string publicServicePayeeVKN { get; set; }
        public string publicServicePayeePartyName { get; set; }
        public string publicServicePayeeCountry { get; set; }
        public string publicServicePayeeCity { get; set; }
        public string publicServicePayeeCitysubdivision { get; set; }
        public SupplierAgentAccount supplierAgentAccount { get; set; }
        public bool isNotControlSchemaSchematron { get; set; }
        public bool isThrowExceptionOnEDocumentTypeChange { get; set; }
        public string folderName { get; set; }
        public double insuranceValueAmount { get; set; }
        public double declaredForCarriageValueAmount { get; set; }
        public double freeOnBoardValueAmount { get; set; }
        public bool isSaveAsDraft { get; set; }
        public string referanceKey { get; set; }
        public List<PaymentMean> paymentMeans { get; set; }
        public InvoiceAccount invoiceAccount { get; set; }
        public List<Tax> tax { get; set; }
        public List<WithholdingTax> withholdingTax { get; set; }
        public List<AllowanceCharge> allowanceCharge { get; set; }
        public InternetShipmentInfo internetShipmentInfo { get; set; }
        public bool isManuelCalculation { get; set; }
        public InvoiceCalculation invoiceCalculation { get; set; }
        public List<AdditionalDocumentRef> additionalDocumentRef { get; set; }
        public EsuReportInfo esuReportInfo { get; set; }
        public List<InvoiceDetail> invoiceDetail { get; set; }
    }

    public class AdditionalDocumentRef
    {
        public string id { get; set; }
        public string issueDate { get; set; }
        public string documentType { get; set; }
        public List<string> documentDescription { get; set; }
        public Attachment attachment { get; set; }
    }

    public class AdditionalInvoiceInfo
    {
        public string accountingCostType { get; set; }
        public string taxPayerCode { get; set; }
        public string taxPayerName { get; set; }
        public string documentNumber { get; set; }
    }

    public class AllowanceCharge
    {
        public bool chargeIndicator { get; set; }
        public string allowanceChargeReason { get; set; }
        public double multiplierFactorNumeric { get; set; }
        public double sequenceNumeric { get; set; }
        public double amount { get; set; }
        public double baseAmount { get; set; }
    }

    public class Attachment
    {
        public string characterSetCode { get; set; }
        public string encodingCode { get; set; }
        public string filename { get; set; }
        public string mimeCode { get; set; }
        public string attachmentFile { get; set; }
    }

    public class City
    {
        public string name { get; set; }
    }

    public class Country
    {
        public string code { get; set; }
        public string name { get; set; }
    }

    public class EsuReportInfo
    {
        public string eSUReportId { get; set; }
        public DateTime eSUReportDate { get; set; }
    }

    public class InternetShipmentInfo
    {
        public string webSiteUrl { get; set; }
        public string paymentType { get; set; }
        public string internetAccountName { get; set; }
        public string paymentDate { get; set; }
        public string paymentNote { get; set; }
        public string shippingDate { get; set; }
        public string shippingAccountName { get; set; }
        public string shippingAccountVknTckn { get; set; }
    }

    public class InvoiceAccount
    {
        public string vknTckn { get; set; }
        public string accountName { get; set; }
        public string taxOfficeName { get; set; }
        public string countryName { get; set; }
        public string cityName { get; set; }
        public string room { get; set; }
        public string streetName { get; set; }
        public string blockName { get; set; }
        public string buildingName { get; set; }
        public string buildingNumber { get; set; }
        public string citySubdivision { get; set; }
        public string postalCode { get; set; }
        public string region { get; set; }
        public string district { get; set; }
        public string telephone1 { get; set; }
        public string fax1 { get; set; }
        public string email1 { get; set; }
        public string webSiteUrl { get; set; }
        public string supplierCode { get; set; }
        public PersonInfo personInfo { get; set; }
        public VehicleInfo vehicleInfo { get; set; }
    }

    public class InvoiceCalculation
    {
        public double lineExtensionAmount { get; set; }
        public double taxExclusiveAmount { get; set; }
        public double taxInclusiveAmount { get; set; }
        public double payableRoundingAmount { get; set; }
        public double payableAmount { get; set; }
        public double allowanceTotalAmount { get; set; }
        public double chargeTotalAmount { get; set; }
    }

    public class InvoiceDetail
    {
        public string productCode { get; set; }
        public string productName { get; set; }
        public string buyerProductCode { get; set; }
        public string manufacturerProductCode { get; set; }
        public string brandName { get; set; }
        public string modelName { get; set; }
        public string unitCode { get; set; }
        public string currencyCode { get; set; }
        public double qty { get; set; }
        public double unitPriceTra { get; set; }
        public double amtTra { get; set; }
        public double vatRate { get; set; }
        public double amtVatTra { get; set; }
        public double taxableAmtTra { get; set; }
        public string note { get; set; }
        public string gtip { get; set; }
        public string taxExemptionReasonCode { get; set; }
        public string taxExemptionReasonName { get; set; }
        public string withholdingTaxTypeCode { get; set; }
        public string withholdingTaxTypeName { get; set; }
        public double withholdingTaxPercentage { get; set; }
        public double withholdingTaxableAmount { get; set; }
        public double withholdingTaxAmount { get; set; }
        public string hksTagNumber { get; set; }
        public string hksOwnerFullName { get; set; }
        public string hksOwnerIdentifier { get; set; }
        public bool isSubtractDiscountFromAmtTra { get; set; }
        public List<Tax> tax { get; set; }
        public List<AllowanceCharge> allowanceCharge { get; set; }
        public List<ItemInstance> itemInstance { get; set; }
        public Shipment shipment { get; set; }
    }

    public class ItemInstance
    {
        public string serialId { get; set; }
        public string productTraceId { get; set; }
    }

    public class Note
    {
        public string note { get; set; }
    }

    public class PayeeFinancialAccount
    {
        public string currencyCode { get; set; }
        public string iD { get; set; }
        public string paymentNote { get; set; }
    }

    public class PayerFinancialAccount
    {
        public string currencyCode { get; set; }
        public string iD { get; set; }
        public string paymentNote { get; set; }
    }

    public class PaymentMean
    {
        public string paymentMeansCode { get; set; }
        public string paymentChannelCode { get; set; }
        public PayeeFinancialAccount payeeFinancialAccount { get; set; }
        public PayerFinancialAccount payerFinancialAccount { get; set; }
    }

    public class PersonInfo
    {
        public string firstName { get; set; }
        public string familyName { get; set; }
        public string title { get; set; }
        public string middleName { get; set; }
        public string nameSuffix { get; set; }
    }

    public class Shipment
    {
        public string cargoNo { get; set; }
        public string packageNumber { get; set; }
        public string packageType { get; set; }
        public int packageQty { get; set; }
        public string packageBrand { get; set; }
        public double netQty { get; set; }
        public double crossQty { get; set; }
        public string originCountryCode { get; set; }
        public string originCountryName { get; set; }
    }

    public class SupplierAgentAccount
    {
        public string agentAccountName { get; set; }
        public string agentNumber { get; set; }
        public City city { get; set; }
        public Country country { get; set; }
        public string citySubdivision { get; set; }
        public string telephone1 { get; set; }
        public string email1 { get; set; }
        public string fax1 { get; set; }
        public string postalCode { get; set; }
        public string room { get; set; }
        public string streetName { get; set; }
        public string blockName { get; set; }
        public string buildingName { get; set; }
        public string buildingNumber { get; set; }
        public string region { get; set; }
        public string district { get; set; }
    }

    public class SupplierPartyIdentifer
    {
        public string customerNo { get; set; }
        public string retailerNo { get; set; }
        public string subscriberNo { get; set; }
    }

    public class Tax
    {
        public double taxAmount { get; set; }
        public List<TaxSubTotal> taxSubTotal { get; set; }
        public string taxName { get; set; }
        public string taxCode { get; set; }
        public double taxRate { get; set; }
        public double taxableAmount { get; set; }
        public string taxExemptionReasonCode { get; set; }
        public string taxExemptionReasonName { get; set; }
    }

    public class TaxSubTotal
    {
        public double taxableAmount { get; set; }
        public double taxAmount { get; set; }
        public double calculationSequenceNumeric { get; set; }
        public double percent { get; set; }
        public string taxName { get; set; }
        public string taxTypeCode { get; set; }
        public string taxExemptionReasonCode { get; set; }
        public string taxExemptionReasonName { get; set; }
    }

    public class VehicleInfo
    {
        public string licencePlate { get; set; }
        public string vehicleNumber { get; set; }
    }

    public class WaybillInfo
    {
        public string waybillNo { get; set; }
        public string waybillDate { get; set; }
    }

    public class WithholdingTax
    {
        public double taxAmount { get; set; }
        public List<TaxSubTotal> taxSubTotal { get; set; }
    }


}
