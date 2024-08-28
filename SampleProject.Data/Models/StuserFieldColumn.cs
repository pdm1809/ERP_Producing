using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SampleProject.Data.Models;

[Table("STUserFieldColumns")]
public partial class StuserFieldColumn
{
    [Key]
    [Column("STUserFieldColumnID")]
    public int StuserFieldColumnId { get; set; }

    [Column("STUserFieldColumnModuleName")]
    [StringLength(100)]
    public string StuserFieldColumnModuleName { get; set; }

    [Column("STUserFieldColumnUserName")]
    [StringLength(50)]
    public string StuserFieldColumnUserName { get; set; }

    [Column("STUserFieldName")]
    [StringLength(255)]
    public string StuserFieldName { get; set; }

    [Column("STUserFieldColumnName")]
    [StringLength(255)]
    public string StuserFieldColumnName { get; set; }

    [Column("STUserFieldColumnFieldName")]
    [StringLength(255)]
    public string StuserFieldColumnFieldName { get; set; }

    [Column("STUserFieldColumnCaption")]
    [StringLength(500)]
    public string StuserFieldColumnCaption { get; set; }

    [Column("STUserFieldColumnWidth")]
    public int? StuserFieldColumnWidth { get; set; }

    [Column("STUserFieldColumnVisibleIndex")]
    public int? StuserFieldColumnVisibleIndex { get; set; }
}
