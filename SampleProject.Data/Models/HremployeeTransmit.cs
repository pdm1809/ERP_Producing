using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SampleProject.Data.Models;

[Table("HREmployeeTransmits")]
public partial class HremployeeTransmit
{
    [Key]
    [Column("HREmployeeTransmitID")]
    public int HremployeeTransmitId { get; set; }

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

    [Column("FK_HRDepartmentRoomID")]
    public int? FkHrdepartmentRoomId { get; set; }

    [Column("FK_HRDepartmentRoomGroupItemID")]
    public int? FkHrdepartmentRoomGroupItemId { get; set; }

    [Column("HREmployeeTransmitNo")]
    [StringLength(50)]
    [Unicode(false)]
    public string HremployeeTransmitNo { get; set; }

    [Column("HREmployeeTransmitName")]
    [StringLength(255)]
    public string HremployeeTransmitName { get; set; }

    [Column("HREmployeeTransmitDesc")]
    [StringLength(512)]
    public string HremployeeTransmitDesc { get; set; }

    [Column("HREmployeeTransmitFromDate", TypeName = "datetime")]
    public DateTime? HremployeeTransmitFromDate { get; set; }

    [Column("HREmployeeTransmitToDate", TypeName = "datetime")]
    public DateTime? HremployeeTransmitToDate { get; set; }

    [Column("HREmployeeTransmitDate", TypeName = "datetime")]
    public DateTime? HremployeeTransmitDate { get; set; }

    [Column("HREmployeeTransmitDateStart", TypeName = "datetime")]
    public DateTime? HremployeeTransmitDateStart { get; set; }

    [Column("HREmployeeTransmitDateEnd", TypeName = "datetime")]
    public DateTime? HremployeeTransmitDateEnd { get; set; }

    [Column("HREmployeeTransmitStatus")]
    [StringLength(100)]
    public string HremployeeTransmitStatus { get; set; }

    [Column("FK_MMWorkShopID")]
    public int? FkMmworkShopId { get; set; }

    [Column("FK_HRDepartmentID")]
    public int? FkHrdepartmentId { get; set; }

    [Column("FK_BRBranchID")]
    public int? FkBrbranchId { get; set; }

    [Column("FK_HRLevelID")]
    public int? FkHrlevelId { get; set; }

    [ForeignKey("FkBrbranchId")]
    [InverseProperty("HremployeeTransmits")]
    public virtual Brbranch FkBrbranch { get; set; }

    [ForeignKey("FkHrdepartmentId")]
    [InverseProperty("HremployeeTransmits")]
    public virtual Hrdepartment FkHrdepartment { get; set; }

    [ForeignKey("FkHrdepartmentRoomId")]
    [InverseProperty("HremployeeTransmits")]
    public virtual HrdepartmentRoom FkHrdepartmentRoom { get; set; }

    [ForeignKey("FkHrdepartmentRoomGroupItemId")]
    [InverseProperty("HremployeeTransmits")]
    public virtual HrdepartmentRoomGroupItem FkHrdepartmentRoomGroupItem { get; set; }

    [ForeignKey("FkHrlevelId")]
    [InverseProperty("HremployeeTransmits")]
    public virtual Hrlevel FkHrlevel { get; set; }

    [ForeignKey("FkMmworkShopId")]
    [InverseProperty("HremployeeTransmits")]
    public virtual MmworkShop FkMmworkShop { get; set; }

    [InverseProperty("FkHremployeeTransmit")]
    public virtual ICollection<HremployeeTransmitItem> HremployeeTransmitItems { get; set; } = new List<HremployeeTransmitItem>();
}
