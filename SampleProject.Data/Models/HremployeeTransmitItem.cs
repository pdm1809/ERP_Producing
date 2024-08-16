using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SampleProject.Data.Models;

[Table("HREmployeeTransmitItems")]
public partial class HremployeeTransmitItem
{
    [Key]
    [Column("HREmployeeTransmitItemID")]
    public int HremployeeTransmitItemId { get; set; }

    [Column("AAStatus")]
    [StringLength(50)]
    [Unicode(false)]
    public string Aastatus { get; set; }

    [Column("FK_HREmployeeTransmitID")]
    public int? FkHremployeeTransmitId { get; set; }

    [Column("FK_HREmployeeID")]
    public int? FkHremployeeId { get; set; }

    [Column("HREmployeeTransmitItemDesc")]
    [StringLength(500)]
    public string HremployeeTransmitItemDesc { get; set; }

    [Column("FK_HRDepartmentRoomID")]
    public int? FkHrdepartmentRoomId { get; set; }

    [Column("FK_HRDepartmentRoomGroupItemID")]
    public int? FkHrdepartmentRoomGroupItemId { get; set; }

    [Column("HREmployeeTransmitItemFromDate", TypeName = "datetime")]
    public DateTime? HremployeeTransmitItemFromDate { get; set; }

    [Column("HREmployeeTransmitItemToDate", TypeName = "datetime")]
    public DateTime? HremployeeTransmitItemToDate { get; set; }

    [Column("HREmployeeTransmitItemDate", TypeName = "datetime")]
    public DateTime? HremployeeTransmitItemDate { get; set; }

    [Column("HREmployeeTransmitItemDateStart", TypeName = "datetime")]
    public DateTime? HremployeeTransmitItemDateStart { get; set; }

    [Column("HREmployeeTransmitItemDateEnd", TypeName = "datetime")]
    public DateTime? HremployeeTransmitItemDateEnd { get; set; }

    [Column("HREmployeeTransmitItemSalary", TypeName = "decimal(18, 5)")]
    public decimal? HremployeeTransmitItemSalary { get; set; }

    [Column("HREmployeeTransmitItemResponsibilitySalary", TypeName = "decimal(18, 5)")]
    public decimal? HremployeeTransmitItemResponsibilitySalary { get; set; }

    [Column("HREmployeeTransmitItemMeasureUnitType")]
    [StringLength(50)]
    public string HremployeeTransmitItemMeasureUnitType { get; set; }

    [Column("FK_HRLevelID")]
    public int? FkHrlevelId { get; set; }

    [ForeignKey("FkHrdepartmentRoomId")]
    [InverseProperty("HremployeeTransmitItems")]
    public virtual HrdepartmentRoom FkHrdepartmentRoom { get; set; }

    [ForeignKey("FkHrdepartmentRoomGroupItemId")]
    [InverseProperty("HremployeeTransmitItems")]
    public virtual HrdepartmentRoomGroupItem FkHrdepartmentRoomGroupItem { get; set; }

    [ForeignKey("FkHremployeeId")]
    [InverseProperty("HremployeeTransmitItems")]
    public virtual Hremployee FkHremployee { get; set; }

    [ForeignKey("FkHremployeeTransmitId")]
    [InverseProperty("HremployeeTransmitItems")]
    public virtual HremployeeTransmit FkHremployeeTransmit { get; set; }

    [ForeignKey("FkHrlevelId")]
    [InverseProperty("HremployeeTransmitItems")]
    public virtual Hrlevel FkHrlevel { get; set; }
}
