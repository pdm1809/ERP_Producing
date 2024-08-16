using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SampleProject.Data.Models;

[Table("ACAccountingBills")]
public partial class AcaccountingBill
{
    [Key]
    [Column("ACAccountingBillID")]
    public int AcaccountingBillId { get; set; }

    [Column("AAStatus")]
    [StringLength(50)]
    [Unicode(false)]
    public string Aastatus { get; set; }

    [Column("FK_ACDocumentID")]
    public int? FkAcdocumentId { get; set; }

    [Column("FK_ACDebitAccountID")]
    public int? FkAcdebitAccountId { get; set; }

    [Column("FK_ACCreditAccountID")]
    public int? FkAccreditAccountId { get; set; }

    [Column("ACAccountingBillAmount", TypeName = "decimal(18, 5)")]
    public decimal? AcaccountingBillAmount { get; set; }

    [Column("ACAccountingBillExchangeAmount", TypeName = "decimal(18, 5)")]
    public decimal? AcaccountingBillExchangeAmount { get; set; }

    [Column("FK_ACCostCenterID")]
    public int? FkAccostCenterId { get; set; }

    [Column("FK_ACSegmentID")]
    public int? FkAcsegmentId { get; set; }

    [Column("ACAccountingBillDesc")]
    [StringLength(255)]
    public string AcaccountingBillDesc { get; set; }

    [Column("FK_HRDepartmentID")]
    public int? FkHrdepartmentId { get; set; }

    [Column("FK_HRDepartmentRoomID")]
    public int? FkHrdepartmentRoomId { get; set; }

    [Column("FK_ACCostObjectID")]
    public int? FkAccostObjectId { get; set; }

    [Column("FK_ACUnfinishedConstructionCostID")]
    public int? FkAcunfinishedConstructionCostId { get; set; }

    [Column("FK_PMProjectID")]
    public int? FkPmprojectId { get; set; }

    [Column("FK_ACDebitObjectID")]
    public int? FkAcdebitObjectId { get; set; }

    [Column("ACDebitObjectType")]
    [StringLength(128)]
    public string AcdebitObjectType { get; set; }

    [Column("FK_ACCreditObjectID")]
    public int? FkAccreditObjectId { get; set; }

    [Column("ACCreditObjectType")]
    [StringLength(128)]
    public string AccreditObjectType { get; set; }

    [Column("ACAccountingBillVATDocumentType")]
    [StringLength(128)]
    public string AcaccountingBillVatdocumentType { get; set; }

    [Column("ACAccountingBillVoucherNo")]
    [StringLength(128)]
    public string AcaccountingBillVoucherNo { get; set; }

    [Column("ACAccountingBillVATInvoiceNo")]
    [StringLength(128)]
    public string AcaccountingBillVatinvoiceNo { get; set; }

    [Column("ACAccountingBillVATFormNo")]
    [StringLength(128)]
    public string AcaccountingBillVatformNo { get; set; }

    [Column("ACAccountingBillVATSymbol")]
    [StringLength(128)]
    public string AcaccountingBillVatsymbol { get; set; }

    [Column("ACAccountingBillInvoiceDate", TypeName = "datetime")]
    public DateTime? AcaccountingBillInvoiceDate { get; set; }

    [Column("FK_VMVehicleID")]
    public int? FkVmvehicleId { get; set; }

    [Column("ACAccountingBillTaxPercent")]
    public int? AcaccountingBillTaxPercent { get; set; }

    [Column("ACAccountingBillTaxAmount", TypeName = "decimal(18, 5)")]
    public decimal? AcaccountingBillTaxAmount { get; set; }

    [Column("ACAccountingBillTaxNumber")]
    [StringLength(50)]
    [Unicode(false)]
    public string AcaccountingBillTaxNumber { get; set; }

    [Column("ACAccountingBillEndDate", TypeName = "datetime")]
    public DateTime? AcaccountingBillEndDate { get; set; }

    [Column("FK_ARSaleOrderID")]
    public int? FkArsaleOrderId { get; set; }

    [Column("FK_MMBatchProductID")]
    public int? FkMmbatchProductId { get; set; }

    [Column("FK_ICProductID")]
    public int? FkIcproductId { get; set; }

    [Column("FK_ACEInvoiceTypeID")]
    public int? FkAceinvoiceTypeId { get; set; }

    [Column("ACAccountingBillTotalAmount", TypeName = "decimal(18, 5)")]
    public decimal? AcaccountingBillTotalAmount { get; set; }

    [Column("FK_ACLoanReceiptID")]
    public int? FkAcloanReceiptId { get; set; }

    [ForeignKey("FkAccostCenterId")]
    [InverseProperty("AcaccountingBills")]
    public virtual AccostCenter FkAccostCenter { get; set; }

    [ForeignKey("FkAccostObjectId")]
    [InverseProperty("AcaccountingBills")]
    public virtual AccostObject FkAccostObject { get; set; }

    [ForeignKey("FkAccreditAccountId")]
    [InverseProperty("AcaccountingBillFkAccreditAccounts")]
    public virtual Acaccount FkAccreditAccount { get; set; }

    [ForeignKey("FkAcdebitAccountId")]
    [InverseProperty("AcaccountingBillFkAcdebitAccounts")]
    public virtual Acaccount FkAcdebitAccount { get; set; }

    [ForeignKey("FkAcdocumentId")]
    [InverseProperty("AcaccountingBills")]
    public virtual Acdocument FkAcdocument { get; set; }

    [ForeignKey("FkAceinvoiceTypeId")]
    [InverseProperty("AcaccountingBills")]
    public virtual AceinvoiceType FkAceinvoiceType { get; set; }

    [ForeignKey("FkAcloanReceiptId")]
    [InverseProperty("AcaccountingBills")]
    public virtual AcloanReceipt FkAcloanReceipt { get; set; }

    [ForeignKey("FkAcsegmentId")]
    [InverseProperty("AcaccountingBills")]
    public virtual Acsegment FkAcsegment { get; set; }

    [ForeignKey("FkAcunfinishedConstructionCostId")]
    [InverseProperty("AcaccountingBills")]
    public virtual AcunfinishedConstructionCost FkAcunfinishedConstructionCost { get; set; }

    [ForeignKey("FkArsaleOrderId")]
    [InverseProperty("AcaccountingBills")]
    public virtual ArsaleOrder FkArsaleOrder { get; set; }

    [ForeignKey("FkHrdepartmentId")]
    [InverseProperty("AcaccountingBills")]
    public virtual Hrdepartment FkHrdepartment { get; set; }

    [ForeignKey("FkHrdepartmentRoomId")]
    [InverseProperty("AcaccountingBills")]
    public virtual HrdepartmentRoom FkHrdepartmentRoom { get; set; }

    [ForeignKey("FkIcproductId")]
    [InverseProperty("AcaccountingBills")]
    public virtual Icproduct FkIcproduct { get; set; }

    [ForeignKey("FkMmbatchProductId")]
    [InverseProperty("AcaccountingBills")]
    public virtual MmbatchProduct FkMmbatchProduct { get; set; }

    [ForeignKey("FkPmprojectId")]
    [InverseProperty("AcaccountingBills")]
    public virtual Pmproject FkPmproject { get; set; }

    [ForeignKey("FkVmvehicleId")]
    [InverseProperty("AcaccountingBills")]
    public virtual Vmvehicle FkVmvehicle { get; set; }
}
