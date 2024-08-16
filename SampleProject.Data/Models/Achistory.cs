using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SampleProject.Data.Models;

[Table("ACHistorys")]
public partial class Achistory
{
    [Key]
    [Column("ACHistoryID")]
    public int AchistoryId { get; set; }

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
    [Column("ACHistoryObjectName")]
    [StringLength(50)]
    public string AchistoryObjectName { get; set; }

    [Column("ACHistoryObjectID")]
    public int? AchistoryObjectId { get; set; }

    [Required]
    [Column("ACHistoryObjectNo")]
    [StringLength(50)]
    public string AchistoryObjectNo { get; set; }

    [Required]
    [Column("ACHistoryAction")]
    [StringLength(50)]
    [Unicode(false)]
    public string AchistoryAction { get; set; }

    [Column("ACHistoryDate", TypeName = "datetime")]
    public DateTime? AchistoryDate { get; set; }

    [Required]
    [Column("ACHistoryColumnName")]
    [StringLength(100)]
    [Unicode(false)]
    public string AchistoryColumnName { get; set; }

    [Column("ACHistoryOldValue")]
    [StringLength(2000)]
    public string AchistoryOldValue { get; set; }

    [Column("ACHistoryNewValue")]
    [StringLength(2000)]
    public string AchistoryNewValue { get; set; }

    [InverseProperty("FkAchistory")]
    public virtual ICollection<AchistoryDetail> AchistoryDetails { get; set; } = new List<AchistoryDetail>();
}
