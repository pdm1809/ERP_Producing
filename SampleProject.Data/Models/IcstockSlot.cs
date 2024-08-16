using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SampleProject.Data.Models;

[Table("ICStockSlots")]
[Microsoft.EntityFrameworkCore.Index("IcstockSlotNo", "FkIcstockId", Name = "Idx_ICStockSlots")]
public partial class IcstockSlot
{
    [Key]
    [Column("ICStockSlotID")]
    public int IcstockSlotId { get; set; }

    [Column("AAStatus")]
    [StringLength(10)]
    [Unicode(false)]
    public string Aastatus { get; set; }

    [Column("AACreatedUser")]
    [StringLength(50)]
    public string AacreatedUser { get; set; }

    [Column("AAUpdatedUser")]
    [StringLength(50)]
    public string AaupdatedUser { get; set; }

    [Column("AACreatedDate", TypeName = "datetime")]
    public DateTime? AacreatedDate { get; set; }

    [Column("AAUpdatedDate", TypeName = "datetime")]
    public DateTime? AaupdatedDate { get; set; }

    [Column("FK_ICStockID")]
    public int FkIcstockId { get; set; }

    [Column("ICStockSlotNo")]
    [StringLength(50)]
    public string IcstockSlotNo { get; set; }

    [Required]
    [Column("ICStockSlotName")]
    [StringLength(50)]
    public string IcstockSlotName { get; set; }

    [Column("ICStockSlotDesc")]
    [StringLength(255)]
    public string IcstockSlotDesc { get; set; }

    [Column("ICStockSlotMatchCode01Combo")]
    [StringLength(50)]
    [Unicode(false)]
    public string IcstockSlotMatchCode01Combo { get; set; }

    [Column("ICStockSlotMatchCode02Combo")]
    [StringLength(50)]
    [Unicode(false)]
    public string IcstockSlotMatchCode02Combo { get; set; }

    [InverseProperty("FkIcstockSlot")]
    public virtual ICollection<AppurchaseOrderItem> AppurchaseOrderItems { get; set; } = new List<AppurchaseOrderItem>();

    [InverseProperty("FkIcstockSlot")]
    public virtual ICollection<ArcreditNoteItem> ArcreditNoteItems { get; set; } = new List<ArcreditNoteItem>();

    [InverseProperty("FkIcstockSlot")]
    public virtual ICollection<ArestimateItem> ArestimateItems { get; set; } = new List<ArestimateItem>();

    [InverseProperty("FkIcstockSlot")]
    public virtual ICollection<Arestimate> Arestimates { get; set; } = new List<Arestimate>();

    [InverseProperty("FkIcstockSlot")]
    public virtual ICollection<ArproposalItem> ArproposalItems { get; set; } = new List<ArproposalItem>();

    [InverseProperty("FkIcstockSlot")]
    public virtual ICollection<ArsaleForecastItem> ArsaleForecastItems { get; set; } = new List<ArsaleForecastItem>();

    [InverseProperty("FkIcstockSlot")]
    public virtual ICollection<ArsaleOrderItem> ArsaleOrderItems { get; set; } = new List<ArsaleOrderItem>();

    [InverseProperty("FkIcstockSlot")]
    public virtual ICollection<Brpositem> Brpositems { get; set; } = new List<Brpositem>();

    [InverseProperty("FkIcstockSlot")]
    public virtual ICollection<BrposredemptionItem> BrposredemptionItems { get; set; } = new List<BrposredemptionItem>();

    [InverseProperty("FkIcstockSlot")]
    public virtual ICollection<Brposs> Brposses { get; set; } = new List<Brposs>();

    [InverseProperty("FastockSlotIdcomboNavigation")]
    public virtual ICollection<FacreditNoteItem> FacreditNoteItems { get; set; } = new List<FacreditNoteItem>();

    [InverseProperty("FastockSlotIdcomboNavigation")]
    public virtual ICollection<FaproposalItem> FaproposalItems { get; set; } = new List<FaproposalItem>();

    [InverseProperty("FastockSlotIdcomboNavigation")]
    public virtual ICollection<FapurchaseOrderItem> FapurchaseOrderItems { get; set; } = new List<FapurchaseOrderItem>();

    [InverseProperty("FastockSlotIdcomboNavigation")]
    public virtual ICollection<FapurchaseOrder> FapurchaseOrders { get; set; } = new List<FapurchaseOrder>();

    [InverseProperty("FastockSlotIdcomboNavigation")]
    public virtual ICollection<FareturnSupplierItem> FareturnSupplierItems { get; set; } = new List<FareturnSupplierItem>();

    [InverseProperty("FastockSlotIdcomboNavigation")]
    public virtual ICollection<FasellReturnItem> FasellReturnItems { get; set; } = new List<FasellReturnItem>();

    [InverseProperty("FastockSlotIdcomboNavigation")]
    public virtual ICollection<FatransferStockInItem> FatransferStockInItems { get; set; } = new List<FatransferStockInItem>();

    [InverseProperty("FastockSlotIdcomboNavigation")]
    public virtual ICollection<FatransferStockOutItem> FatransferStockOutItems { get; set; } = new List<FatransferStockOutItem>();

    [ForeignKey("FkIcstockId")]
    [InverseProperty("IcstockSlots")]
    public virtual Icstock FkIcstock { get; set; }

    [InverseProperty("FkIcstockSlot")]
    public virtual ICollection<IcadjustmentItem> IcadjustmentItems { get; set; } = new List<IcadjustmentItem>();

    [InverseProperty("FkIcstockSlot")]
    public virtual ICollection<Icadjustment> Icadjustments { get; set; } = new List<Icadjustment>();

    [InverseProperty("FkIcstockSlot")]
    public virtual ICollection<IcinventoryStockCountItem> IcinventoryStockCountItems { get; set; } = new List<IcinventoryStockCountItem>();

    [InverseProperty("FkIcstockSlot")]
    public virtual ICollection<IcinventoryStockSlot> IcinventoryStockSlots { get; set; } = new List<IcinventoryStockSlot>();

    [InverseProperty("FkIcstockSlot")]
    public virtual ICollection<IcreceiptCditem> IcreceiptCditems { get; set; } = new List<IcreceiptCditem>();

    [InverseProperty("FkIcstockSlot")]
    public virtual ICollection<IcreceiptCd> IcreceiptCds { get; set; } = new List<IcreceiptCd>();

    [InverseProperty("FkIcstockSlot")]
    public virtual ICollection<IcshipmentItem> IcshipmentItems { get; set; } = new List<IcshipmentItem>();
}
