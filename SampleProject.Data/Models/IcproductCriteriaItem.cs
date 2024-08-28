using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SampleProject.Data.Models;

[Table("ICProductCriteriaItems")]
public partial class IcproductCriteriaItem
{
    [Key]
    [Column("ICProductCriteriaItemID")]
    public int IcproductCriteriaItemId { get; set; }

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

    [Column("FK_ICProductID")]
    public int? FkIcproductId { get; set; }

    [Column("ICProductCriteriaItemProductNo")]
    [StringLength(50)]
    public string IcproductCriteriaItemProductNo { get; set; }

    [Column("ICProductCriteriaItemProductName")]
    [StringLength(256)]
    public string IcproductCriteriaItemProductName { get; set; }

    [Column("ICProductCriteriaItemProductDesc")]
    [StringLength(256)]
    public string IcproductCriteriaItemProductDesc { get; set; }

    [Column("ICProductCriteriaItemPercent", TypeName = "decimal(18, 5)")]
    public decimal? IcproductCriteriaItemPercent { get; set; }

    [Column("ICProductCriteriaItemUnitPrice", TypeName = "decimal(18, 5)")]
    public decimal? IcproductCriteriaItemUnitPrice { get; set; }

    [Column("ICProductCriteriaItemType")]
    [StringLength(50)]
    public string IcproductCriteriaItemType { get; set; }

    [Column("ICProductCriteriaItemIsIncrease")]
    public bool? IcproductCriteriaItemIsIncrease { get; set; }

    [Column("FK_ICProductCriteriaID")]
    public int? FkIcproductCriteriaId { get; set; }

    [Column("ICProductCriteriaItemProductUnitPrice", TypeName = "decimal(18, 5)")]
    public decimal? IcproductCriteriaItemProductUnitPrice { get; set; }

    [Column("ICProductCriteriaItemsDiscountAmount", TypeName = "decimal(18, 5)")]
    public decimal? IcproductCriteriaItemsDiscountAmount { get; set; }

    [ForeignKey("FkIcproductId")]
    [InverseProperty("IcproductCriteriaItems")]
    public virtual Icproduct FkIcproduct { get; set; }

    [ForeignKey("FkIcproductCriteriaId")]
    [InverseProperty("IcproductCriteriaItems")]
    public virtual IcproductCriteria FkIcproductCriteria { get; set; }
}
