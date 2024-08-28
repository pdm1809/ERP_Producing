using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SampleProject.Data.Models;

[Table("FAProposalHistorys")]
[Microsoft.EntityFrameworkCore.Index("FaproposalHistoryDate", Name = "Idx_FAProposalHistorys")]
public partial class FaproposalHistory
{
    [Key]
    [Column("FAProposalHistoryID")]
    public int FaproposalHistoryId { get; set; }

    [Column("AANumberString")]
    [StringLength(50)]
    [Unicode(false)]
    public string AanumberString { get; set; }

    [Column("AANumberInt")]
    public int? AanumberInt { get; set; }

    [Column("AAStat")]
    [StringLength(10)]
    [Unicode(false)]
    public string Aastat { get; set; }

    [Column("FAProposalID")]
    public int? FaproposalId { get; set; }

    [Column("FACustomerID")]
    public int? FacustomerId { get; set; }

    [Column("FAUserID")]
    public int? FauserId { get; set; }

    [Column("FAUserName")]
    [StringLength(50)]
    public string FauserName { get; set; }

    [Column("FAProposalHistoryDate", TypeName = "datetime")]
    public DateTime? FaproposalHistoryDate { get; set; }

    [Column("FAProposalHistoryAction")]
    [StringLength(50)]
    public string FaproposalHistoryAction { get; set; }

    [Column("FAProposalHistoryRelate")]
    [StringLength(50)]
    public string FaproposalHistoryRelate { get; set; }

    [Column("FAProposalHistoryRelateID")]
    public int? FaproposalHistoryRelateId { get; set; }

    [Column("FAProposalHistoryInfo")]
    [StringLength(100)]
    public string FaproposalHistoryInfo { get; set; }

    [Column("FAProposalHistoryComment")]
    [StringLength(200)]
    public string FaproposalHistoryComment { get; set; }

    [ForeignKey("FacustomerId")]
    [InverseProperty("FaproposalHistories")]
    public virtual Arcustomer Facustomer { get; set; }

    [ForeignKey("FaproposalId")]
    [InverseProperty("FaproposalHistories")]
    public virtual Oeproposal Faproposal { get; set; }

    [ForeignKey("FauserId")]
    [InverseProperty("FaproposalHistories")]
    public virtual Aduser Fauser { get; set; }
}
