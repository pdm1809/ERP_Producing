using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SampleProject.Data.Models;

[Table("ICProductCriterias")]
public partial class IcproductCriteria
{
    [Key]
    [Column("ICProductCriteriaID")]
    public int IcproductCriteriaId { get; set; }

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

    [Column("ICProductCriteriaNo")]
    [StringLength(50)]
    public string IcproductCriteriaNo { get; set; }

    [Column("ICProductCriteriaName")]
    [StringLength(256)]
    public string IcproductCriteriaName { get; set; }

    [Column("ICProductCriteriaStartDate", TypeName = "datetime")]
    public DateTime? IcproductCriteriaStartDate { get; set; }

    [Column("ICProductCriteriaEndDate", TypeName = "datetime")]
    public DateTime? IcproductCriteriaEndDate { get; set; }

    [Column("ICProductCriteriaType")]
    [StringLength(50)]
    public string IcproductCriteriaType { get; set; }

    [Column("ICProductCriteriaStatus")]
    [StringLength(50)]
    public string IcproductCriteriaStatus { get; set; }

    [Column("ICProductCriteriaDiscountType")]
    [StringLength(50)]
    [Unicode(false)]
    public string IcproductCriteriaDiscountType { get; set; }

    [Column("ICProductCriteriaDiscountPercent", TypeName = "decimal(18, 5)")]
    public decimal? IcproductCriteriaDiscountPercent { get; set; }

    [Column("ICProductCriteriaDiscountAmount", TypeName = "decimal(18, 5)")]
    public decimal? IcproductCriteriaDiscountAmount { get; set; }

    [Column("ICProductCriteriaIsIncrease")]
    public bool? IcproductCriteriaIsIncrease { get; set; }

    [InverseProperty("FkIcproductCriteria")]
    public virtual ICollection<IcproductCriteriaItem> IcproductCriteriaItems { get; set; } = new List<IcproductCriteriaItem>();
}
