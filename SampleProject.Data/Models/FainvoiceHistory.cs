using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SampleProject.Data.Models;

[Table("FAInvoiceHistorys")]
[Microsoft.EntityFrameworkCore.Index("FainvoiceHistoryDate", Name = "Idx_FAInvoiceHistorys")]
public partial class FainvoiceHistory
{
    [Key]
    [Column("FAInvoiceHistoryID")]
    public int FainvoiceHistoryId { get; set; }

    [Column("AANumberString")]
    [StringLength(50)]
    [Unicode(false)]
    public string AanumberString { get; set; }

    [Column("AANumberInt")]
    public int? AanumberInt { get; set; }

    [Column("AAStat")]
    [StringLength(10)]
    [Unicode(false)]
    public string Aastat { get; set; }

    [Column("FAInvoiceID")]
    public int? FainvoiceId { get; set; }

    [Column("FACustomerID")]
    public int? FacustomerId { get; set; }

    [Column("FAUserID")]
    public int? FauserId { get; set; }

    [Column("FAUserName")]
    [StringLength(50)]
    public string FauserName { get; set; }

    [Column("FAInvoiceHistoryDate", TypeName = "datetime")]
    public DateTime? FainvoiceHistoryDate { get; set; }

    [Column("FAInvoiceHistoryAction")]
    [StringLength(50)]
    public string FainvoiceHistoryAction { get; set; }

    [Column("FAInvoiceHistoryRelate")]
    [StringLength(50)]
    public string FainvoiceHistoryRelate { get; set; }

    [Column("FAInvoiceHistoryRelateID")]
    public int? FainvoiceHistoryRelateId { get; set; }

    [Column("FAInvoiceHistoryInfo")]
    [StringLength(100)]
    public string FainvoiceHistoryInfo { get; set; }

    [Column("FAInvoiceHistoryComment")]
    [StringLength(200)]
    public string FainvoiceHistoryComment { get; set; }

    [ForeignKey("FacustomerId")]
    [InverseProperty("FainvoiceHistories")]
    public virtual Arcustomer Facustomer { get; set; }

    [ForeignKey("FainvoiceId")]
    [InverseProperty("FainvoiceHistories")]
    public virtual Arinvoice Fainvoice { get; set; }

    [ForeignKey("FauserId")]
    [InverseProperty("FainvoiceHistories")]
    public virtual Aduser Fauser { get; set; }
}
