using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SampleProject.Data.Models;

[Table("APPurchaseOrderHistorys")]
[Microsoft.EntityFrameworkCore.Index("AppurchaseOrderHistoryDate", Name = "Idx_APPurchaseOrderHistorys")]
public partial class AppurchaseOrderHistory
{
    [Key]
    [Column("APPurchaseOrderHistoryID")]
    public int AppurchaseOrderHistoryId { get; set; }

    [Column("AAStatus")]
    [StringLength(10)]
    [Unicode(false)]
    public string Aastatus { get; set; }

    [Column("FK_APPurchaseOrderID")]
    public int? FkAppurchaseOrderId { get; set; }

    [Column("FK_APSupplierID")]
    public int? FkApsupplierId { get; set; }

    [Column("FK_ADUserID")]
    public int? FkAduserId { get; set; }

    [Column("APPurchaseOrderHistoryUserName")]
    [StringLength(50)]
    public string AppurchaseOrderHistoryUserName { get; set; }

    [Column("APPurchaseOrderHistoryDate", TypeName = "datetime")]
    public DateTime? AppurchaseOrderHistoryDate { get; set; }

    [Column("APPurchaseOrderHistoryAction")]
    [StringLength(50)]
    public string AppurchaseOrderHistoryAction { get; set; }

    [Column("APPurchaseOrderHistoryRelate")]
    [StringLength(50)]
    public string AppurchaseOrderHistoryRelate { get; set; }

    [Column("APPurchaseOrderHistoryRelateID")]
    public int? AppurchaseOrderHistoryRelateId { get; set; }

    [Column("APPurchaseOrderHistoryInfo")]
    [StringLength(100)]
    public string AppurchaseOrderHistoryInfo { get; set; }

    [Column("APPurchaseOrderHistoryComment")]
    [StringLength(200)]
    public string AppurchaseOrderHistoryComment { get; set; }

    [ForeignKey("FkAduserId")]
    [InverseProperty("AppurchaseOrderHistories")]
    public virtual Aduser FkAduser { get; set; }

    [ForeignKey("FkAppurchaseOrderId")]
    [InverseProperty("AppurchaseOrderHistories")]
    public virtual AppurchaseOrder FkAppurchaseOrder { get; set; }

    [ForeignKey("FkApsupplierId")]
    [InverseProperty("AppurchaseOrderHistories")]
    public virtual Apsupplier FkApsupplier { get; set; }
}
