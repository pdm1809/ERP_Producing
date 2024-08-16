using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SampleProject.Data.Models;

[Table("VMHistoryDetails")]
public partial class VmhistoryDetail
{
    [Key]
    [Column("VMHistoryDetailID")]
    public int VmhistoryDetailId { get; set; }

    [Column("AAStatus")]
    [StringLength(50)]
    [Unicode(false)]
    public string Aastatus { get; set; }

    [Column("FK_VMHistoryID")]
    public int FkVmhistoryId { get; set; }

    [Required]
    [Column("VMHistoryDetailTableName")]
    [StringLength(50)]
    [Unicode(false)]
    public string VmhistoryDetailTableName { get; set; }

    [Required]
    [Column("VMHistoryDetailColumnName")]
    [StringLength(100)]
    [Unicode(false)]
    public string VmhistoryDetailColumnName { get; set; }

    [Required]
    [Column("VMHistoryDetailOldValue")]
    [StringLength(512)]
    public string VmhistoryDetailOldValue { get; set; }

    [Required]
    [Column("VMHistoryDetailNewValue")]
    [StringLength(512)]
    public string VmhistoryDetailNewValue { get; set; }

    [ForeignKey("FkVmhistoryId")]
    [InverseProperty("VmhistoryDetails")]
    public virtual Vmhistory FkVmhistory { get; set; }
}
