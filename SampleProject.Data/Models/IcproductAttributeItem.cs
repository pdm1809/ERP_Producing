using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SampleProject.Data.Models;

[Table("ICProductAttributeItems")]
public partial class IcproductAttributeItem
{
    [Key]
    [Column("ICProductAttributeItemID")]
    public int IcproductAttributeItemId { get; set; }

    [Column("AACreatedUser")]
    [StringLength(50)]
    public string AacreatedUser { get; set; }

    [Column("AACreatedDate", TypeName = "datetime")]
    public DateTime? AacreatedDate { get; set; }

    [Column("AAUpdatedUser")]
    [StringLength(50)]
    public string AaupdatedUser { get; set; }

    [Column("AAUpdatedDate", TypeName = "datetime")]
    public DateTime? AaupdatedDate { get; set; }

    [Column("AAStatus")]
    [StringLength(10)]
    [Unicode(false)]
    public string Aastatus { get; set; }

    [Column("FK_ICProductAttributeID")]
    public int? FkIcproductAttributeId { get; set; }

    [Column("FK_MMOperationID")]
    public int? FkMmoperationId { get; set; }

    [Column("ICProductAttributeItemPeriod")]
    public int? IcproductAttributeItemPeriod { get; set; }

    [Column("FK_MMProcessID")]
    public int? FkMmprocessId { get; set; }

    [Column("ICMachineGroup")]
    [StringLength(50)]
    public string IcmachineGroup { get; set; }

    [Column("ICProductAttributeItemIsPlan")]
    public bool? IcproductAttributeItemIsPlan { get; set; }

    [Column("FK_MMOperationSynID")]
    public int? FkMmoperationSynId { get; set; }

    [Column("ICProductAttributeItemForParentSyncCheck")]
    public bool? IcproductAttributeItemForParentSyncCheck { get; set; }

    [Column("ICProductAttributeItemIsOutSourcing")]
    public bool? IcproductAttributeItemIsOutSourcing { get; set; }

    [Column("ICProductAttributeItemSyncProductCheck")]
    public bool? IcproductAttributeItemSyncProductCheck { get; set; }

    [Column("ICProductAttributeItemInOutStockCheck")]
    public bool? IcproductAttributeItemInOutStockCheck { get; set; }

    [Column("ICProductAttributeItemIsEndProcess")]
    public bool? IcproductAttributeItemIsEndProcess { get; set; }

    [ForeignKey("FkIcproductAttributeId")]
    [InverseProperty("IcproductAttributeItems")]
    public virtual IcproductAttribute FkIcproductAttribute { get; set; }

    [ForeignKey("FkMmoperationId")]
    [InverseProperty("IcproductAttributeItems")]
    public virtual Mmoperation FkMmoperation { get; set; }

    [ForeignKey("FkMmprocessId")]
    [InverseProperty("IcproductAttributeItems")]
    public virtual Mmprocesss FkMmprocess { get; set; }

    [InverseProperty("FkIcproductAttributeItem")]
    public virtual ICollection<MmprocessInfo> MmprocessInfos { get; set; } = new List<MmprocessInfo>();
}
