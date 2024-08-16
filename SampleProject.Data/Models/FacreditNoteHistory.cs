using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SampleProject.Data.Models;

[Table("FACreditNoteHistorys")]
[Microsoft.EntityFrameworkCore.Index("FacreditNoteHistoryDate", Name = "Idx_FACreditNoteHistorys")]
public partial class FacreditNoteHistory
{
    [Key]
    [Column("FACreditNoteHistoryID")]
    public int FacreditNoteHistoryId { get; set; }

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

    [Column("FACreditNoteID")]
    public int? FacreditNoteId { get; set; }

    [Column("FACustomerID")]
    public int? FacustomerId { get; set; }

    [Column("FAUserID")]
    public int? FauserId { get; set; }

    [Column("FAUserName")]
    [StringLength(50)]
    public string FauserName { get; set; }

    [Column("FACreditNoteHistoryDate", TypeName = "datetime")]
    public DateTime? FacreditNoteHistoryDate { get; set; }

    [Column("FACreditNoteHistoryAction")]
    [StringLength(50)]
    public string FacreditNoteHistoryAction { get; set; }

    [Column("FACreditNoteHistoryRelate")]
    [StringLength(50)]
    public string FacreditNoteHistoryRelate { get; set; }

    [Column("FACreditNoteHistoryRelateID")]
    public int? FacreditNoteHistoryRelateId { get; set; }

    [Column("FACreditNoteHistoryInfo")]
    [StringLength(100)]
    public string FacreditNoteHistoryInfo { get; set; }

    [Column("FACreditNoteHistoryComment")]
    [StringLength(200)]
    public string FacreditNoteHistoryComment { get; set; }

    [ForeignKey("FacreditNoteId")]
    [InverseProperty("FacreditNoteHistories")]
    public virtual FacreditNote FacreditNote { get; set; }

    [ForeignKey("FacustomerId")]
    [InverseProperty("FacreditNoteHistories")]
    public virtual Arcustomer Facustomer { get; set; }

    [ForeignKey("FauserId")]
    [InverseProperty("FacreditNoteHistories")]
    public virtual Aduser Fauser { get; set; }
}
