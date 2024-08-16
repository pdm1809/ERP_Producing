using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SampleProject.Data.Models;

[Table("HRKPIFormItems")]
public partial class HrkpiformItem
{
    [Key]
    [Column("HRKPIFormItemID")]
    public int HrkpiformItemId { get; set; }

    [Column("FK_HRKPIFormID")]
    public int? FkHrkpiformId { get; set; }

    [Column("FK_HRKPIID")]
    public int? FkHrkpiid { get; set; }

    [Column("AAStatus")]
    [StringLength(64)]
    [Unicode(false)]
    public string Aastatus { get; set; }

    [Column("AACreatedUser")]
    [StringLength(64)]
    public string AacreatedUser { get; set; }

    [Column("AACreatedDate", TypeName = "datetime")]
    public DateTime? AacreatedDate { get; set; }

    [Column("AAUpdatedUser")]
    [StringLength(64)]
    public string AaupdatedUser { get; set; }

    [Column("AAUpdatedDate", TypeName = "datetime")]
    public DateTime? AaupdatedDate { get; set; }

    [Required]
    [Column("HRKPIFormItemNo")]
    [StringLength(50)]
    public string HrkpiformItemNo { get; set; }

    [Required]
    [Column("HRKPIFormItemName")]
    [StringLength(256)]
    public string HrkpiformItemName { get; set; }

    [Column("HRKPIFormItemMeasurementMethod")]
    [StringLength(256)]
    public string HrkpiformItemMeasurementMethod { get; set; }

    [Column("HRKPIFormItemWeight", TypeName = "decimal(18, 5)")]
    public decimal? HrkpiformItemWeight { get; set; }

    [Column("FK_HRDepartmentID")]
    public int? FkHrdepartmentId { get; set; }

    [Column("FK_HRDepartmentRoomID")]
    public int? FkHrdepartmentRoomId { get; set; }

    [Column("HRKPIFormItemParentID")]
    public int? HrkpiformItemParentId { get; set; }

    [Column("HRKPIFormParentID")]
    public int? HrkpiformParentId { get; set; }

    [Column("HRKPIFormItemTarget", TypeName = "decimal(18, 5)")]
    public decimal? HrkpiformItemTarget { get; set; }

    public bool? IsReverseTarget { get; set; }

    [Column("HRKPIFormItemGuide")]
    [StringLength(256)]
    public string HrkpiformItemGuide { get; set; }

    [ForeignKey("FkHrdepartmentId")]
    [InverseProperty("HrkpiformItems")]
    public virtual Hrdepartment FkHrdepartment { get; set; }

    [ForeignKey("FkHrdepartmentRoomId")]
    [InverseProperty("HrkpiformItems")]
    public virtual HrdepartmentRoom FkHrdepartmentRoom { get; set; }

    [ForeignKey("FkHrkpiid")]
    [InverseProperty("HrkpiformItems")]
    public virtual Hrkpi FkHrkpi { get; set; }

    [ForeignKey("FkHrkpiformId")]
    [InverseProperty("HrkpiformItemFkHrkpiforms")]
    public virtual Hrkpiform FkHrkpiform { get; set; }

    [InverseProperty("FkHrkpiformItem")]
    public virtual ICollection<HrkpievaluationItem> HrkpievaluationItems { get; set; } = new List<HrkpievaluationItem>();

    [ForeignKey("HrkpiformParentId")]
    [InverseProperty("HrkpiformItemHrkpiformParents")]
    public virtual Hrkpiform HrkpiformParent { get; set; }

    [InverseProperty("FkHrkpiformItem")]
    public virtual ICollection<HrkpiregistrationItem> HrkpiregistrationItems { get; set; } = new List<HrkpiregistrationItem>();
}
