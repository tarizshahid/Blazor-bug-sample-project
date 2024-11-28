using System;
using System.Collections.Generic;

namespace Globe.Models;

public class Publisher
{
    public short PubId { get; set; }

    public string PubCode { get; set; } = null!;

    public string? PubName { get; set; }

    public string? PubImportZip { get; set; }

    public string? PubImportZipO { get; set; }

    public DateTime? Lupd { get; set; }

    public DateTime? LastUpdate { get; set; }

    public int? QtyId { get; set; }

    public int? RunDiff { get; set; }

    public string? PubSrcName { get; set; }

    public DateTime? PubSrcDate { get; set; }

    public int? PubPartialUpdate { get; set; }

    public int? AutoComplete { get; set; }

    public int? EdiFormat { get; set; }

    public int? MinOrderWarning { get; set; }

    public int? GotUpdate { get; set; }

    public bool BackOrders { get; set; }

    public bool UseCodeInDescr { get; set; }

    public int? TrId { get; set; }

    public int? SpecialPr { get; set; }

    public int? MaxOrderLines { get; set; }

    public DateTime? Updstart { get; set; }

    public string? Brand { get; set; }

    public string? ErrorAddr { get; set; }

    public string? ErrorFromAddr { get; set; }

    public string? ErrorAddr1 { get; set; }

    public string? UpdateFname { get; set; }

    public int? UpdateIndex { get; set; }

    public int? IsGroupMember { get; set; }

    public int? IsActive { get; set; }

    public int? Code25 { get; set; }

    public bool AlwaysShowZeroStock { get; set; }

    public bool? Autolink { get; set; }

    public bool? UpdateInProgress { get; set; }

    public bool? Gotupdate2 { get; set; }

    public string? WebStylesheet { get; set; }

    public string? WebHostName { get; set; }

    public string? DefaultCurrencySymbol { get; set; }

    public int? OrderReferenceSizeLimit { get; set; }

    public string? WebSiteBrandName { get; set; }

    public string? ConsumablesGroup { get; set; }

    public bool DoesDeliverySchedule { get; set; }

    public DateTime LastDataUpdate { get; set; }

    public bool? WebHideZeroPrice { get; set; }

    public bool WebAllowsDvla { get; set; }

    public Guid WebId { get; set; }

    public bool AcceptsConsumerDetails { get; set; }

    public string? WebHostNames { get; set; }

    public short? UpdateRetry { get; set; }

    public bool HasDueInQty { get; set; }

    public bool HasKeepAlive { get; set; }

    public bool SortByQty { get; set; }

    public bool AllowQuotation { get; set; }

    public bool HideEnquiryTyreTab { get; set; }

    public bool HideEnquiryCodeTab { get; set; }

    public bool HideEnquirySpecialsTab { get; set; }

    public bool HideEnquiryFavouritesTab { get; set; }

    public int EnquiryCodeSearchMinimumCharacters { get; set; }

    public bool EnquiryCodeExactSearch { get; set; }

    public bool ShowStockCodeByDefault { get; set; }

    public bool? HasMultiPricelist { get; set; }

    public string? OpenFireIp { get; set; }

    public int? OpenFirePort { get; set; }

    public bool? HasFailedOrderHandler { get; set; }

    public string? OpenFireDomain { get; set; }

    public int DaysToKeepAuditLog { get; set; }

    public bool HasNewObjects { get; set; }

    public bool? InIsolation { get; set; }

    public int DefaultDvlaaccessLevel { get; set; }

    public bool UseOtcCatalogueRef { get; set; }

    public bool HasClientSpeedLog { get; set; }

    public bool OrderUsingSupplierRef { get; set; }

    public bool AllowTradeListUpload { get; set; }

    public int QuantityMaxDisplay { get; set; }

    public bool AllowStyleSheetEdit { get; set; }

    public bool HasB2c { get; set; }

    public bool CanPrintEnquiryGrid { get; set; }

    public bool AllowEnquiryGridCopyToClipboard { get; set; }

    public bool? CanAutoPopulateImpress { get; set; }

    public bool RedirectToHost { get; set; }

    public bool ZeroPriceOnReset { get; set; }

    public int MinWebsiteVersion { get; set; }

    public bool AllowDuplicateCodeEdits { get; set; }

    public bool HideExcludePlItems { get; set; }

    public string? ImpressedStockLabel { get; set; }

    public bool HasReplyService { get; set; }

    public bool OrderUsingBarcode { get; set; }

    public bool ImpressStockCheckEnabled { get; set; }

    public bool HalfordsImpressStockEnabled { get; set; }

    public bool ShowNegativeStock { get; set; }

    public int DefaultProductsSearchResultsSortOrder { get; set; }

    public int DefaultSpecialsSearchResultsSortOrder { get; set; }

    public bool HideMidasgroups { get; set; }

    public bool HideSeasongroups { get; set; }

    public bool MasterGroupFilter { get; set; }

    public string? WebsiteLogo { get; set; }

    public bool CanSearchAlt { get; set; }

    public bool SeperateSeasongroups { get; set; }

    public bool HasIntercomChat { get; set; }

    public string? IntercomAppId { get; set; }

    public string? RetailWebsiteEmailAddress { get; set; }

    public string? RetailWebsiteEmailPassword { get; set; }

    public byte DeviceApprovalType { get; set; }

    public bool CanPayOrder { get; set; }

    public bool CanPayAccount { get; set; }

    public string? CcmerchantId { get; set; }

    public string? CcaccountId { get; set; }

    public string? Ccsecret { get; set; }

    public int PasswordValidDuration { get; set; }

    public bool HasDeliveryEstimate { get; set; }

    public string? DeviceApproverEmail { get; set; }

    public bool AutoApproveDevice { get; set; }

    public string? CcpayAccountType { get; set; }

    public bool LogElavonTransactions { get; set; }

    public bool IncludeRegNum { get; set; }

    public string? TransactionEmail { get; set; }

    public bool OrderUsingBuyersArticleId { get; set; }

    public bool? CardStorage { get; set; }

    public string? DeliveryUrl { get; set; }

    public string? DeliveryUsername { get; set; }

    public string? DeliveryPassword { get; set; }

    public int? PaymentProviderId { get; set; }

    public bool? ShowStockProfileQtyReport { get; set; }

    public bool? UseLongProductDescription { get; set; }

    public string? CommentSepChar { get; set; }

    public bool? ShowSearchWarehouse { get; set; }

    //public virtual ICollection<Site> Sites { get; set; } = new List<Site>();
}
