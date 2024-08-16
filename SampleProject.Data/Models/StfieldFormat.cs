using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SampleProject.Data.Models;

[Table("STFieldFormats")]
public partial class StfieldFormat
{
    [Key]
    [Column("STFieldFormatID")]
    public int StfieldFormatId { get; set; }

    [Column("STFieldFormatModuleName")]
    [StringLength(50)]
    [Unicode(false)]
    public string StfieldFormatModuleName { get; set; }

    [Column("STFieldFormatTableName")]
    [StringLength(50)]
    [Unicode(false)]
    public string StfieldFormatTableName { get; set; }

    [Column("STFieldFormatGroupID")]
    public int? StfieldFormatGroupId { get; set; }

    [Column("STFieldFormatColumnName")]
    [StringLength(100)]
    [Unicode(false)]
    public string StfieldFormatColumnName { get; set; }

    [Column("STChangeByCurrency")]
    public bool? StchangeByCurrency { get; set; }

    [Column("STChangeByDepartment")]
    public bool? StchangeByDepartment { get; set; }

    [ForeignKey("StfieldFormatGroupId")]
    [InverseProperty("StfieldFormats")]
    public virtual StfieldFormatGroup StfieldFormatGroup { get; set; }
}
