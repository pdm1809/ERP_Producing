using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SampleProject.Data.Models;

[Table("FATransferHistorys")]
[Microsoft.EntityFrameworkCore.Index("FatransferHistoryDate", Name = "Idx_FATransferHistorys")]
public partial class FatransferHistory
{
    [Key]
    [Column("FATransferHistoryID")]
    public int FatransferHistoryId { get; set; }

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

    [Column("FATransferID")]
    public int? FatransferId { get; set; }

    [Column("FAUserID")]
    public int? FauserId { get; set; }

    [Column("FAUserName")]
    [StringLength(50)]
    public string FauserName { get; set; }

    [Column("FATransferHistoryDate", TypeName = "datetime")]
    public DateTime? FatransferHistoryDate { get; set; }

    [Column("FATransferHistoryAction")]
    [StringLength(50)]
    public string FatransferHistoryAction { get; set; }

    [Column("FATransferHistoryRelate")]
    [StringLength(50)]
    public string FatransferHistoryRelate { get; set; }

    [Column("FATransferHistoryRelateID")]
    public int? FatransferHistoryRelateId { get; set; }

    [Column("FATransferHistoryInfo")]
    [StringLength(100)]
    public string FatransferHistoryInfo { get; set; }

    [Column("FATransferHistoryComment")]
    [StringLength(200)]
    public string FatransferHistoryComment { get; set; }

    [ForeignKey("FatransferId")]
    [InverseProperty("FatransferHistories")]
    public virtual Fatransfer Fatransfer { get; set; }

    [ForeignKey("FauserId")]
    [InverseProperty("FatransferHistories")]
    public virtual Aduser Fauser { get; set; }
}
