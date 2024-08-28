using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SampleProject.Data.Models;

[Table("ICProductApplyPrices")]
public partial class IcproductApplyPrice
{
    [Key]
    [Column("ICProductApplyPriceID")]
    public int IcproductApplyPriceId { get; set; }

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

    [Column("FK_HREmployeeID")]
    public int FkHremployeeId { get; set; }

    [Required]
    [Column("ICProductApplyPriceNo")]
    [StringLength(50)]
    public string IcproductApplyPriceNo { get; set; }

    [Column("ICProductApplyPriceStatus")]
    [StringLength(50)]
    public string IcproductApplyPriceStatus { get; set; }

    [Column("ICProductApplyPriceDesc")]
    [StringLength(512)]
    public string IcproductApplyPriceDesc { get; set; }

    [Column("ICProductApplyPriceDate", TypeName = "datetime")]
    public DateTime? IcproductApplyPriceDate { get; set; }

    [Column("ICProductApplyPriceEndDate", TypeName = "datetime")]
    public DateTime? IcproductApplyPriceEndDate { get; set; }

    [Column("ICProductApplyPriceTotalAmount", TypeName = "decimal(18, 5)")]
    public decimal? IcproductApplyPriceTotalAmount { get; set; }

    [Column("FK_BRBranchID")]
    public int FkBrbranchId { get; set; }

    [Column("ICProductApplyPriceName")]
    [StringLength(50)]
    public string IcproductApplyPriceName { get; set; }

    [Required]
    [Column("ICProductApplyPriceType")]
    [StringLength(50)]
    public string IcproductApplyPriceType { get; set; }

    [ForeignKey("FkBrbranchId")]
    [InverseProperty("IcproductApplyPrices")]
    public virtual Brbranch FkBrbranch { get; set; }

    [ForeignKey("FkHremployeeId")]
    [InverseProperty("IcproductApplyPrices")]
    public virtual Hremployee FkHremployee { get; set; }

    [InverseProperty("FkIcproductApplyPrice")]
    public virtual ICollection<IcproductApplyPriceItem> IcproductApplyPriceItems { get; set; } = new List<IcproductApplyPriceItem>();
}
