using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SampleProject.Data.Models;

[Table("GEVATRegions")]
public partial class Gevatregion
{
    [Key]
    [Column("GEVATRegionID")]
    public int GevatregionId { get; set; }

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

    [Required]
    [Column("GEVATRegionName")]
    [StringLength(50)]
    public string GevatregionName { get; set; }

    [Column("GEVATRegionDesc")]
    [StringLength(100)]
    public string GevatregionDesc { get; set; }

    [InverseProperty("FkGevatregion")]
    public virtual ICollection<AppurchaseOrder> AppurchaseOrders { get; set; } = new List<AppurchaseOrder>();

    [InverseProperty("FkGevatregion")]
    public virtual ICollection<ArsaleForecast> ArsaleForecasts { get; set; } = new List<ArsaleForecast>();

    [InverseProperty("FkGevatregion")]
    public virtual ICollection<ArsaleOrder> ArsaleOrders { get; set; } = new List<ArsaleOrder>();

    [InverseProperty("FavatregionIdcomboNavigation")]
    public virtual ICollection<FacreditNote> FacreditNotes { get; set; } = new List<FacreditNote>();

    [InverseProperty("FavatregionIdcomboNavigation")]
    public virtual ICollection<FapurchaseOrder> FapurchaseOrders { get; set; } = new List<FapurchaseOrder>();

    [InverseProperty("FavatregionIdcomboNavigation")]
    public virtual ICollection<FareturnSupplier> FareturnSuppliers { get; set; } = new List<FareturnSupplier>();

    [InverseProperty("FavatregionIdcomboNavigation")]
    public virtual ICollection<FasellReturn> FasellReturns { get; set; } = new List<FasellReturn>();

    [InverseProperty("FkGevatregion")]
    public virtual ICollection<Icshipment> Icshipments { get; set; } = new List<Icshipment>();

    [InverseProperty("Gevatregion")]
    public virtual ICollection<Oeproposal> Oeproposals { get; set; } = new List<Oeproposal>();
}
