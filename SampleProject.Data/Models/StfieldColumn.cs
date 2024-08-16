using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SampleProject.Data.Models;

[Table("STFieldColumns")]
public partial class StfieldColumn
{
    [Key]
    [Column("STFieldColumnID")]
    public int StfieldColumnId { get; set; }

    [Required]
    [Column("STFieldColumnIDString")]
    [StringLength(50)]
    [Unicode(false)]
    public string StfieldColumnIdstring { get; set; }

    [Column("STFieldID")]
    public int StfieldId { get; set; }

    [Column("STFieldColumnName")]
    [StringLength(256)]
    public string StfieldColumnName { get; set; }

    [Required]
    [Column("STFieldColumnCaption")]
    [StringLength(255)]
    public string StfieldColumnCaption { get; set; }

    [Column("STFieldColumnFieldName")]
    [StringLength(256)]
    public string StfieldColumnFieldName { get; set; }

    [Column("STFieldColumnFormatString")]
    [StringLength(50)]
    [Unicode(false)]
    public string StfieldColumnFormatString { get; set; }

    [Column("STFieldColumnFormatType")]
    [StringLength(50)]
    [Unicode(false)]
    public string StfieldColumnFormatType { get; set; }

    [Column("STFieldColumnWidth")]
    public int? StfieldColumnWidth { get; set; }

    [Column("STFieldColumnVisibleIndex")]
    public int? StfieldColumnVisibleIndex { get; set; }

    [Column("STFieldColumnCommodityType")]
    [StringLength(50)]
    public string StfieldColumnCommodityType { get; set; }

    [ForeignKey("StfieldId")]
    [InverseProperty("StfieldColumns")]
    public virtual Stfield Stfield { get; set; }
}
