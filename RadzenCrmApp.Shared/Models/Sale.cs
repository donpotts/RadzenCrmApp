using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace RadzenCrmApp.Shared.Models;

[DataContract]
public class Sale
{
    [Key]
    [DataMember]
    public long? Id { get; set; }

    [DataMember]
    public string? ProductId { get; set; }

    [DataMember]
    public string? ServiceId { get; set; }

    [DataMember]
    public long? CustomerId { get; set; }

    [DataMember]
    public long? Quantity { get; set; }

    [DataMember]
    public decimal? TotalAmount { get; set; }

    [DataMember]
    public DateTime? SaleDate { get; set; }

    [DataMember]
    public string? ReceiptPhoto { get; set; }

    [DataMember]
    public string? Notes { get; set; }
}
