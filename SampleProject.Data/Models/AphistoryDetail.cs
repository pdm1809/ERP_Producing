using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SampleProject.Data.Models;

[Table("APHistoryDetails")]
public partial class AphistoryDetail
{
    [Key]
    [Column("APHistoryDetailID")]
    public int AphistoryDetailId { get; set; }

    [Column("AAStatus")]
    [StringLength(50)]
    [Unicode(false)]
    public string Aastatus { get; set; }

    [Column("FK_APHistoryID")]
    public int FkAphistoryId { get; set; }

    [Required]
    [Column("APHistoryDetailTableName")]
    [StringLength(50)]
    [Unicode(false)]
    public string AphistoryDetailTableName { get; set; }

    [Required]
    [Column("APHistoryDetailColumnName")]
    [StringLength(100)]
    [Unicode(false)]
    public string AphistoryDetailColumnName { get; set; }

    [Required]
    [Column("APHistoryDetailOldValue")]
    [StringLength(512)]
    public string AphistoryDetailOldValue { get; set; }

    [Required]
    [Column("APHistoryDetailNewValue")]
    [StringLength(512)]
    public string AphistoryDetailNewValue { get; set; }

    [ForeignKey("FkAphistoryId")]
    [InverseProperty("AphistoryDetails")]
    public virtual Aphistory FkAphistory { get; set; }
}
