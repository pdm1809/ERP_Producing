using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SampleProject.Data.Models;

[Table("ADHistoryDetails")]
public partial class AdhistoryDetail
{
    [Key]
    [Column("ADHistoryDetailID")]
    public int AdhistoryDetailId { get; set; }

    [Column("AAStatus")]
    [StringLength(50)]
    [Unicode(false)]
    public string Aastatus { get; set; }

    [Column("FK_ADHistoryID")]
    public int FkAdhistoryId { get; set; }

    [Required]
    [Column("ADHistoryDetailTableName")]
    [StringLength(50)]
    [Unicode(false)]
    public string AdhistoryDetailTableName { get; set; }

    [Required]
    [Column("ADHistoryDetailColumnName")]
    [StringLength(100)]
    [Unicode(false)]
    public string AdhistoryDetailColumnName { get; set; }

    [Required]
    [Column("ADHistoryDetailOldValue")]
    [StringLength(512)]
    public string AdhistoryDetailOldValue { get; set; }

    [Required]
    [Column("ADHistoryDetailNewValue")]
    [StringLength(512)]
    public string AdhistoryDetailNewValue { get; set; }

    [ForeignKey("FkAdhistoryId")]
    [InverseProperty("AdhistoryDetails")]
    public virtual Adhistory FkAdhistory { get; set; }
}
