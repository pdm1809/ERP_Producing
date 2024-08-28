using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SampleProject.Data.Models;

[Table("ICProductTasks")]
public partial class IcproductTask
{
    [Key]
    [Column("ICProductTaskID")]
    public int IcproductTaskId { get; set; }

    [Column("AAStatus")]
    [StringLength(50)]
    [Unicode(false)]
    public string Aastatus { get; set; }

    [Column("AACreatedUser")]
    [StringLength(50)]
    public string AacreatedUser { get; set; }

    [Column("AACreatedDate", TypeName = "datetime")]
    public DateTime? AacreatedDate { get; set; }

    [Column("AAUpdatedUser")]
    [StringLength(50)]
    public string AaupdatedUser { get; set; }

    [Column("AAUpdatedDate", TypeName = "datetime")]
    public DateTime? AaupdatedDate { get; set; }

    [Column("FK_HRDepartmentID")]
    public int? FkHrdepartmentId { get; set; }

    [Column("FK_HRDepartmentRoomID")]
    public int? FkHrdepartmentRoomId { get; set; }

    [Column("FK_HREmployeeID")]
    public int? FkHremployeeId { get; set; }

    [Column("FK_PMProjectTypeID")]
    public int? FkPmprojectTypeId { get; set; }

    [Column("FK_ICMeasureUnitID")]
    public int? FkIcmeasureUnitId { get; set; }

    [Column("FK_ICTaskID")]
    public int? FkIctaskId { get; set; }

    [Column("FK_ICProductID")]
    public int? FkIcproductId { get; set; }

    [Column("ICProductTaskNo")]
    [StringLength(50)]
    [Unicode(false)]
    public string IcproductTaskNo { get; set; }

    [Column("ICProductTaskName")]
    [StringLength(256)]
    public string IcproductTaskName { get; set; }

    [Column("ICProductTaskInfo")]
    [StringLength(512)]
    public string IcproductTaskInfo { get; set; }

    [Column("ICProductTaskTotalEstimatedDays", TypeName = "decimal(18, 5)")]
    public decimal? IcproductTaskTotalEstimatedDays { get; set; }

    [Column("ICProductTaskTotalActualDays", TypeName = "decimal(18, 5)")]
    public decimal? IcproductTaskTotalActualDays { get; set; }

    [Column("ICProductTaskTotalEstimatedHours", TypeName = "decimal(18, 5)")]
    public decimal? IcproductTaskTotalEstimatedHours { get; set; }

    [Column("ICProductTaskTotalActualHours", TypeName = "decimal(18, 5)")]
    public decimal? IcproductTaskTotalActualHours { get; set; }

    [Column("ICProductTaskEstimatedExtendDays", TypeName = "decimal(18, 5)")]
    public decimal? IcproductTaskEstimatedExtendDays { get; set; }

    [Column("ICProductTaskActualExtendDays", TypeName = "decimal(18, 5)")]
    public decimal? IcproductTaskActualExtendDays { get; set; }

    [Column("ICProductTaskEstimatedExtendHours", TypeName = "decimal(18, 5)")]
    public decimal? IcproductTaskEstimatedExtendHours { get; set; }

    [Column("ICProductTaskActualExtendHours", TypeName = "decimal(18, 5)")]
    public decimal? IcproductTaskActualExtendHours { get; set; }

    [Column("ICProductTaskQty", TypeName = "decimal(18, 5)")]
    public decimal? IcproductTaskQty { get; set; }

    [Column("ICProductTaskEstimatedTotalCost", TypeName = "decimal(18, 5)")]
    public decimal? IcproductTaskEstimatedTotalCost { get; set; }

    [Column("ICProductTaskActualTotalCost", TypeName = "decimal(18, 5)")]
    public decimal? IcproductTaskActualTotalCost { get; set; }

    [Column("FK_ICProductParentID")]
    public int? FkIcproductParentId { get; set; }

    [Column("ICProductTaskParentType")]
    [StringLength(50)]
    public string IcproductTaskParentType { get; set; }

    [ForeignKey("FkHrdepartmentId")]
    [InverseProperty("IcproductTasks")]
    public virtual Hrdepartment FkHrdepartment { get; set; }

    [ForeignKey("FkHrdepartmentRoomId")]
    [InverseProperty("IcproductTasks")]
    public virtual HrdepartmentRoom FkHrdepartmentRoom { get; set; }

    [ForeignKey("FkHremployeeId")]
    [InverseProperty("IcproductTasks")]
    public virtual Hremployee FkHremployee { get; set; }

    [ForeignKey("FkIcmeasureUnitId")]
    [InverseProperty("IcproductTasks")]
    public virtual IcmeasureUnit FkIcmeasureUnit { get; set; }

    [ForeignKey("FkIcproductId")]
    [InverseProperty("IcproductTaskFkIcproducts")]
    public virtual Icproduct FkIcproduct { get; set; }

    [ForeignKey("FkIcproductParentId")]
    [InverseProperty("IcproductTaskFkIcproductParents")]
    public virtual Icproduct FkIcproductParent { get; set; }

    [ForeignKey("FkIctaskId")]
    [InverseProperty("IcproductTasks")]
    public virtual Ictask FkIctask { get; set; }

    [ForeignKey("FkPmprojectTypeId")]
    [InverseProperty("IcproductTasks")]
    public virtual PmprojectType FkPmprojectType { get; set; }

    [InverseProperty("FkIcproductTask")]
    public virtual ICollection<PmtemplateItemTask> PmtemplateItemTasks { get; set; } = new List<PmtemplateItemTask>();
}
