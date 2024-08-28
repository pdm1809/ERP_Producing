using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SampleProject.Data.Models;

[Table("MMProposals")]
public partial class Mmproposal
{
    [Key]
    [Column("MMProposalID")]
    public int MmproposalId { get; set; }

    [Column("AACreatedDate", TypeName = "datetime")]
    public DateTime? AacreatedDate { get; set; }

    [Column("AACreatedUser")]
    [StringLength(50)]
    public string AacreatedUser { get; set; }

    [Column("AAUpdatedDate", TypeName = "datetime")]
    public DateTime? AaupdatedDate { get; set; }

    [Column("AAUpdatedUser")]
    [StringLength(50)]
    public string AaupdatedUser { get; set; }

    [Column("AAStatus")]
    [StringLength(50)]
    [Unicode(false)]
    public string Aastatus { get; set; }

    [Column("FK_HREmployeeID")]
    public int FkHremployeeId { get; set; }

    [Column("FK_BRBranchID")]
    public int FkBrbranchId { get; set; }

    [Column("FK_HRDepartmentRoomID")]
    public int? FkHrdepartmentRoomId { get; set; }

    [Column("FK_ARSaleOrderID")]
    public int? FkArsaleOrderId { get; set; }

    [Column("FK_ARCustomerID")]
    public int? FkArcustomerId { get; set; }

    [Column("FK_ICProductAttributeTTMTID")]
    public int? FkIcproductAttributeTtmtid { get; set; }

    [Required]
    [Column("MMProposalNo")]
    [StringLength(50)]
    public string MmproposalNo { get; set; }

    [Column("MMProposalName")]
    [StringLength(100)]
    public string MmproposalName { get; set; }

    [Column("MMProposalDesc")]
    [StringLength(512)]
    public string MmproposalDesc { get; set; }

    [Column("MMProposalComment")]
    [StringLength(512)]
    public string MmproposalComment { get; set; }

    [Column("MMProposalDate", TypeName = "datetime")]
    public DateTime MmproposalDate { get; set; }

    [Column("MMProposalSaleOrderDeliveryDate", TypeName = "datetime")]
    public DateTime? MmproposalSaleOrderDeliveryDate { get; set; }

    [Column("MMProposalType")]
    [StringLength(100)]
    [Unicode(false)]
    public string MmproposalType { get; set; }

    [Column("MMPriority")]
    [StringLength(50)]
    public string Mmpriority { get; set; }

    [Column("MMShippingType")]
    [StringLength(50)]
    public string MmshippingType { get; set; }

    [Column("MMProposalBatchStatus")]
    [StringLength(50)]
    public string MmproposalBatchStatus { get; set; }

    [Column("FK_MMOperationID")]
    public int? FkMmoperationId { get; set; }

    [Column("MMProposalPONo")]
    [StringLength(50)]
    public string MmproposalPono { get; set; }

    [Column("FK_ACObjectID")]
    public int? FkAcobjectId { get; set; }

    [Column("MMObjectType")]
    [StringLength(50)]
    [Unicode(false)]
    public string MmobjectType { get; set; }

    [ForeignKey("FkArcustomerId")]
    [InverseProperty("Mmproposals")]
    public virtual Arcustomer FkArcustomer { get; set; }

    [ForeignKey("FkArsaleOrderId")]
    [InverseProperty("Mmproposals")]
    public virtual ArsaleOrder FkArsaleOrder { get; set; }

    [ForeignKey("FkBrbranchId")]
    [InverseProperty("Mmproposals")]
    public virtual Brbranch FkBrbranch { get; set; }

    [ForeignKey("FkHrdepartmentRoomId")]
    [InverseProperty("Mmproposals")]
    public virtual HrdepartmentRoom FkHrdepartmentRoom { get; set; }

    [ForeignKey("FkHremployeeId")]
    [InverseProperty("Mmproposals")]
    public virtual Hremployee FkHremployee { get; set; }

    [ForeignKey("FkIcproductAttributeTtmtid")]
    [InverseProperty("Mmproposals")]
    public virtual IcproductAttribute FkIcproductAttributeTtmt { get; set; }

    [ForeignKey("FkMmoperationId")]
    [InverseProperty("Mmproposals")]
    public virtual Mmoperation FkMmoperation { get; set; }

    [InverseProperty("FkMmproposal")]
    public virtual ICollection<HrmanufactureTimeSheetItem> HrmanufactureTimeSheetItems { get; set; } = new List<HrmanufactureTimeSheetItem>();

    [InverseProperty("FkMmproposal")]
    public virtual ICollection<MmbatchProductItem> MmbatchProductItems { get; set; } = new List<MmbatchProductItem>();

    [InverseProperty("FkMmproposal")]
    public virtual ICollection<MmbatchProduct> MmbatchProducts { get; set; } = new List<MmbatchProduct>();

    [InverseProperty("FkMmproposal")]
    public virtual ICollection<MmproductPriceIncomplete> MmproductPriceIncompletes { get; set; } = new List<MmproductPriceIncomplete>();

    [InverseProperty("FkMmproposal")]
    public virtual ICollection<MmproductPrice> MmproductPrices { get; set; } = new List<MmproductPrice>();

    [InverseProperty("FkMmproposal")]
    public virtual ICollection<MmproductionCostDirectLaborCost> MmproductionCostDirectLaborCosts { get; set; } = new List<MmproductionCostDirectLaborCost>();

    [InverseProperty("FkMmproposal")]
    public virtual ICollection<MmproductionCostItem> MmproductionCostItems { get; set; } = new List<MmproductionCostItem>();

    [InverseProperty("FkMmproposal")]
    public virtual ICollection<MmproductionCostOverall> MmproductionCostOveralls { get; set; } = new List<MmproductionCostOverall>();

    [InverseProperty("FkMmproposal")]
    public virtual ICollection<MmproposalItem> MmproposalItems { get; set; } = new List<MmproposalItem>();

    [InverseProperty("FkMmproposal")]
    public virtual ICollection<MmproposalTemplate> MmproposalTemplates { get; set; } = new List<MmproposalTemplate>();
}
