using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SampleProject.Data.Models;

[Table("ARReceiptVoucherItems")]
[Microsoft.EntityFrameworkCore.Index("FkArreceiptVoucherId", Name = "Idx_ARReceiptVoucherItems")]
public partial class ArreceiptVoucherItem
{
    [Key]
    [Column("ARReceiptVoucherItemID")]
    public int ArreceiptVoucherItemId { get; set; }

    [Column("AAStatus")]
    [StringLength(50)]
    [Unicode(false)]
    public string Aastatus { get; set; }

    [Column("FK_ARReceiptVoucherID")]
    public int FkArreceiptVoucherId { get; set; }

    [Column("FK_ACEntryTypeID")]
    public int FkAcentryTypeId { get; set; }

    [Column("FK_ACDebitAccountID")]
    public int? FkAcdebitAccountId { get; set; }

    [Column("FK_ACCreditAccountID")]
    public int? FkAccreditAccountId { get; set; }

    [Required]
    [Column("ARReceiptVoucherItemDesc")]
    [StringLength(512)]
    public string ArreceiptVoucherItemDesc { get; set; }

    [Column("ARReceiptVoucherItemAmount", TypeName = "decimal(18, 5)")]
    public decimal? ArreceiptVoucherItemAmount { get; set; }

    [Column("ARReceiptVoucherItemExchangeAmount", TypeName = "decimal(18, 5)")]
    public decimal? ArreceiptVoucherItemExchangeAmount { get; set; }

    [Column("FK_HRAdvanceRefundID")]
    public int? FkHradvanceRefundId { get; set; }

    [Column("ARReceiptVoucherItemReference")]
    [StringLength(50)]
    [Unicode(false)]
    public string ArreceiptVoucherItemReference { get; set; }

    [ForeignKey("FkAccreditAccountId")]
    [InverseProperty("ArreceiptVoucherItemFkAccreditAccounts")]
    public virtual Acaccount FkAccreditAccount { get; set; }

    [ForeignKey("FkAcdebitAccountId")]
    [InverseProperty("ArreceiptVoucherItemFkAcdebitAccounts")]
    public virtual Acaccount FkAcdebitAccount { get; set; }

    [ForeignKey("FkAcentryTypeId")]
    [InverseProperty("ArreceiptVoucherItems")]
    public virtual AcentryType FkAcentryType { get; set; }

    [ForeignKey("FkArreceiptVoucherId")]
    [InverseProperty("ArreceiptVoucherItems")]
    public virtual ArreceiptVoucher FkArreceiptVoucher { get; set; }

    [ForeignKey("FkHradvanceRefundId")]
    [InverseProperty("ArreceiptVoucherItems")]
    public virtual HradvanceRefund FkHradvanceRefund { get; set; }
}
