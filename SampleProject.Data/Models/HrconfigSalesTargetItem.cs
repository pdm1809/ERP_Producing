using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SampleProject.Data.Models;

[Table("HRConfigSalesTargetItems")]
public partial class HrconfigSalesTargetItem
{
    [Key]
    [Column("HRConfigSalesTargetItemID")]
    public int HrconfigSalesTargetItemId { get; set; }

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

    [Column("FK_HRConfigSalesTargetID")]
    public int? FkHrconfigSalesTargetId { get; set; }

    [Column("FK_HRObjectID")]
    public int? FkHrobjectId { get; set; }

    [Column("HRObjectType")]
    [StringLength(50)]
    [Unicode(false)]
    public string HrobjectType { get; set; }

    [Column("HRConfigSalesTargetItemName")]
    [StringLength(255)]
    public string HrconfigSalesTargetItemName { get; set; }

    [Column("HRConfigSalesTargetItemValue", TypeName = "decimal(18, 5)")]
    public decimal? HrconfigSalesTargetItemValue { get; set; }

    [Column("HRConfigSalesTargetItemIndex")]
    public int? HrconfigSalesTargetItemIndex { get; set; }

    [Column("HRConfigSalesTargetItemType")]
    [StringLength(50)]
    [Unicode(false)]
    public string HrconfigSalesTargetItemType { get; set; }

    [ForeignKey("FkHrconfigSalesTargetId")]
    [InverseProperty("HrconfigSalesTargetItems")]
    public virtual HrconfigSalesTarget FkHrconfigSalesTarget { get; set; }
}
