using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SampleProject.Data.Models;

[Table("ICHistoryDetails")]
public partial class IchistoryDetail
{
    [Key]
    [Column("ICHistoryDetailID")]
    public int IchistoryDetailId { get; set; }

    [Column("AAStatus")]
    [StringLength(50)]
    [Unicode(false)]
    public string Aastatus { get; set; }

    [Column("FK_ICHistoryID")]
    public int FkIchistoryId { get; set; }

    [Required]
    [Column("ICHistoryDetailTableName")]
    [StringLength(50)]
    [Unicode(false)]
    public string IchistoryDetailTableName { get; set; }

    [Required]
    [Column("ICHistoryDetailColumnName")]
    [StringLength(100)]
    [Unicode(false)]
    public string IchistoryDetailColumnName { get; set; }

    [Required]
    [Column("ICHistoryDetailOldValue")]
    [StringLength(512)]
    public string IchistoryDetailOldValue { get; set; }

    [Required]
    [Column("ICHistoryDetailNewValue")]
    [StringLength(512)]
    public string IchistoryDetailNewValue { get; set; }
}
