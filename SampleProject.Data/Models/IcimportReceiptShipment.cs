using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SampleProject.Data.Models;

[Table("ICImportReceiptShipments")]
public partial class IcimportReceiptShipment
{
    [Key]
    [Column("ICImportReceiptShipmentID")]
    public int IcimportReceiptShipmentId { get; set; }

    [Column("FK_MMBatchProductID")]
    public int? FkMmbatchProductId { get; set; }

    [Column("MMBatchProductNo")]
    [StringLength(50)]
    public string MmbatchProductNo { get; set; }

    [Column("FK_MMOperationID")]
    public int? FkMmoperationId { get; set; }

    [Column("MMOperationName")]
    [StringLength(216)]
    public string MmoperationName { get; set; }

    [Column("FK_ICProductForBatchID")]
    public int? FkIcproductForBatchId { get; set; }

    [Column("ICProductForBatchNo")]
    [StringLength(50)]
    public string IcproductForBatchNo { get; set; }

    [Column("FK_ICStockID")]
    public int? FkIcstockId { get; set; }

    [Column("ICStockName")]
    [StringLength(256)]
    public string IcstockName { get; set; }

    [Column("FK_ICProductID")]
    public int? FkIcproductId { get; set; }

    [Column("ICProductNo")]
    [StringLength(50)]
    public string IcproductNo { get; set; }

    [Column("ICProductQty", TypeName = "decimal(18, 5)")]
    public decimal? IcproductQty { get; set; }

    [Column("FK_ACDebitAccountID")]
    public int? FkAcdebitAccountId { get; set; }

    [Column("ACDebitAccountNo")]
    [StringLength(50)]
    public string AcdebitAccountNo { get; set; }

    [Column("FK_ACCreditAccountID")]
    public int? FkAccreditAccountId { get; set; }

    [Column("ACCreditAccountNo")]
    [StringLength(50)]
    public string AccreditAccountNo { get; set; }

    [Column("ICImportReceiptShipmentType")]
    [StringLength(50)]
    public string IcimportReceiptShipmentType { get; set; }

    [Column("ICImportReceiptShipmentDate", TypeName = "datetime")]
    public DateTime? IcimportReceiptShipmentDate { get; set; }

    public bool? HasImport { get; set; }

    [Column("MMBatchProductItemProductSerial")]
    [StringLength(50)]
    public string MmbatchProductItemProductSerial { get; set; }

    [Column("FK_ARCustomerID")]
    public int? FkArcustomerId { get; set; }

    [Column("FK_MMBatchProductProductionNormItemID")]
    public int? FkMmbatchProductProductionNormItemId { get; set; }

    [Column("FK_MMBatchProductItemID")]
    public int? FkMmbatchProductItemId { get; set; }

    [Column("FK_ICReceiptID")]
    public int? FkIcreceiptId { get; set; }

    [Column("FK_ICReceiptItemID")]
    public int? FkIcreceiptItemId { get; set; }

    [Column("FK_ICProductSerieID")]
    public int? FkIcproductSerieId { get; set; }

    [Column("AAStatus")]
    [StringLength(50)]
    public string Aastatus { get; set; }
}
