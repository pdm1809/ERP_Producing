using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SampleProject.Data.Models;

[Table("MMMaterialDepartments")]
public partial class MmmaterialDepartment
{
    [Key]
    [Column("MMMaterialDepartmentID")]
    public int MmmaterialDepartmentId { get; set; }

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

    [Column("AAStatus")]
    [StringLength(10)]
    [Unicode(false)]
    public string Aastatus { get; set; }

    [Column("FK_ICDepartmentID")]
    public int? FkIcdepartmentId { get; set; }

    [Column("ICProducType")]
    [StringLength(50)]
    public string IcproducType { get; set; }

    [Column("MMMaterialIsUseWoodPlan")]
    public bool? MmmaterialIsUseWoodPlan { get; set; }

    [Column("MMMaterialDepartmentLength")]
    [StringLength(124)]
    public string MmmaterialDepartmentLength { get; set; }

    [Column("MMMaterialDepartmentWidth")]
    [StringLength(124)]
    public string MmmaterialDepartmentWidth { get; set; }

    [Column("MMMaterialDepartmentHeigth")]
    [StringLength(124)]
    public string MmmaterialDepartmentHeigth { get; set; }

    [Column("MMMaterialDepartmentOtherCol1")]
    [StringLength(124)]
    public string MmmaterialDepartmentOtherCol1 { get; set; }

    [Column("MMMaterialDepartmentOtherCol2")]
    [StringLength(124)]
    public string MmmaterialDepartmentOtherCol2 { get; set; }

    [Column("MMMaterialDepartmentOtherCol3")]
    [StringLength(124)]
    public string MmmaterialDepartmentOtherCol3 { get; set; }

    [Column("MMMaterialDepartmentOtherCol4")]
    [StringLength(124)]
    public string MmmaterialDepartmentOtherCol4 { get; set; }

    [Column("MMMaterialDepartmentOtherCol5")]
    [StringLength(124)]
    public string MmmaterialDepartmentOtherCol5 { get; set; }

    [Column("MMMaterialDepartmentOtherCol6")]
    [StringLength(124)]
    public string MmmaterialDepartmentOtherCol6 { get; set; }

    [Column("MMMaterialDepartmentOtherCol7")]
    [StringLength(124)]
    public string MmmaterialDepartmentOtherCol7 { get; set; }

    [Column("MMMaterialDepartmentOtherCol8")]
    [StringLength(124)]
    public string MmmaterialDepartmentOtherCol8 { get; set; }

    [Column("MMMaterialDepartmentOtherCol9")]
    [StringLength(124)]
    public string MmmaterialDepartmentOtherCol9 { get; set; }

    [Column("MMMaterialDepartmentMethod")]
    [StringLength(524)]
    public string MmmaterialDepartmentMethod { get; set; }

    [Column("MMMaterialDepartmentUseMethodCol")]
    [StringLength(524)]
    public string MmmaterialDepartmentUseMethodCol { get; set; }

    [Column("MMMaterialDepartmentDesc")]
    [StringLength(524)]
    public string MmmaterialDepartmentDesc { get; set; }
}
