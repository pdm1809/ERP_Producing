using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SampleProject.Data.Models;

[Table("ARProposalAreas")]
public partial class ArproposalArea
{
    [Key]
    [Column("ARProposalAreaID")]
    public int ArproposalAreaId { get; set; }

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

    [Column("ARProposalAreaNo")]
    [StringLength(50)]
    public string ArproposalAreaNo { get; set; }

    [Column("ARProposalAreaName")]
    [StringLength(256)]
    public string ArproposalAreaName { get; set; }

    [Column("ARProposalAreaDesc")]
    [StringLength(512)]
    public string ArproposalAreaDesc { get; set; }

    [Column("ARProposalAreaStatus")]
    [StringLength(50)]
    [Unicode(false)]
    public string ArproposalAreaStatus { get; set; }

    [Column("ARProposalAreaDate", TypeName = "datetime")]
    public DateTime? ArproposalAreaDate { get; set; }

    [Column("FK_ICProductID")]
    public int FkIcproductId { get; set; }

    [Column("FK_ARProposalID")]
    public int? FkArproposalId { get; set; }

    [Column("FK_ARProposalItemID")]
    public int? FkArproposalItemId { get; set; }

    [Column("FK_ICProductTemplateID")]
    public int? FkIcproductTemplateId { get; set; }

    [InverseProperty("FkArproposalArea")]
    public virtual ICollection<ArproposalAreaItem> ArproposalAreaItems { get; set; } = new List<ArproposalAreaItem>();

    [ForeignKey("FkArproposalId")]
    [InverseProperty("ArproposalAreas")]
    public virtual Arproposal FkArproposal { get; set; }

    [ForeignKey("FkArproposalItemId")]
    [InverseProperty("ArproposalAreas")]
    public virtual ArproposalItem FkArproposalItem { get; set; }

    [ForeignKey("FkIcproductId")]
    [InverseProperty("ArproposalAreas")]
    public virtual Icproduct FkIcproduct { get; set; }

    [ForeignKey("FkIcproductTemplateId")]
    [InverseProperty("ArproposalAreas")]
    public virtual IcproductTemplate FkIcproductTemplate { get; set; }
}
