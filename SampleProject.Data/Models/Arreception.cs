using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SampleProject.Data.Models;

[Table("ARReceptions")]
public partial class Arreception
{
    [Key]
    [Column("ARReceptionID")]
    public int ArreceptionId { get; set; }

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
    [StringLength(50)]
    [Unicode(false)]
    public string Aastatus { get; set; }

    [Column("FK_HREmployeeID")]
    public int? FkHremployeeId { get; set; }

    [Column("FK_HRDriverEmployeeID")]
    public int? FkHrdriverEmployeeId { get; set; }

    [Column("FK_HRReturnEmployeeID")]
    public int? FkHrreturnEmployeeId { get; set; }

    [Column("FK_ARDeliveryPlanID")]
    public int? FkArdeliveryPlanId { get; set; }

    [Column("ARReceptionNo")]
    [StringLength(50)]
    public string ArreceptionNo { get; set; }

    [Column("ARReceptionName")]
    [StringLength(100)]
    public string ArreceptionName { get; set; }

    [Column("ARReceptionDesc")]
    [StringLength(512)]
    public string ArreceptionDesc { get; set; }

    [Column("ARReceptionComment")]
    [StringLength(512)]
    public string ArreceptionComment { get; set; }

    [Column("ARReceptionDate", TypeName = "datetime")]
    public DateTime? ArreceptionDate { get; set; }

    [Column("ARReceptionStatus")]
    [StringLength(50)]
    public string ArreceptionStatus { get; set; }

    [Column("ARReceptionExpediencyQty", TypeName = "decimal(18, 5)")]
    public decimal? ArreceptionExpediencyQty { get; set; }

    [Column("FK_BRBranchID")]
    public int? FkBrbranchId { get; set; }

    [Column("FK_ARAllocationID")]
    public int? FkArallocationId { get; set; }

    [Column("ARReceptionType")]
    [StringLength(256)]
    public string ArreceptionType { get; set; }

    [Column("FK_ACEquipmentStateID")]
    public int? FkAcequipmentStateId { get; set; }

    [InverseProperty("FkArreception")]
    public virtual ICollection<ArreceptionItem> ArreceptionItems { get; set; } = new List<ArreceptionItem>();

    [ForeignKey("FkAcequipmentStateId")]
    [InverseProperty("Arreceptions")]
    public virtual AcequipmentState FkAcequipmentState { get; set; }

    [ForeignKey("FkArallocationId")]
    [InverseProperty("Arreceptions")]
    public virtual Arallocation FkArallocation { get; set; }

    [ForeignKey("FkArdeliveryPlanId")]
    [InverseProperty("Arreceptions")]
    public virtual ArdeliveryPlan FkArdeliveryPlan { get; set; }

    [ForeignKey("FkBrbranchId")]
    [InverseProperty("Arreceptions")]
    public virtual Brbranch FkBrbranch { get; set; }

    [ForeignKey("FkHrdriverEmployeeId")]
    [InverseProperty("ArreceptionFkHrdriverEmployees")]
    public virtual Hremployee FkHrdriverEmployee { get; set; }

    [ForeignKey("FkHremployeeId")]
    [InverseProperty("ArreceptionFkHremployees")]
    public virtual Hremployee FkHremployee { get; set; }

    [ForeignKey("FkHrreturnEmployeeId")]
    [InverseProperty("ArreceptionFkHrreturnEmployees")]
    public virtual Hremployee FkHrreturnEmployee { get; set; }
}
