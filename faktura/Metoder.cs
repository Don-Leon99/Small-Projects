// Metoder för faktura generering:
namespace Faktura;

public class Order
{
    public string ProductName;
    public decimal UnitPrice;
    public int Quantity;
    public decimal VAT;

    public decimal GetSubTotal() => UnitPrice * Quantity;
    public decimal GetTaxAmount() => GetSubTotal() * VAT;
    public decimal GetTotal() => GetSubTotal() + VAT;
}

public class Customer
{
    public string CustomerID;
    public string CustomerName;
    public string CustomerAdress;
    public string CustomerEmail;
    public string CustomerPhoneNumber;
}

public class Company
{
    public string InvoiceName;
    public string CompanyName;
    public string CompanyAdress;
    public string CompanyEmail;
    public string CompanyPhoneNumber;
    public string VATNumber;
}

public class Invoice
{
    public string InvoiceNumber;
    public DateTime InvoiceDate = DateTime.Now;
    public DateTime InvoiceDueDate = DateTime.Now.AddDays(30);
    public string PaymentMethod;

    public List<Order> items = new List<Order>();

    public decimal CalculateSubTotal() => 
    public decimal CalculateTotalTax() => 
    public decimal CalculateGrandTotal() => 

    public void PrintInvoice()
    {

    }
}