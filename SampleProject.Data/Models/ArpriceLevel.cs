using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SampleProject.Data.Models;

[Table("ARPriceLevels")]
[Microsoft.EntityFrameworkCore.Index("ArpriceLevelNo", Name = "Idx_ARPriceLevels")]
public partial class ArpriceLevel
{
    [Key]
    [Column("ARPriceLevelID")]
    public int ArpriceLevelId { get; set; }

    [Column("AACreatedUser")]
    [StringLength(50)]
    public string AacreatedUser { get; set; }

    [Column("AAUpdatedUser")]
    [StringLength(50)]
    public string AaupdatedUser { get; set; }

    [Column("AACreatedDate", TypeName = "datetime")]
    public DateTime? AacreatedDate { get; set; }

    [Column("AAUpdatedDate", TypeName = "datetime")]
    public DateTime? AaupdatedDate { get; set; }

    [Column("AAStatus")]
    [StringLength(10)]
    [Unicode(false)]
    public string Aastatus { get; set; }

    [Required]
    [Column("ARPriceLevelNo")]
    [StringLength(50)]
    public string ArpriceLevelNo { get; set; }

    [Required]
    [Column("ARPriceLevelName")]
    [StringLength(50)]
    public string ArpriceLevelName { get; set; }

    [Column("ARPriceLevelDesc")]
    [StringLength(512)]
    public string ArpriceLevelDesc { get; set; }

    [Column("ARPriceLevelMarkDown", TypeName = "decimal(18, 5)")]
    public decimal? ArpriceLevelMarkDown { get; set; }

    [InverseProperty("FkArpriceLevel")]
    public virtual ICollection<Arcustomer> Arcustomers { get; set; } = new List<Arcustomer>();

    [InverseProperty("FkArpriceLevel")]
    public virtual ICollection<Arestimate> Arestimates { get; set; } = new List<Arestimate>();

    [InverseProperty("FkArpriceLevel")]
    public virtual ICollection<Arinvoice> Arinvoices { get; set; } = new List<Arinvoice>();

    [InverseProperty("FkArpriceLevel")]
    public virtual ICollection<Arproposal> Arproposals { get; set; } = new List<Arproposal>();

    [InverseProperty("FkArpriceLevel")]
    public virtual ICollection<ArsaleForecast> ArsaleForecasts { get; set; } = new List<ArsaleForecast>();

    [InverseProperty("FkArpriceLevel")]
    public virtual ICollection<ArsaleOrder> ArsaleOrders { get; set; } = new List<ArsaleOrder>();

    [InverseProperty("FkArpriceLevel")]
    public virtual ICollection<Brposs> Brposses { get; set; } = new List<Brposs>();

    [InverseProperty("FkArpriceLevel")]
    public virtual ICollection<IcproductPrice> IcproductPrices { get; set; } = new List<IcproductPrice>();

    [InverseProperty("FkArpriceLevel")]
    public virtual ICollection<Icshipment> Icshipments { get; set; } = new List<Icshipment>();
}
