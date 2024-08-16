using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SampleProject.Data.Models;

[Table("APPaymentVoucherItemDetails")]
public partial class AppaymentVoucherItemDetail
{
    [Key]
    [Column("APPaymentVoucherItemDetailID")]
    public int AppaymentVoucherItemDetailId { get; set; }

    [Column("AAStatus")]
    [StringLength(50)]
    [Unicode(false)]
    public string Aastatus { get; set; }

    [Column("FK_APPaymentVoucherID")]
    public int FkAppaymentVoucherId { get; set; }

    [Column("FK_APBillOfLadingID")]
    public int? FkApbillOfLadingId { get; set; }

    [ForeignKey("FkApbillOfLadingId")]
    [InverseProperty("AppaymentVoucherItemDetails")]
    public virtual ApbillOfLading FkApbillOfLading { get; set; }

    [ForeignKey("FkAppaymentVoucherId")]
    [InverseProperty("AppaymentVoucherItemDetails")]
    public virtual AppaymentVoucher FkAppaymentVoucher { get; set; }
}
