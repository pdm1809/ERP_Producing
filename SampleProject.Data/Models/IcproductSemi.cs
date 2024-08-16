using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SampleProject.Data.Models;

[Table("ICProductSemis")]
public partial class IcproductSemi
{
    [Key]
    [Column("ICProductSemiID")]
    public int IcproductSemiId { get; set; }

    [Column("AAStatus")]
    [StringLength(50)]
    [Unicode(false)]
    public string Aastatus { get; set; }

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

    [Column("FK_ICProductID")]
    public int? FkIcproductId { get; set; }

    [Column("FK_ICProductSemiID")]
    public int? FkIcproductSemiId { get; set; }

    [Column("ICProductSemiNo")]
    [StringLength(50)]
    public string IcproductSemiNo { get; set; }

    [Column("ICProductSemiName")]
    [StringLength(50)]
    public string IcproductSemiName { get; set; }

    [Column("ICProductSemiDesc")]
    [StringLength(512)]
    public string IcproductSemiDesc { get; set; }

    [Column("FK_HRDepartmentGroupOperationID")]
    public int? FkHrdepartmentGroupOperationId { get; set; }

    [Column("FK_MMMachineUnitItemID")]
    public int? FkMmmachineUnitItemId { get; set; }

    [Column("FK_MMMachineUnitOperationID")]
    public int? FkMmmachineUnitOperationId { get; set; }

    [Column("FK_ICMeasureUnitID")]
    public int? FkIcmeasureUnitId { get; set; }

    [Column("ICProductSemiAbstract")]
    [StringLength(256)]
    public string IcproductSemiAbstract { get; set; }

    [Column("ICProductSemiSetupTime", TypeName = "decimal(18, 5)")]
    public decimal? IcproductSemiSetupTime { get; set; }

    [Column("ICProductSemiEmployee", TypeName = "decimal(18, 5)")]
    public decimal? IcproductSemiEmployee { get; set; }

    [Column("ICProductSemiCapacity", TypeName = "decimal(18, 5)")]
    public decimal? IcproductSemiCapacity { get; set; }

    [Column("ICCapacityUnit")]
    [StringLength(50)]
    public string IccapacityUnit { get; set; }

    [Column("FK_MMMachineUnitID")]
    public int? FkMmmachineUnitId { get; set; }
}
