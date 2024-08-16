using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SampleProject.Data.Models;

[Table("ICConversionProposals")]
public partial class IcconversionProposal
{
    [Key]
    [Column("ICConversionProposalID")]
    public int IcconversionProposalId { get; set; }

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
    [StringLength(10)]
    [Unicode(false)]
    public string Aastatus { get; set; }

    [Column("FK_ICStockID")]
    public int FkIcstockId { get; set; }

    [Column("FK_BRBranchID")]
    public int? FkBrbranchId { get; set; }

    [Column("FK_HREmployeeID")]
    public int FkHremployeeId { get; set; }

    [Required]
    [Column("ICConversionProposalNo")]
    [StringLength(50)]
    public string IcconversionProposalNo { get; set; }

    [Column("ICConversionProposalName")]
    [StringLength(100)]
    public string IcconversionProposalName { get; set; }

    [Column("ICConversionProposalDesc")]
    [StringLength(512)]
    public string IcconversionProposalDesc { get; set; }

    [Column("ICConversionProposalDate", TypeName = "datetime")]
    public DateTime? IcconversionProposalDate { get; set; }

    [Column("ICConversionProposalStatus")]
    [StringLength(50)]
    [Unicode(false)]
    public string IcconversionProposalStatus { get; set; }

    [Column("ICConversionProposalEmployeeRecever")]
    [StringLength(512)]
    public string IcconversionProposalEmployeeRecever { get; set; }

    [Column("FK_MMWorkShopID")]
    public int? FkMmworkShopId { get; set; }

    [Column("FK_MMLineID")]
    public int? FkMmlineId { get; set; }

    [Column("FK_HRDepartmentRoomGroupItemID")]
    public int? FkHrdepartmentRoomGroupItemId { get; set; }

    [Column("FK_MMOperationID")]
    public int? FkMmoperationId { get; set; }

    [ForeignKey("FkBrbranchId")]
    [InverseProperty("IcconversionProposals")]
    public virtual Brbranch FkBrbranch { get; set; }

    [ForeignKey("FkHrdepartmentRoomGroupItemId")]
    [InverseProperty("IcconversionProposals")]
    public virtual HrdepartmentRoomGroupItem FkHrdepartmentRoomGroupItem { get; set; }

    [ForeignKey("FkHremployeeId")]
    [InverseProperty("IcconversionProposals")]
    public virtual Hremployee FkHremployee { get; set; }

    [ForeignKey("FkIcstockId")]
    [InverseProperty("IcconversionProposals")]
    public virtual Icstock FkIcstock { get; set; }

    [ForeignKey("FkMmlineId")]
    [InverseProperty("IcconversionProposals")]
    public virtual Mmline FkMmline { get; set; }

    [ForeignKey("FkMmoperationId")]
    [InverseProperty("IcconversionProposals")]
    public virtual Mmoperation FkMmoperation { get; set; }

    [ForeignKey("FkMmworkShopId")]
    [InverseProperty("IcconversionProposals")]
    public virtual MmworkShop FkMmworkShop { get; set; }

    [InverseProperty("FkIcconversionProposal")]
    public virtual ICollection<IcconversionProposalItem> IcconversionProposalItems { get; set; } = new List<IcconversionProposalItem>();

    [InverseProperty("FkIcconversionProposal")]
    public virtual ICollection<IcproductConversionItem> IcproductConversionItems { get; set; } = new List<IcproductConversionItem>();
}
