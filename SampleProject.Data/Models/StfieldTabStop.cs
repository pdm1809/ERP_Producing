using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SampleProject.Data.Models;

[Table("STFieldTabStops")]
public partial class StfieldTabStop
{
    [Key]
    [Column("STFieldTabStopID")]
    public int StfieldTabStopId { get; set; }

    [Required]
    [Column("STFieldName")]
    [StringLength(50)]
    [Unicode(false)]
    public string StfieldName { get; set; }

    [Column("STFieldType")]
    [StringLength(50)]
    [Unicode(false)]
    public string StfieldType { get; set; }

    [Column("STFieldDataSource")]
    [StringLength(255)]
    [Unicode(false)]
    public string StfieldDataSource { get; set; }

    [Column("STFieldDataMember")]
    [StringLength(255)]
    [Unicode(false)]
    public string StfieldDataMember { get; set; }

    [Column("STFieldTabStopSortOrder")]
    public int? StfieldTabStopSortOrder { get; set; }

    [Column("STFieldTabStopAction")]
    [StringLength(50)]
    [Unicode(false)]
    public string StfieldTabStopAction { get; set; }

    [Column("STFieldTabStopModuleName")]
    [StringLength(50)]
    [Unicode(false)]
    public string StfieldTabStopModuleName { get; set; }

    [Column("STFieldTabStopGroupName")]
    [StringLength(50)]
    [Unicode(false)]
    public string StfieldTabStopGroupName { get; set; }
}
