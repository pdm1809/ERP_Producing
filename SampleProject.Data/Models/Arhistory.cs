using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SampleProject.Data.Models;

[Table("ARHistorys")]
public partial class Arhistory
{
    [Key]
    [Column("ARHistoryID")]
    public int ArhistoryId { get; set; }

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
    [Column("ARHistoryObjectName")]
    [StringLength(50)]
    public string ArhistoryObjectName { get; set; }

    [Column("ARHistoryObjectID")]
    public int? ArhistoryObjectId { get; set; }

    [Required]
    [Column("ARHistoryObjectNo")]
    [StringLength(50)]
    public string ArhistoryObjectNo { get; set; }

    [Required]
    [Column("ARHistoryAction")]
    [StringLength(50)]
    [Unicode(false)]
    public string ArhistoryAction { get; set; }

    [Column("ARHistoryDate", TypeName = "datetime")]
    public DateTime? ArhistoryDate { get; set; }

    [Required]
    [Column("ARHistoryColumnName")]
    [StringLength(100)]
    [Unicode(false)]
    public string ArhistoryColumnName { get; set; }

    [Column("ARHistoryOldValue")]
    [StringLength(2000)]
    public string ArhistoryOldValue { get; set; }

    [Column("ARHistoryNewValue")]
    [StringLength(2000)]
    public string ArhistoryNewValue { get; set; }

    [InverseProperty("FkArhistory")]
    public virtual ICollection<ArhistoryDetail> ArhistoryDetails { get; set; } = new List<ArhistoryDetail>();
}
