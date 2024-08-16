using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SampleProject.Data.Models;

[Table("ICImportEquipments")]
public partial class IcimportEquipment
{
    [Key]
    [Column("ICImportEquipmentID")]
    public int IcimportEquipmentId { get; set; }

    [Column("ICImportEquipmentNo")]
    [StringLength(50)]
    public string IcimportEquipmentNo { get; set; }

    [Column("ICImportEquipmentIndentifiedNo")]
    [StringLength(50)]
    public string IcimportEquipmentIndentifiedNo { get; set; }

    [Column("ICImportEquipmentName")]
    [StringLength(512)]
    public string IcimportEquipmentName { get; set; }

    [Column("ICImportEquipmentSpecification")]
    [StringLength(512)]
    public string IcimportEquipmentSpecification { get; set; }

    [Column("ICImportEquipmentUnit")]
    [StringLength(50)]
    public string IcimportEquipmentUnit { get; set; }

    [Column("ICImportEquipmentQty", TypeName = "decimal(18, 5)")]
    public decimal? IcimportEquipmentQty { get; set; }

    [Column("ICImportEquipmentUserName")]
    [StringLength(512)]
    public string IcimportEquipmentUserName { get; set; }

    [Column("ICImportEquipmentDepartmentRoom")]
    [StringLength(512)]
    public string IcimportEquipmentDepartmentRoom { get; set; }

    [Column("ICImportEquipmentDepartment")]
    [StringLength(512)]
    public string IcimportEquipmentDepartment { get; set; }

    [Column("FK_HRDepartmentID")]
    public int? FkHrdepartmentId { get; set; }

    [Column("FK_HRDepartmentRoomID")]
    public int? FkHrdepartmentRoomId { get; set; }

    [Column("FK_HRDepartmentRoomGroupItemID")]
    public int? FkHrdepartmentRoomGroupItemId { get; set; }

    [Column("FK_HREmployeeID")]
    public int? FkHremployeeId { get; set; }

    public bool? HasImport { get; set; }

    public bool? IsProductUsing { get; set; }
}
