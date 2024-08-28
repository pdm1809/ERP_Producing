using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SampleProject.Data.Models;

[Table("ICHistorys")]
public partial class Ichistory
{
    [Key]
    [Column("ICHistoryID")]
    public int IchistoryId { get; set; }

    [Column("AAStatus")]
    [StringLength(10)]
    [Unicode(false)]
    public string Aastatus { get; set; }

    [Column("ADUserID")]
    public int AduserId { get; set; }

    [Column("ADUserName")]
    [StringLength(50)]
    public string AduserName { get; set; }

    [Required]
    [Column("ICHistoryObjectName")]
    [StringLength(50)]
    public string IchistoryObjectName { get; set; }

    [Column("ICHistoryObjectID")]
    public int? IchistoryObjectId { get; set; }

    [Required]
    [Column("ICHistoryObjectNo")]
    [StringLength(50)]
    public string IchistoryObjectNo { get; set; }

    [Required]
    [Column("ICHistoryAction")]
    [StringLength(50)]
    [Unicode(false)]
    public string IchistoryAction { get; set; }

    [Column("ICHistoryDate", TypeName = "datetime")]
    public DateTime? IchistoryDate { get; set; }

    [Required]
    [Column("ICHistoryColumnName")]
    [StringLength(100)]
    [Unicode(false)]
    public string IchistoryColumnName { get; set; }

    [Column("ICHistoryOldValue")]
    [StringLength(2000)]
    public string IchistoryOldValue { get; set; }

    [Column("ICHistoryNewValue")]
    [StringLength(2000)]
    public string IchistoryNewValue { get; set; }
}
