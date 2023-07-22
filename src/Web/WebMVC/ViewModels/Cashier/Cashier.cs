namespace Microsoft.eShopOnContainers.WebMVC.ViewModels;

public class Cashier
{
    public List<CatalogItem> Data { get; init; }

    public string CashierName { get; set; }

    public string SessionID { get; set; }
}
