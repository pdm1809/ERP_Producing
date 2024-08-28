using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SampleProject.Data.Models;

[Table("MMHistorys")]
public partial class Mmhistory
{
    [Key]
    [Column("MMHistoryID")]
    public int MmhistoryId { get; set; }

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
    [Column("MMHistoryObjectName")]
    [StringLength(50)]
    public string MmhistoryObjectName { get; set; }

    [Column("MMHistoryObjectID")]
    public int? MmhistoryObjectId { get; set; }

    [Required]
    [Column("MMHistoryObjectNo")]
    [StringLength(50)]
    public string MmhistoryObjectNo { get; set; }

    [Required]
    [Column("MMHistoryAction")]
    [StringLength(50)]
    [Unicode(false)]
    public string MmhistoryAction { get; set; }

    [Column("MMHistoryDate", TypeName = "datetime")]
    public DateTime? MmhistoryDate { get; set; }

    [Required]
    [Column("MMHistoryColumnName")]
    [StringLength(100)]
    [Unicode(false)]
    public string MmhistoryColumnName { get; set; }

    [Required]
    [Column("MMHistoryOldValue")]
    [StringLength(512)]
    public string MmhistoryOldValue { get; set; }

    [Required]
    [Column("MMHistoryNewValue")]
    [StringLength(512)]
    public string MmhistoryNewValue { get; set; }

    [InverseProperty("FkMmhistory")]
    public virtual ICollection<MmhistoryDetail> MmhistoryDetails { get; set; } = new List<MmhistoryDetail>();
}
