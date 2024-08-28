using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SampleProject.Data.Models;

[Table("BRHistorys")]
public partial class Brhistory
{
    [Key]
    [Column("BRHistoryID")]
    public int BrhistoryId { get; set; }

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
    [Column("BRHistoryObjectName")]
    [StringLength(50)]
    public string BrhistoryObjectName { get; set; }

    [Column("BRHistoryObjectID")]
    public int? BrhistoryObjectId { get; set; }

    [Required]
    [Column("BRHistoryObjectNo")]
    [StringLength(50)]
    public string BrhistoryObjectNo { get; set; }

    [Required]
    [Column("BRHistoryAction")]
    [StringLength(50)]
    [Unicode(false)]
    public string BrhistoryAction { get; set; }

    [Column("BRHistoryDate", TypeName = "datetime")]
    public DateTime? BrhistoryDate { get; set; }

    [Required]
    [Column("BRHistoryColumnName")]
    [StringLength(100)]
    [Unicode(false)]
    public string BrhistoryColumnName { get; set; }

    [Required]
    [Column("BRHistoryOldValue")]
    [StringLength(512)]
    public string BrhistoryOldValue { get; set; }

    [Required]
    [Column("BRHistoryNewValue")]
    [StringLength(512)]
    public string BrhistoryNewValue { get; set; }

    [InverseProperty("FkBrhistory")]
    public virtual ICollection<BrhistoryDetail> BrhistoryDetails { get; set; } = new List<BrhistoryDetail>();
}
