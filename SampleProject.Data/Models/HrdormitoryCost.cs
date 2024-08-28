using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SampleProject.Data.Models;

[Table("HRDormitoryCosts")]
public partial class HrdormitoryCost
{
    [Key]
    [Column("HRDormitoryCostID")]
    public int HrdormitoryCostId { get; set; }

    [Column("AACreatedDate", TypeName = "datetime")]
    public DateTime? AacreatedDate { get; set; }

    [Column("AACreatedUser")]
    [StringLength(50)]
    public string AacreatedUser { get; set; }

    [Column("AAUpdatedDate", TypeName = "datetime")]
    public DateTime? AaupdatedDate { get; set; }

    [Column("AAUpdatedUser")]
    [StringLength(50)]
    public string AaupdatedUser { get; set; }

    [Column("AAStatus")]
    [StringLength(10)]
    [Unicode(false)]
    public string Aastatus { get; set; }

    [Required]
    [Column("HRDormitoryCostNo")]
    [StringLength(50)]
    public string HrdormitoryCostNo { get; set; }

    [Column("HRDormitoryCostName")]
    [StringLength(50)]
    public string HrdormitoryCostName { get; set; }

    [Column("HRDormitoryCostDate", TypeName = "datetime")]
    public DateTime? HrdormitoryCostDate { get; set; }

    [Column("HRDormitoryCostFromDate", TypeName = "datetime")]
    public DateTime? HrdormitoryCostFromDate { get; set; }

    [Column("HRDormitoryCostToDate", TypeName = "datetime")]
    public DateTime? HrdormitoryCostToDate { get; set; }

    [Column("HRDormitoryCostDesc", TypeName = "ntext")]
    public string HrdormitoryCostDesc { get; set; }

    [Column("HRDormitoryCostUnitPriceElectricity", TypeName = "decimal(18, 5)")]
    public decimal? HrdormitoryCostUnitPriceElectricity { get; set; }

    [Column("HRDormitoryCostTotalAmount", TypeName = "decimal(18, 5)")]
    public decimal? HrdormitoryCostTotalAmount { get; set; }

    [Column("HRDormitoryCostUnitPriceWater", TypeName = "decimal(18, 5)")]
    public decimal? HrdormitoryCostUnitPriceWater { get; set; }

    [InverseProperty("FkHrdormitoryCost")]
    public virtual ICollection<HrdormitoryCostItem> HrdormitoryCostItems { get; set; } = new List<HrdormitoryCostItem>();
}
