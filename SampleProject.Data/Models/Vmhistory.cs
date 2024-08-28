using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SampleProject.Data.Models;

[Table("VMHistorys")]
public partial class Vmhistory
{
    [Key]
    [Column("VMHistoryID")]
    public int VmhistoryId { get; set; }

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
    [Column("VMHistoryObjectName")]
    [StringLength(50)]
    public string VmhistoryObjectName { get; set; }

    [Column("VMHistoryObjectID")]
    public int? VmhistoryObjectId { get; set; }

    [Required]
    [Column("VMHistoryObjectNo")]
    [StringLength(50)]
    public string VmhistoryObjectNo { get; set; }

    [Required]
    [Column("VMHistoryAction")]
    [StringLength(50)]
    [Unicode(false)]
    public string VmhistoryAction { get; set; }

    [Column("VMHistoryDate", TypeName = "datetime")]
    public DateTime? VmhistoryDate { get; set; }

    [Required]
    [Column("VMHistoryColumnName")]
    [StringLength(100)]
    [Unicode(false)]
    public string VmhistoryColumnName { get; set; }

    [Required]
    [Column("VMHistoryOldValue")]
    [StringLength(512)]
    public string VmhistoryOldValue { get; set; }

    [Required]
    [Column("VMHistoryNewValue")]
    [StringLength(512)]
    public string VmhistoryNewValue { get; set; }

    [InverseProperty("FkVmhistory")]
    public virtual ICollection<VmhistoryDetail> VmhistoryDetails { get; set; } = new List<VmhistoryDetail>();
}
