using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SampleProject.Data.Models;

[Table("PMHistoryDetails")]
public partial class PmhistoryDetail
{
    [Key]
    [Column("PMHistoryDetailID")]
    public int PmhistoryDetailId { get; set; }

    [Column("AAStatus")]
    [StringLength(50)]
    [Unicode(false)]
    public string Aastatus { get; set; }

    [Column("FK_PMHistoryID")]
    public int FkPmhistoryId { get; set; }

    [Required]
    [Column("PMHistoryDetailTableName")]
    [StringLength(50)]
    [Unicode(false)]
    public string PmhistoryDetailTableName { get; set; }

    [Required]
    [Column("PMHistoryDetailColumnName")]
    [StringLength(100)]
    [Unicode(false)]
    public string PmhistoryDetailColumnName { get; set; }

    [Required]
    [Column("PMHistoryDetailOldValue")]
    [StringLength(512)]
    public string PmhistoryDetailOldValue { get; set; }

    [Required]
    [Column("PMHistoryDetailNewValue")]
    [StringLength(512)]
    public string PmhistoryDetailNewValue { get; set; }

    [ForeignKey("FkPmhistoryId")]
    [InverseProperty("PmhistoryDetails")]
    public virtual Pmhistory FkPmhistory { get; set; }
}
