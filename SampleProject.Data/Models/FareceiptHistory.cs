using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SampleProject.Data.Models;

[Table("FAReceiptHistorys")]
[Microsoft.EntityFrameworkCore.Index("FareceiptHistoryDate", Name = "Idx_FAReceiptHistorys")]
public partial class FareceiptHistory
{
    [Key]
    [Column("FAReceiptHistoryID")]
    public int FareceiptHistoryId { get; set; }

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

    [Column("FAReceiptID")]
    public int? FareceiptId { get; set; }

    [Column("FASupplierID")]
    public int? FasupplierId { get; set; }

    [Column("FAUserID")]
    public int? FauserId { get; set; }

    [Column("FAUserName")]
    [StringLength(50)]
    public string FauserName { get; set; }

    [Column("FAReceiptHistoryDate", TypeName = "datetime")]
    public DateTime? FareceiptHistoryDate { get; set; }

    [Column("FAReceiptHistoryAction")]
    [StringLength(50)]
    public string FareceiptHistoryAction { get; set; }

    [Column("FAReceiptHistoryRelate")]
    [StringLength(50)]
    public string FareceiptHistoryRelate { get; set; }

    [Column("FAReceiptHistoryRelateID")]
    public int? FareceiptHistoryRelateId { get; set; }

    [Column("FAReceiptHistoryInfo")]
    [StringLength(100)]
    public string FareceiptHistoryInfo { get; set; }

    [Column("FAReceiptHistoryComment")]
    [StringLength(200)]
    public string FareceiptHistoryComment { get; set; }

    [ForeignKey("FareceiptId")]
    [InverseProperty("FareceiptHistories")]
    public virtual Icreceipt Fareceipt { get; set; }

    [ForeignKey("FasupplierId")]
    [InverseProperty("FareceiptHistories")]
    public virtual Apsupplier Fasupplier { get; set; }

    [ForeignKey("FauserId")]
    [InverseProperty("FareceiptHistories")]
    public virtual Aduser Fauser { get; set; }
}
