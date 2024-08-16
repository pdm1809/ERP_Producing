using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SampleProject.Data.Models;

[Table("APSupplierPaymentDetails")]
public partial class ApsupplierPaymentDetail
{
    [Key]
    [Column("APSupplierPaymentDetailID")]
    public int ApsupplierPaymentDetailId { get; set; }

    [Column("AAStatus")]
    [StringLength(50)]
    [Unicode(false)]
    public string Aastatus { get; set; }

    [Column("FK_APSupplierPaymentID")]
    public int FkApsupplierPaymentId { get; set; }

    [Required]
    [Column("APPaymentMethodCombo")]
    [StringLength(50)]
    [Unicode(false)]
    public string AppaymentMethodCombo { get; set; }

    [Column("APSupplierPaymentDetailAmount", TypeName = "decimal(18, 5)")]
    public decimal? ApsupplierPaymentDetailAmount { get; set; }

    [Column("APSupplierPaymentDetailInfo")]
    [StringLength(100)]
    public string ApsupplierPaymentDetailInfo { get; set; }

    [ForeignKey("FkApsupplierPaymentId")]
    [InverseProperty("ApsupplierPaymentDetails")]
    public virtual ApsupplierPayment FkApsupplierPayment { get; set; }
}
