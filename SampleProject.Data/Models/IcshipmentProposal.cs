using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SampleProject.Data.Models;

[Table("ICShipmentProposals")]
public partial class IcshipmentProposal
{
    [Key]
    [Column("ICShipmentProposalID")]
    public int IcshipmentProposalId { get; set; }

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

    [Column("FK_BRBranchID")]
    public int? FkBrbranchId { get; set; }

    [Column("FK_HREmployeeID")]
    public int? FkHremployeeId { get; set; }

    [Column("FK_HRApprovedEmployeeID")]
    public int? FkHrapprovedEmployeeId { get; set; }

    [Column("FK_HRDiscardEmployeeID")]
    public int? FkHrdiscardEmployeeId { get; set; }

    [Column("FK_HRProposalEmployeeID")]
    public int? FkHrproposalEmployeeId { get; set; }

    [Required]
    [Column("ICShipmentProposalNo")]
    [StringLength(50)]
    public string IcshipmentProposalNo { get; set; }

    [Column("ICShipmentProposalName")]
    [StringLength(100)]
    public string IcshipmentProposalName { get; set; }

    [Column("ICShipmentProposalDesc")]
    [StringLength(512)]
    public string IcshipmentProposalDesc { get; set; }

    [Column("ICShipmentProposalDate", TypeName = "datetime")]
    public DateTime IcshipmentProposalDate { get; set; }

    [Column("ICShipmentProposalReference")]
    [StringLength(512)]
    public string IcshipmentProposalReference { get; set; }

    [Column("ICShipmentProposalApprovedDate", TypeName = "datetime")]
    public DateTime? IcshipmentProposalApprovedDate { get; set; }

    [Column("ICShipmentProposalDiscardDate", TypeName = "datetime")]
    public DateTime? IcshipmentProposalDiscardDate { get; set; }

    [Column("ICShipmentProposalType")]
    [StringLength(50)]
    [Unicode(false)]
    public string IcshipmentProposalType { get; set; }

    [Column("ICShipmentProposalStatus")]
    [StringLength(50)]
    [Unicode(false)]
    public string IcshipmentProposalStatus { get; set; }

    public bool? IsTransferred { get; set; }

    [Column("ICShipmentProposalTransferredDate", TypeName = "datetime")]
    public DateTime? IcshipmentProposalTransferredDate { get; set; }

    [Column("ICPriority")]
    [StringLength(50)]
    public string Icpriority { get; set; }

    [Column("ICShipmentProposalDeliveryDate", TypeName = "datetime")]
    public DateTime? IcshipmentProposalDeliveryDate { get; set; }

    [Column("ICShipmentProposalActualDeliveryDate", TypeName = "datetime")]
    public DateTime? IcshipmentProposalActualDeliveryDate { get; set; }

    [Column("FK_ARCustomerID")]
    public int? FkArcustomerId { get; set; }

    [Column("ICShipmentProposalVehicle")]
    [StringLength(512)]
    public string IcshipmentProposalVehicle { get; set; }

    [Column("ICShipmentProposalProductType")]
    [StringLength(50)]
    public string IcshipmentProposalProductType { get; set; }

    [Column("FK_MMBatchProductID")]
    public int? FkMmbatchProductId { get; set; }

    [Column("FK_ICProductAttributeTTMTID")]
    public int? FkIcproductAttributeTtmtid { get; set; }

    [Column("FK_ICStockID")]
    public int? FkIcstockId { get; set; }

    [Column("ICShipmentProposalPONo")]
    [StringLength(50)]
    public string IcshipmentProposalPono { get; set; }

    [Column("FK_ACObjectID")]
    public int? FkAcobjectId { get; set; }

    [Column("ICObjectType")]
    [StringLength(50)]
    [Unicode(false)]
    public string IcobjectType { get; set; }

    [ForeignKey("FkArcustomerId")]
    [InverseProperty("IcshipmentProposals")]
    public virtual Arcustomer FkArcustomer { get; set; }

    [ForeignKey("FkBrbranchId")]
    [InverseProperty("IcshipmentProposals")]
    public virtual Brbranch FkBrbranch { get; set; }

    [ForeignKey("FkHrapprovedEmployeeId")]
    [InverseProperty("IcshipmentProposalFkHrapprovedEmployees")]
    public virtual Hremployee FkHrapprovedEmployee { get; set; }

    [ForeignKey("FkHrdiscardEmployeeId")]
    [InverseProperty("IcshipmentProposalFkHrdiscardEmployees")]
    public virtual Hremployee FkHrdiscardEmployee { get; set; }

    [ForeignKey("FkHremployeeId")]
    [InverseProperty("IcshipmentProposalFkHremployees")]
    public virtual Hremployee FkHremployee { get; set; }

    [ForeignKey("FkHrproposalEmployeeId")]
    [InverseProperty("IcshipmentProposalFkHrproposalEmployees")]
    public virtual Hremployee FkHrproposalEmployee { get; set; }

    [ForeignKey("FkIcproductAttributeTtmtid")]
    [InverseProperty("IcshipmentProposals")]
    public virtual IcproductAttribute FkIcproductAttributeTtmt { get; set; }

    [ForeignKey("FkIcstockId")]
    [InverseProperty("IcshipmentProposals")]
    public virtual Icstock FkIcstock { get; set; }

    [ForeignKey("FkMmbatchProductId")]
    [InverseProperty("IcshipmentProposals")]
    public virtual MmbatchProduct FkMmbatchProduct { get; set; }

    [InverseProperty("FkIcshipmentProposal")]
    public virtual ICollection<IcshipmentItem> IcshipmentItems { get; set; } = new List<IcshipmentItem>();

    [InverseProperty("FkIcshipmentProposal")]
    public virtual ICollection<IcshipmentProposalItem> IcshipmentProposalItems { get; set; } = new List<IcshipmentProposalItem>();
}
