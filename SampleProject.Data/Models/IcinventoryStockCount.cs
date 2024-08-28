using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SampleProject.Data.Models;

[Table("ICInventoryStockCounts")]
[Microsoft.EntityFrameworkCore.Index("IcinventoryStockCountNo", "IcinventoryStockCountDate", "FkBrbranchId", "FkIcstockId", Name = "Idx_ICInventoryStockCounts")]
public partial class IcinventoryStockCount
{
    [Key]
    [Column("ICInventoryStockCountID")]
    public int IcinventoryStockCountId { get; set; }

    [Column("AAStatus")]
    [StringLength(10)]
    [Unicode(false)]
    public string Aastatus { get; set; }

    [Column("AACreatedUser")]
    [StringLength(50)]
    public string AacreatedUser { get; set; }

    [Column("AAUpdatedUser")]
    [StringLength(50)]
    public string AaupdatedUser { get; set; }

    [Column("AACreatedDate", TypeName = "datetime")]
    public DateTime? AacreatedDate { get; set; }

    [Column("AAUpdatedDate", TypeName = "datetime")]
    public DateTime? AaupdatedDate { get; set; }

    [Column("FK_ICStockID")]
    public int? FkIcstockId { get; set; }

    [Column("FK_HREmployeeID")]
    public int? FkHremployeeId { get; set; }

    [Column("FK_BRBranchID")]
    public int? FkBrbranchId { get; set; }

    [Column("FK_ICDepartmentID")]
    public int? FkIcdepartmentId { get; set; }

    [Column("FK_ICProductGroupID")]
    public int? FkIcproductGroupId { get; set; }

    [Column("ICInventoryStockCountStatus")]
    [StringLength(50)]
    public string IcinventoryStockCountStatus { get; set; }

    [Column("ICInventoryStockCountNo")]
    [StringLength(50)]
    public string IcinventoryStockCountNo { get; set; }

    [Column("ICInventoryStockCountName")]
    [StringLength(50)]
    public string IcinventoryStockCountName { get; set; }

    [Column("ICInventoryStockCountDate", TypeName = "datetime")]
    public DateTime? IcinventoryStockCountDate { get; set; }

    [Column("ICInventoryStockCountRemark")]
    [StringLength(255)]
    public string IcinventoryStockCountRemark { get; set; }

    [Column("ICInventoryStockCountEmployeeInspector")]
    [StringLength(255)]
    public string IcinventoryStockCountEmployeeInspector { get; set; }

    [Column("ICInventoryStockCountEmployeeRepresentatives")]
    [StringLength(255)]
    public string IcinventoryStockCountEmployeeRepresentatives { get; set; }

    [Column("ICInventoryStockCountType")]
    [StringLength(128)]
    public string IcinventoryStockCountType { get; set; }

    [Column("ICInventoryStockCountPostedStatus")]
    [StringLength(64)]
    public string IcinventoryStockCountPostedStatus { get; set; }

    [ForeignKey("FkBrbranchId")]
    [InverseProperty("IcinventoryStockCounts")]
    public virtual Brbranch FkBrbranch { get; set; }

    [ForeignKey("FkHremployeeId")]
    [InverseProperty("IcinventoryStockCounts")]
    public virtual Hremployee FkHremployee { get; set; }

    [ForeignKey("FkIcdepartmentId")]
    [InverseProperty("IcinventoryStockCounts")]
    public virtual Icdepartment FkIcdepartment { get; set; }

    [ForeignKey("FkIcproductGroupId")]
    [InverseProperty("IcinventoryStockCounts")]
    public virtual IcproductGroup FkIcproductGroup { get; set; }

    [ForeignKey("FkIcstockId")]
    [InverseProperty("IcinventoryStockCounts")]
    public virtual Icstock FkIcstock { get; set; }
}
