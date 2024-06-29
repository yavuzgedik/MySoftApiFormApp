using MySoftApiFormApp.Models;
using Newtonsoft.Json;
using RestSharp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MySoftApiFormApp
{
    public partial class Form1 : Form
    {
        string folderPath = @"C:\MySoft";
        string filePath = @"C:\MySoft\connection-info.json";
        public Form1()
        {
            InitializeComponent();

            #region LocalFileControl
            if (!Directory.Exists(folderPath))
            {
                try
                {
                    Directory.CreateDirectory(folderPath);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Klasör oluşturulurken hata oluştu: " + ex.Message);
                }
            }

            if (File.Exists(filePath))
            {

            }
            else
            {
                string jsonData = "";
                File.WriteAllText(filePath, jsonData);
            }
            #endregion
        }

        private void btnTokenControl_Click(object sender, EventArgs e)
        {
            var str = MySoftOperations.GetAccessToken();
        }

        private void btnEarchiveCreate_Click(object sender, EventArgs e)
        {
            var jsonData = new MySoftEdocument
            {
                isCalculateByApi = true,
                id = "2",
                connectorGuid = "3ADEFE96-9B5E-498A-B744-3DF27D574731",
                eDocumentType = "EFATURA",
                profile = "TEMELFATURA",
                invoiceType = "SATIS",
                ettn = "3ADEFE96-9B5E-498A-B744-3DF27D574731",
                prefix = "MYF",
                numeratorSetCode = "string",
                xsltSetCode = "string",
                docNo = "2025000000000035",
                docDate = DateTime.UtcNow.ToString("MM/dd/yyyy HH:mm:ss"),
                docTime = DateTime.UtcNow.ToString("HH:mm:ss"),
                periodStartDate = DateTime.UtcNow.ToString("MM/dd/yyyy"),
                periodStartTime = DateTime.UtcNow.ToString("HH:mm:ss"),
                periodEndDate = DateTime.Now,
                periodEndTime = DateTime.UtcNow.ToString("HH:mm:ss"),
                periodDescription = "string",
                additionalInvoiceInfo = new AdditionalInvoiceInfo
                {
                    accountingCostType = "string",
                    taxPayerCode = "string",
                    taxPayerName = "string",
                    documentNumber = "string"
                },
                currencyCode = "TRY",
                currencyRate = 1,
                senderType = "ELEKTRONIK",
                orderNo = "SDS95655989289",
                orderDate = DateTime.UtcNow.ToString("MM/dd/yyyy HH:mm:ss"),
                waybillInfo = new List<WaybillInfo>
                {
                    new WaybillInfo 
                    { 
                        waybillNo = "SDS95655989289", 
                        waybillDate = DateTime.UtcNow.ToString("MM/dd/yyyy HH:mm:ss") 
                    }
                },
                billingRefInvoiceNo = "SDS95655989289",
                billingRefInvoiceDate = DateTime.UtcNow.ToString("MM/dd/yyyy HH:mm:ss"),
                billingRefNote = "İstenilen stok gönderilmedi",
                notes = new List<Note>
                {
                    new Note { note = "https://mysoft.com.tr" }
                },
                pkAlias = "urn:mail:defaultpk@ornekadres.com",
                gbAlias = "urn:mail:defaultgb@ornekadres.com",
                deliveryTermCode = "string",
                transportModeCode = "string",
                deliveryCitySubdivisionName = "string",
                deliveryCity = "string",
                deliveryCountry = "string",
                cargoAccountName = "string",
                cargoNumber = "string",
                isSendWithGeneralXsltIfDefaultNotExists = true,
                xsltName = "string",
                //tenantIdentifierNumber = "string",
                supplierPartyIdentifer = new SupplierPartyIdentifer
                {
                    customerNo = "string",
                    retailerNo = "string",
                    subscriberNo = "string"
                },
                publicServicePayeeVKN = "string",
                publicServicePayeePartyName = "string",
                publicServicePayeeCountry = "string",
                publicServicePayeeCity = "string",
                publicServicePayeeCitysubdivision = "string",
                supplierAgentAccount = new SupplierAgentAccount
                {
                    agentAccountName = "string",
                    agentNumber = "string",
                    city = new City { name = "string" },
                    country = new Country { code = "string", name = "string" },
                    citySubdivision = "Davutpaşa",
                    telephone1 = "+902129010212",
                    email1 = "info@mysoft.com.tr",
                    fax1 = "+902129010212",
                    postalCode = "34220",
                    room = "212",
                    streetName = "Eski Londra Asfaltı Caddesi",
                    blockName = "A1",
                    buildingName = "Teknopark",
                    buildingNumber = "24",
                    region = "YTÜ Davutpaşa Kampüsü Teknoloji Gelşt. Bölgesi",
                    district = "Çifte Havuzlar Mahallesi"
                },
                isNotControlSchemaSchematron = true,
                isThrowExceptionOnEDocumentTypeChange = true,
                folderName = "string",
                insuranceValueAmount = 0,
                declaredForCarriageValueAmount = 0,
                freeOnBoardValueAmount = 0,
                isSaveAsDraft = true,
                referanceKey = "string",
                paymentMeans = new List<PaymentMean>
                {
                    new PaymentMean
                    {
                        paymentMeansCode = "string",
                        paymentChannelCode = "string",
                        payeeFinancialAccount = new PayeeFinancialAccount
                        {
                            currencyCode = "string",
                            iD = "string",
                            paymentNote = "string"
                        },
                        payerFinancialAccount = new PayerFinancialAccount
                        {
                            currencyCode = "string",
                            iD = "string",
                            paymentNote = "string"
                        }
                    }
                },
                invoiceAccount = new InvoiceAccount
                {
                    vknTckn = "5555553431",
                    accountName = "YAVUZ Mysoft Dijital Dönüşüm A.Ş",
                    taxOfficeName = "Tokat Vergi Dairesi",
                    countryName = "TÜRKİYE",
                    cityName = "TOKAT",
                    room = "212",
                    streetName = "Eski Londra Asfaltı Caddesi",
                    blockName = "A1",
                    buildingName = "Teknopark",
                    buildingNumber = "24",
                    citySubdivision = "Davutpaşa",
                    postalCode = "34220",
                    region = "YTÜ Davutpaşa Kampüsü Teknoloji Gelşt. Bölgesi",
                    district = "Çifte Havuzlar Mahallesi",
                    telephone1 = "+902129010212",
                    fax1 = "+902129010212",
                    email1 = "info@mysoft.com.tr",
                    webSiteUrl = "https://www.mysoft.com.tr/",
                    supplierCode = "string",
                    personInfo = new PersonInfo
                    {
                        firstName = "string",
                        familyName = "string",
                        title = "string",
                        middleName = "string",
                        nameSuffix = "string"
                    },
                    vehicleInfo = new VehicleInfo
                    {
                        licencePlate = "string",
                        vehicleNumber = "string"
                    }
                },
                tax = new List<Tax>
                {
                    new Tax
                    {
                        taxAmount = 0,
                        taxSubTotal = new List<TaxSubTotal>
                        {
                            new TaxSubTotal
                            {
                                taxableAmount = 0,
                                taxAmount = 0,
                                calculationSequenceNumeric = 0,
                                percent = 18,
                                taxName = "Özel İletişim Vergisi",
                                taxTypeCode = "103",
                                taxExemptionReasonCode = "103",
                                taxExemptionReasonName = "Askeri Amaçlı İstisna"
                            }
                        }
                    }
                },
                withholdingTax = new List<WithholdingTax>
                {
                    new WithholdingTax
                    {
                        taxAmount = 0,
                        taxSubTotal = new List<TaxSubTotal>
                        {
                            new TaxSubTotal
                            {
                                taxableAmount = 0,
                                taxAmount = 0,
                                calculationSequenceNumeric = 0,
                                percent = 18,
                                taxName = "Özel İletişim Vergisi",
                                taxTypeCode = "103",
                                taxExemptionReasonCode = "103",
                                taxExemptionReasonName = "Askeri Amaçlı İstisna"
                            }
                        }
                    }
                },
                allowanceCharge = new List<AllowanceCharge>
                {
                    new AllowanceCharge
                    {
                        chargeIndicator = true,
                        allowanceChargeReason = "string",
                        multiplierFactorNumeric = 0,
                        sequenceNumeric = 0,
                        amount = 0,
                        baseAmount = 0
                    }
                },
                internetShipmentInfo = new InternetShipmentInfo
                {
                    webSiteUrl = "https://mysoft.com.tr",
                    paymentType = "KREDIKARTI/BANKAKARTI",
                    internetAccountName = "mysoft",
                    paymentDate = DateTime.UtcNow.ToString("MM/dd/yyyy HH:mm:ss"),
                    paymentNote = "Kredi kartı",
                    shippingDate = DateTime.UtcNow.ToString("MM/dd/yyyy HH:mm:ss"),
                    shippingAccountName = "MYSOFT",
                    shippingAccountVknTckn = "11111111111"
                },
                isManuelCalculation = true,
                invoiceCalculation = new InvoiceCalculation
                {
                    lineExtensionAmount = 0,
                    taxExclusiveAmount = 0,
                    taxInclusiveAmount = 0,
                    payableRoundingAmount = 0,
                    payableAmount = 0,
                    allowanceTotalAmount = 0,
                    chargeTotalAmount = 0
                },
                additionalDocumentRef = new List<AdditionalDocumentRef>
                {
                    new AdditionalDocumentRef
                    {
                        id = "string",
                        issueDate = "string",
                        documentType = "string",
                        documentDescription = new List<string> { "string" },
                        //attachment = new Attachment
                        //{
                        //    embeddedDocumentBinaryObject = "string",
                        //    uri = "string",
                        //    mimeCode = "string",
                        //    format = "string",
                        //    encodingCode = "string",
                        //    characterSetCode = "string",
                        //    filename = "string",
                        //    description = "string"
                        //}
                    }
                },
                esuReportInfo = new EsuReportInfo
                {
                    eSUReportId = "string",
                    eSUReportDate = DateTime.Now,
                },
                invoiceDetail = new List<InvoiceDetail>
                {
                    new InvoiceDetail
                    {
                        productCode = "123678",
                        productName = "123678",
                        buyerProductCode = "string",
                        manufacturerProductCode = "string",
                        brandName = "string",
                        modelName = "string",
                        unitCode = "C62",
                        currencyCode = "string",
                        qty = 10,
                        unitPriceTra = 56,
                        amtTra = 560,
                        vatRate = 18,
                        amtVatTra = 0.50,
                        taxableAmtTra = 0,
                        note = "Stoğa yüzde 18 KDV uygulandı",
                        gtip = "string",
                        taxExemptionReasonCode = "103",
                        taxExemptionReasonName = "Askeri Amaçlı İstisna",
                        withholdingTaxTypeCode = "604",
                        withholdingTaxTypeName = "604 Stopaj Vergisi",
                        withholdingTaxPercentage = 5.60,
                        withholdingTaxableAmount = 0,
                        withholdingTaxAmount = 0,
                        hksTagNumber = "string",
                        hksOwnerFullName = "string",
                        hksOwnerIdentifier = "string",
                        isSubtractDiscountFromAmtTra = true,
                        tax = new List<Tax>
                        {
                            new Tax
                            {
                                taxName = "Özel İletişim Vergisi",
                                taxCode = "103",
                                taxRate = 18,
                                taxAmount = 0,
                                taxableAmount = 0,
                                taxExemptionReasonCode = "103",
                                taxExemptionReasonName = "Askeri Amaçlı İstisna"
                            }
                        },
                        allowanceCharge = new List<AllowanceCharge>
                        {
                            new AllowanceCharge
                            {
                                chargeIndicator = true,
                                allowanceChargeReason = "string",
                                multiplierFactorNumeric = 0,
                                sequenceNumeric = 0,
                                amount = 0,
                                baseAmount = 0
                            }
                        },
                        itemInstance = new List<ItemInstance>
                        {
                            new ItemInstance
                            {
                                serialId = "string",
                                productTraceId = "string"
                            }
                        },
                        shipment = new Shipment
                        {
                            cargoNo = "string",
                            packageNumber = "string",
                            packageType = "string",
                            packageQty = 0,
                            packageBrand = "string",
                            netQty = 0,
                            crossQty = 0,
                            originCountryCode = "string",
                            originCountryName = "string"
                        }
                    }
                }
            };

            string json = JsonConvert.SerializeObject(jsonData, Formatting.Indented);

            var token = MySoftOperations.GetAccessToken();

            var client = new RestClient("https://edocumentapitest.mysoft.com.tr/api/InvoiceOutbox/invoiceOutbox");
            client.Timeout = -1;

            var request = new RestRequest(Method.POST);
            request.AddHeader("Authorization", "Bearer " + token);
            request.AddHeader("Content-Type", "application/json");
            request.AddParameter("application/json", json, ParameterType.RequestBody);

            IRestResponse response = client.Execute(request);

            Console.WriteLine(response.Content);
        }
    }
}
