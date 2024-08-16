using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SampleProject.Data.Models;

[Table("GEShippingMethods")]
[Microsoft.EntityFrameworkCore.Index("GeshippingMethodNo", Name = "Idx_GEShippingMethods")]
public partial class GeshippingMethod
{
    [Key]
    [Column("GEShippingMethodID")]
    public int GeshippingMethodId { get; set; }

    [Column("GEShippingMethodNo")]
    [StringLength(50)]
    public string GeshippingMethodNo { get; set; }

    [Required]
    [Column("GEShippingMethodName")]
    [StringLength(50)]
    public string GeshippingMethodName { get; set; }

    [Column("AAStatus")]
    [StringLength(10)]
    [Unicode(false)]
    public string Aastatus { get; set; }

    [Column("GEShippingFees", TypeName = "decimal(18, 5)")]
    public decimal? GeshippingFees { get; set; }

    [Column("GEShippingExtraFees", TypeName = "decimal(18, 5)")]
    public decimal? GeshippingExtraFees { get; set; }

    [Column("GEShippingInsuranceFees", TypeName = "decimal(18, 5)")]
    public decimal? GeshippingInsuranceFees { get; set; }

    [Column("GEShippingPackagingFees", TypeName = "decimal(18, 5)")]
    public decimal? GeshippingPackagingFees { get; set; }

    [Column("GEShippingReservedFees1", TypeName = "decimal(18, 5)")]
    public decimal? GeshippingReservedFees1 { get; set; }

    [Column("GEShippingReservedFees2", TypeName = "decimal(18, 5)")]
    public decimal? GeshippingReservedFees2 { get; set; }

    [Column("GEShippingReservedFees3", TypeName = "decimal(18, 5)")]
    public decimal? GeshippingReservedFees3 { get; set; }

    [Column("GEShippingReservedFees4", TypeName = "decimal(18, 5)")]
    public decimal? GeshippingReservedFees4 { get; set; }

    [Column("GEShippingMethodDesc")]
    [StringLength(255)]
    public string GeshippingMethodDesc { get; set; }

    [Required]
    [Column("GEShippingMethodActiveCheck")]
    public bool? GeshippingMethodActiveCheck { get; set; }

    [InverseProperty("FkGeshippingMethod")]
    public virtual ICollection<ApinvoiceIn> ApinvoiceIns { get; set; } = new List<ApinvoiceIn>();

    [InverseProperty("FkGeshippingMethod")]
    public virtual ICollection<ApopenDocument> ApopenDocuments { get; set; } = new List<ApopenDocument>();

    [InverseProperty("FkGeshippingMethod")]
    public virtual ICollection<AppurchaseOrder> AppurchaseOrders { get; set; } = new List<AppurchaseOrder>();

    [InverseProperty("FkGeshippingMethod")]
    public virtual ICollection<ApreturnSupplier> ApreturnSuppliers { get; set; } = new List<ApreturnSupplier>();

    [InverseProperty("FkGeshippingMethod")]
    public virtual ICollection<Apsupplier> Apsuppliers { get; set; } = new List<Apsupplier>();

    [InverseProperty("FkGeshippingMethod")]
    public virtual ICollection<Arestimate> Arestimates { get; set; } = new List<Arestimate>();

    [InverseProperty("FkGeshippingMethod")]
    public virtual ICollection<Arproposal> Arproposals { get; set; } = new List<Arproposal>();

    [InverseProperty("FkGeshippingMethod")]
    public virtual ICollection<ArsaleForecast> ArsaleForecasts { get; set; } = new List<ArsaleForecast>();

    [InverseProperty("FkGeshippingMethod")]
    public virtual ICollection<ArsaleOrder> ArsaleOrders { get; set; } = new List<ArsaleOrder>();

    [InverseProperty("FkGeshippingMethod")]
    public virtual ICollection<Arseller> Arsellers { get; set; } = new List<Arseller>();

    [InverseProperty("FkGeshippingMethod")]
    public virtual ICollection<Brposs> Brposses { get; set; } = new List<Brposs>();

    [InverseProperty("FashippingMethod")]
    public virtual ICollection<FacreditNote> FacreditNotes { get; set; } = new List<FacreditNote>();

    [InverseProperty("FashippingMethod")]
    public virtual ICollection<FapurchaseOrder> FapurchaseOrders { get; set; } = new List<FapurchaseOrder>();

    [InverseProperty("FashippingMethod")]
    public virtual ICollection<FareturnSupplier> FareturnSuppliers { get; set; } = new List<FareturnSupplier>();

    [InverseProperty("FkGeshippingMethod")]
    public virtual ICollection<IcreceiptCd> IcreceiptCds { get; set; } = new List<IcreceiptCd>();

    [InverseProperty("FkGeshippingMethod")]
    public virtual ICollection<Icreceipt> Icreceipts { get; set; } = new List<Icreceipt>();

    [InverseProperty("FkGeshippingMethod")]
    public virtual ICollection<Icshipment> Icshipments { get; set; } = new List<Icshipment>();
}
