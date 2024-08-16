using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SampleProject.Data.Models;

[Table("GEHistoryDetails")]
public partial class GehistoryDetail
{
    [Key]
    [Column("GEHistoryDetailID")]
    public int GehistoryDetailId { get; set; }

    [Column("AAStatus")]
    [StringLength(50)]
    [Unicode(false)]
    public string Aastatus { get; set; }

    [Column("FK_GEObjectHistoryID")]
    public int FkGeobjectHistoryId { get; set; }

    [Required]
    [Column("GEHistoryDetailTableName")]
    [StringLength(50)]
    [Unicode(false)]
    public string GehistoryDetailTableName { get; set; }

    [Required]
    [Column("GEHistoryDetailColumnName")]
    [StringLength(100)]
    [Unicode(false)]
    public string GehistoryDetailColumnName { get; set; }

    [Required]
    [Column("GEHistoryDetailOldValue")]
    [StringLength(512)]
    public string GehistoryDetailOldValue { get; set; }

    [Required]
    [Column("GEHistoryDetailNewValue")]
    [StringLength(512)]
    public string GehistoryDetailNewValue { get; set; }

    [Column("GEHistoryDetailParentID")]
    public int? GehistoryDetailParentId { get; set; }

    public bool IsApproved { get; set; }

    [ForeignKey("FkGeobjectHistoryId")]
    [InverseProperty("GehistoryDetails")]
    public virtual GeobjectHistory FkGeobjectHistory { get; set; }
}
