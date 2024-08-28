using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SampleProject.Data.Models;

[Table("PMHistorys")]
public partial class Pmhistory
{
    [Key]
    [Column("PMHistoryID")]
    public int PmhistoryId { get; set; }

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
    [Column("PMHistoryObjectName")]
    [StringLength(50)]
    public string PmhistoryObjectName { get; set; }

    [Column("PMHistoryObjectID")]
    public int? PmhistoryObjectId { get; set; }

    [Required]
    [Column("PMHistoryObjectNo")]
    [StringLength(50)]
    public string PmhistoryObjectNo { get; set; }

    [Required]
    [Column("PMHistoryAction")]
    [StringLength(50)]
    [Unicode(false)]
    public string PmhistoryAction { get; set; }

    [Column("PMHistoryDate", TypeName = "datetime")]
    public DateTime? PmhistoryDate { get; set; }

    [Required]
    [Column("PMHistoryColumnName")]
    [StringLength(100)]
    [Unicode(false)]
    public string PmhistoryColumnName { get; set; }

    [Required]
    [Column("PMHistoryOldValue")]
    [StringLength(512)]
    public string PmhistoryOldValue { get; set; }

    [Required]
    [Column("PMHistoryNewValue")]
    [StringLength(512)]
    public string PmhistoryNewValue { get; set; }

    [InverseProperty("FkPmhistory")]
    public virtual ICollection<PmhistoryDetail> PmhistoryDetails { get; set; } = new List<PmhistoryDetail>();
}
