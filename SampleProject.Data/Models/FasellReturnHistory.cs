using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SampleProject.Data.Models;

[Table("FASellReturnHistorys")]
[Microsoft.EntityFrameworkCore.Index("FasellReturnHistoryDate", Name = "Idx_FASellReturnHistorys")]
public partial class FasellReturnHistory
{
    [Key]
    [Column("FASellReturnHistoryID")]
    public int FasellReturnHistoryId { get; set; }

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

    [Column("FASellReturnID")]
    public int? FasellReturnId { get; set; }

    [Column("FACustomerID")]
    public int? FacustomerId { get; set; }

    [Column("FAUserID")]
    public int? FauserId { get; set; }

    [Column("FAUserName")]
    [StringLength(50)]
    public string FauserName { get; set; }

    [Column("FASellReturnHistoryDate", TypeName = "datetime")]
    public DateTime? FasellReturnHistoryDate { get; set; }

    [Column("FASellReturnHistoryAction")]
    [StringLength(50)]
    public string FasellReturnHistoryAction { get; set; }

    [Column("FASellReturnHistoryRelate")]
    [StringLength(50)]
    public string FasellReturnHistoryRelate { get; set; }

    [Column("FASellReturnHistoryRelateID")]
    public int? FasellReturnHistoryRelateId { get; set; }

    [Column("FASellReturnHistoryInfo")]
    [StringLength(100)]
    public string FasellReturnHistoryInfo { get; set; }

    [Column("FASellReturnHistoryComment")]
    [StringLength(200)]
    public string FasellReturnHistoryComment { get; set; }

    [ForeignKey("FacustomerId")]
    [InverseProperty("FasellReturnHistories")]
    public virtual Arcustomer Facustomer { get; set; }

    [ForeignKey("FasellReturnId")]
    [InverseProperty("FasellReturnHistories")]
    public virtual FasellReturn FasellReturn { get; set; }

    [ForeignKey("FauserId")]
    [InverseProperty("FasellReturnHistories")]
    public virtual Aduser Fauser { get; set; }
}
