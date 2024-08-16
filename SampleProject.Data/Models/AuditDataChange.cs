using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SampleProject.Data.Models;

public partial class AuditDataChange
{
    [Key]
    public int RecordId { get; set; }

    [Required]
    [StringLength(50)]
    [Unicode(false)]
    public string TableName { get; set; }

    [Required]
    [Column("RecordPK")]
    [StringLength(50)]
    [Unicode(false)]
    public string RecordPk { get; set; }

    [Required]
    [StringLength(50)]
    [Unicode(false)]
    public string ColumnName { get; set; }

    [StringLength(4000)]
    public string OldValue { get; set; }

    [StringLength(4000)]
    public string NewValue { get; set; }

    public DateTime ChangeDate { get; set; }

    [Required]
    [StringLength(50)]
    [Unicode(false)]
    public string UpdatedBy { get; set; }
}
