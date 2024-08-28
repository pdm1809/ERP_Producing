using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SampleProject.Data.Models;

[Table("ACCostObjectItems")]
public partial class AccostObjectItem
{
    [Key]
    [Column("ACCostObjectItemID")]
    public int AccostObjectItemId { get; set; }

    [Column("AAStatus")]
    [StringLength(50)]
    [Unicode(false)]
    public string Aastatus { get; set; }

    [Column("FK_ACCostObjectID")]
    public int FkAccostObjectId { get; set; }

    [Column("FK_ACCostCenterID")]
    public int? FkAccostCenterId { get; set; }

    [Column("FK_ACSegmentID")]
    public int? FkAcsegmentId { get; set; }

    [Column("FK_PMProjectID")]
    public int? FkPmprojectId { get; set; }

    [Column("FK_HRDepartmentID")]
    public int? FkHrdepartmentId { get; set; }

    [Column("FK_HRDepartmentRoomID")]
    public int? FkHrdepartmentRoomId { get; set; }

    [Column("FK_ACAllocationAccountID")]
    public int? FkAcallocationAccountId { get; set; }

    [Column("FK_ACCostAllocationWaitAccountID")]
    public int? FkAccostAllocationWaitAccountId { get; set; }

    [Column("ACCostObjectItemRefNo")]
    [StringLength(256)]
    public string AccostObjectItemRefNo { get; set; }

    [Column("ACCostObjectItemDate", TypeName = "datetime")]
    public DateTime? AccostObjectItemDate { get; set; }

    [Column("ACCostObjectItemModuleName")]
    [StringLength(256)]
    public string AccostObjectItemModuleName { get; set; }

    [Column("ACCostObjectItemCostObjectNo")]
    [StringLength(256)]
    public string AccostObjectItemCostObjectNo { get; set; }

    [Column("ACCostObjectItemCostObjectName")]
    [StringLength(256)]
    public string AccostObjectItemCostObjectName { get; set; }

    [Column("ACCostObjectItemDesc")]
    [StringLength(256)]
    public string AccostObjectItemDesc { get; set; }

    [Column("ACCostObjectItemStartDate", TypeName = "datetime")]
    public DateTime? AccostObjectItemStartDate { get; set; }

    [Column("ACCostObjectItemAllocationMonths")]
    public int? AccostObjectItemAllocationMonths { get; set; }

    [Column("ACCostObjectItemTotalAmount", TypeName = "decimal(18, 5)")]
    public decimal? AccostObjectItemTotalAmount { get; set; }

    [Column("ACCostObjectItemAllocatedAmount", TypeName = "decimal(18, 5)")]
    public decimal? AccostObjectItemAllocatedAmount { get; set; }

    [Column("ACCostObjectItemAllocationMonthAmount", TypeName = "decimal(18, 5)")]
    public decimal? AccostObjectItemAllocationMonthAmount { get; set; }

    [Column("ACCostObjectItemRefID")]
    public int? AccostObjectItemRefId { get; set; }

    [Column("ACCostObjectItemRefDetailID")]
    public int? AccostObjectItemRefDetailId { get; set; }

    [Column("ACCostObjectItemIsAllocated")]
    public bool AccostObjectItemIsAllocated { get; set; }

    [Column("ACCostObjectItemInitAllocatedAmount", TypeName = "decimal(18, 5)")]
    public decimal? AccostObjectItemInitAllocatedAmount { get; set; }

    [InverseProperty("FkAccostObjectItem")]
    public virtual ICollection<AcallocationCostObjectTran> AcallocationCostObjectTrans { get; set; } = new List<AcallocationCostObjectTran>();

    [ForeignKey("FkAcallocationAccountId")]
    [InverseProperty("AccostObjectItemFkAcallocationAccounts")]
    public virtual Acaccount FkAcallocationAccount { get; set; }

    [ForeignKey("FkAccostAllocationWaitAccountId")]
    [InverseProperty("AccostObjectItemFkAccostAllocationWaitAccounts")]
    public virtual Acaccount FkAccostAllocationWaitAccount { get; set; }

    [ForeignKey("FkAccostCenterId")]
    [InverseProperty("AccostObjectItems")]
    public virtual AccostCenter FkAccostCenter { get; set; }

    [ForeignKey("FkAccostObjectId")]
    [InverseProperty("AccostObjectItems")]
    public virtual AccostObject FkAccostObject { get; set; }

    [ForeignKey("FkAcsegmentId")]
    [InverseProperty("AccostObjectItems")]
    public virtual Acsegment FkAcsegment { get; set; }

    [ForeignKey("FkHrdepartmentId")]
    [InverseProperty("AccostObjectItems")]
    public virtual Hrdepartment FkHrdepartment { get; set; }

    [ForeignKey("FkHrdepartmentRoomId")]
    [InverseProperty("AccostObjectItems")]
    public virtual HrdepartmentRoom FkHrdepartmentRoom { get; set; }

    [ForeignKey("FkPmprojectId")]
    [InverseProperty("AccostObjectItems")]
    public virtual Pmproject FkPmproject { get; set; }
}
