using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SampleProject.Data.Models;

[Table("FAReturnSupplierHistorys")]
[Microsoft.EntityFrameworkCore.Index("FareturnSupplierHistoryDate", Name = "Idx_FAReturnSupplierHistorys")]
public partial class FareturnSupplierHistory
{
    [Key]
    [Column("FAReturnSupplierHistoryID")]
    public int FareturnSupplierHistoryId { get; set; }

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

    [Column("FAReturnSupplierID")]
    public int? FareturnSupplierId { get; set; }

    [Column("FASupplierID")]
    public int? FasupplierId { get; set; }

    [Column("FAUserID")]
    public int? FauserId { get; set; }

    [Column("FAUserName")]
    [StringLength(50)]
    public string FauserName { get; set; }

    [Column("FAReturnSupplierHistoryDate", TypeName = "datetime")]
    public DateTime? FareturnSupplierHistoryDate { get; set; }

    [Column("FAReturnSupplierHistoryAction")]
    [StringLength(50)]
    public string FareturnSupplierHistoryAction { get; set; }

    [Column("FAReturnSupplierHistoryRelate")]
    [StringLength(50)]
    public string FareturnSupplierHistoryRelate { get; set; }

    [Column("FAReturnSupplierHistoryRelateID")]
    public int? FareturnSupplierHistoryRelateId { get; set; }

    [Column("FAReturnSupplierHistoryInfo")]
    [StringLength(100)]
    public string FareturnSupplierHistoryInfo { get; set; }

    [Column("FAReturnSupplierHistoryComment")]
    [StringLength(200)]
    public string FareturnSupplierHistoryComment { get; set; }

    [ForeignKey("FareturnSupplierId")]
    [InverseProperty("FareturnSupplierHistories")]
    public virtual FareturnSupplier FareturnSupplier { get; set; }

    [ForeignKey("FasupplierId")]
    [InverseProperty("FareturnSupplierHistories")]
    public virtual Apsupplier Fasupplier { get; set; }

    [ForeignKey("FauserId")]
    [InverseProperty("FareturnSupplierHistories")]
    public virtual Aduser Fauser { get; set; }
}
