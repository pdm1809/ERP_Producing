using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SampleProject.Data.Models;

[Table("APHistorys")]
public partial class Aphistory
{
    [Key]
    [Column("APHistoryID")]
    public int AphistoryId { get; set; }

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
    [Column("APHistoryObjectName")]
    [StringLength(50)]
    public string AphistoryObjectName { get; set; }

    [Column("APHistoryObjectID")]
    public int? AphistoryObjectId { get; set; }

    [Required]
    [Column("APHistoryObjectNo")]
    [StringLength(50)]
    public string AphistoryObjectNo { get; set; }

    [Required]
    [Column("APHistoryAction")]
    [StringLength(50)]
    [Unicode(false)]
    public string AphistoryAction { get; set; }

    [Column("APHistoryDate", TypeName = "datetime")]
    public DateTime? AphistoryDate { get; set; }

    [Required]
    [Column("APHistoryColumnName")]
    [StringLength(100)]
    [Unicode(false)]
    public string AphistoryColumnName { get; set; }

    [Column("APHistoryOldValue")]
    [StringLength(2000)]
    public string AphistoryOldValue { get; set; }

    [Column("APHistoryNewValue")]
    [StringLength(2000)]
    public string AphistoryNewValue { get; set; }

    [InverseProperty("FkAphistory")]
    public virtual ICollection<AphistoryDetail> AphistoryDetails { get; set; } = new List<AphistoryDetail>();
}
