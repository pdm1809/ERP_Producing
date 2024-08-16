using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SampleProject.Data.Models;

[Table("GEObjectHistory")]
public partial class GeobjectHistory
{
    [Key]
    [Column("GEObjectHistoryID")]
    public int GeobjectHistoryId { get; set; }

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
    [Column("GEObjectHistoryObjectName")]
    [StringLength(50)]
    public string GeobjectHistoryObjectName { get; set; }

    [Column("GEObjectHistoryObjectID")]
    public int? GeobjectHistoryObjectId { get; set; }

    [Required]
    [Column("GEObjectHistoryObjectNumber")]
    [StringLength(50)]
    public string GeobjectHistoryObjectNumber { get; set; }

    [Required]
    [Column("GEObjectHistoryAction")]
    [StringLength(50)]
    [Unicode(false)]
    public string GeobjectHistoryAction { get; set; }

    [Column("GEObjectHistoryDate", TypeName = "datetime")]
    public DateTime? GeobjectHistoryDate { get; set; }

    [InverseProperty("FkGeobjectHistory")]
    public virtual ICollection<GehistoryDetailOfProductBranchPrice> GehistoryDetailOfProductBranchPrices { get; set; } = new List<GehistoryDetailOfProductBranchPrice>();

    [InverseProperty("FkGeobjectHistory")]
    public virtual ICollection<GehistoryDetail> GehistoryDetails { get; set; } = new List<GehistoryDetail>();

    [InverseProperty("FkGeobjectHistory")]
    public virtual ICollection<IcreceiptItemLog> IcreceiptItemLogs { get; set; } = new List<IcreceiptItemLog>();
}
