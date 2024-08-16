using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SampleProject.Data.Models;

[Table("ICDepartmentFormats")]
public partial class IcdepartmentFormat
{
    [Key]
    [Column("ICDepartmentFormatID")]
    public int IcdepartmentFormatId { get; set; }

    [Column("AAStatus")]
    [StringLength(10)]
    [Unicode(false)]
    public string Aastatus { get; set; }

    [Required]
    [Column("ICProductType")]
    [StringLength(50)]
    public string IcproductType { get; set; }

    [Column("ICDepartmentFormatDecimalNumber")]
    public int? IcdepartmentFormatDecimalNumber { get; set; }

    [Column("FK_STFieldFormatGroupID")]
    public int? FkStfieldFormatGroupId { get; set; }

    [ForeignKey("FkStfieldFormatGroupId")]
    [InverseProperty("IcdepartmentFormats")]
    public virtual StfieldFormatGroup FkStfieldFormatGroup { get; set; }
}
