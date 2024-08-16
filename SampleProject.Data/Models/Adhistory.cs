using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SampleProject.Data.Models;

[Table("ADHistorys")]
public partial class Adhistory
{
    [Key]
    [Column("ADHistoryID")]
    public int AdhistoryId { get; set; }

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
    [Column("ADHistoryObjectName")]
    [StringLength(50)]
    public string AdhistoryObjectName { get; set; }

    [Column("ADHistoryObjectID")]
    public int? AdhistoryObjectId { get; set; }

    [Required]
    [Column("ADHistoryObjectNo")]
    [StringLength(50)]
    public string AdhistoryObjectNo { get; set; }

    [Required]
    [Column("ADHistoryAction")]
    [StringLength(50)]
    [Unicode(false)]
    public string AdhistoryAction { get; set; }

    [Column("ADHistoryDate", TypeName = "datetime")]
    public DateTime? AdhistoryDate { get; set; }

    [Required]
    [Column("ADHistoryColumnName")]
    [StringLength(100)]
    [Unicode(false)]
    public string AdhistoryColumnName { get; set; }

    [Required]
    [Column("ADHistoryOldValue")]
    [StringLength(512)]
    public string AdhistoryOldValue { get; set; }

    [Required]
    [Column("ADHistoryNewValue")]
    [StringLength(512)]
    public string AdhistoryNewValue { get; set; }

    [InverseProperty("FkAdhistory")]
    public virtual ICollection<AdhistoryDetail> AdhistoryDetails { get; set; } = new List<AdhistoryDetail>();
}
