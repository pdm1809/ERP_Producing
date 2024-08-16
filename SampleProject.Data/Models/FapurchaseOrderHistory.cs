using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SampleProject.Data.Models;

[Table("FAPurchaseOrderHistorys")]
[Microsoft.EntityFrameworkCore.Index("FapurchaseOrderHistoryDate", Name = "Idx_FAPurchaseOrderHistorys")]
public partial class FapurchaseOrderHistory
{
    [Key]
    [Column("FAPurchaseOrderHistoryID")]
    public int FapurchaseOrderHistoryId { get; set; }

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

    [Column("FAPurchaseOrderID")]
    public int? FapurchaseOrderId { get; set; }

    [Column("FASupplierID")]
    public int? FasupplierId { get; set; }

    [Column("FAUserID")]
    public int? FauserId { get; set; }

    [Column("FAUserName")]
    [StringLength(50)]
    public string FauserName { get; set; }

    [Column("FAPurchaseOrderHistoryDate", TypeName = "datetime")]
    public DateTime? FapurchaseOrderHistoryDate { get; set; }

    [Column("FAPurchaseOrderHistoryAction")]
    [StringLength(50)]
    public string FapurchaseOrderHistoryAction { get; set; }

    [Column("FAPurchaseOrderHistoryRelate")]
    [StringLength(50)]
    public string FapurchaseOrderHistoryRelate { get; set; }

    [Column("FAPurchaseOrderHistoryRelateID")]
    public int? FapurchaseOrderHistoryRelateId { get; set; }

    [Column("FAPurchaseOrderHistoryInfo")]
    [StringLength(100)]
    public string FapurchaseOrderHistoryInfo { get; set; }

    [Column("FAPurchaseOrderHistoryComment")]
    [StringLength(200)]
    public string FapurchaseOrderHistoryComment { get; set; }

    [ForeignKey("FapurchaseOrderId")]
    [InverseProperty("FapurchaseOrderHistories")]
    public virtual FapurchaseOrder FapurchaseOrder { get; set; }

    [ForeignKey("FasupplierId")]
    [InverseProperty("FapurchaseOrderHistories")]
    public virtual Apsupplier Fasupplier { get; set; }

    [ForeignKey("FauserId")]
    [InverseProperty("FapurchaseOrderHistories")]
    public virtual Aduser Fauser { get; set; }
}
