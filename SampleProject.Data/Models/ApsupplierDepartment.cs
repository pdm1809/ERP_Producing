using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SampleProject.Data.Models;

[Table("APSupplierDepartments")]
public partial class ApsupplierDepartment
{
    [Key]
    [Column("APSupplierDepartmentID")]
    public int ApsupplierDepartmentId { get; set; }

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

    [Column("FK_APSupplierID")]
    public int FkApsupplierId { get; set; }

    [Column("FK_ICDepartmentID")]
    public int FkIcdepartmentId { get; set; }

    [ForeignKey("FkApsupplierId")]
    [InverseProperty("ApsupplierDepartments")]
    public virtual Apsupplier FkApsupplier { get; set; }

    [ForeignKey("FkIcdepartmentId")]
    [InverseProperty("ApsupplierDepartments")]
    public virtual Icdepartment FkIcdepartment { get; set; }
}
