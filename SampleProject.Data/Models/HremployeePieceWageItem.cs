using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SampleProject.Data.Models;

[Table("HREmployeePieceWageItems")]
public partial class HremployeePieceWageItem
{
    [Key]
    [Column("HREmployeePieceWageItemID")]
    public int HremployeePieceWageItemId { get; set; }

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

    [Column("FK_HREmployeePieceWageID")]
    public int FkHremployeePieceWageId { get; set; }

    [Column("FK_HREmployeeID")]
    public int FkHremployeeId { get; set; }

    [Column("FK_HREmployeeID2")]
    public int? FkHremployeeId2 { get; set; }

    [Column("FK_HRDepartmentID")]
    public int? FkHrdepartmentId { get; set; }

    [Column("FK_HRDepartmentRoomID")]
    public int? FkHrdepartmentRoomId { get; set; }

    [Column("FK_HRDepartmentRoomGroupItemID")]
    public int? FkHrdepartmentRoomGroupItemId { get; set; }

    [Column("HREmployeePieceWageItemCardNumber")]
    [StringLength(200)]
    public string HremployeePieceWageItemCardNumber { get; set; }

    [Column("HREmployeePieceWageItemDesc")]
    [StringLength(500)]
    public string HremployeePieceWageItemDesc { get; set; }

    [Column("HREmployeePieceWageItemIsAction")]
    public bool? HremployeePieceWageItemIsAction { get; set; }

    [Column("HREmployeePieceWageItemAmount", TypeName = "decimal(18, 5)")]
    public decimal? HremployeePieceWageItemAmount { get; set; }

    [Column("HREmployeePieceWageItemQty", TypeName = "decimal(18, 5)")]
    public decimal? HremployeePieceWageItemQty { get; set; }

    [ForeignKey("FkHrdepartmentId")]
    [InverseProperty("HremployeePieceWageItems")]
    public virtual Hrdepartment FkHrdepartment { get; set; }

    [ForeignKey("FkHrdepartmentRoomId")]
    [InverseProperty("HremployeePieceWageItems")]
    public virtual HrdepartmentRoom FkHrdepartmentRoom { get; set; }

    [ForeignKey("FkHrdepartmentRoomGroupItemId")]
    [InverseProperty("HremployeePieceWageItems")]
    public virtual HrdepartmentRoomGroupItem FkHrdepartmentRoomGroupItem { get; set; }

    [ForeignKey("FkHremployeeId")]
    [InverseProperty("HremployeePieceWageItemFkHremployees")]
    public virtual Hremployee FkHremployee { get; set; }

    [ForeignKey("FkHremployeeId2")]
    [InverseProperty("HremployeePieceWageItemFkHremployeeId2Navigations")]
    public virtual Hremployee FkHremployeeId2Navigation { get; set; }

    [ForeignKey("FkHremployeePieceWageId")]
    [InverseProperty("HremployeePieceWageItems")]
    public virtual HremployeePieceWage FkHremployeePieceWage { get; set; }
}
