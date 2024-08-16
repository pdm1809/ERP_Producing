using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SampleProject.Data.Models;

[Table("APFeePaymentItems")]
public partial class ApfeePaymentItem
{
    [Key]
    [Column("APFeePaymentItemID")]
    public int ApfeePaymentItemId { get; set; }

    [Column("AAStatus")]
    [StringLength(10)]
    [Unicode(false)]
    public string Aastatus { get; set; }

    [Column("AACreatedUser")]
    [StringLength(50)]
    public string AacreatedUser { get; set; }

    [Column("AACreatedDate", TypeName = "datetime")]
    public DateTime? AacreatedDate { get; set; }

    [Column("AAUpdatedUser")]
    [StringLength(50)]
    public string AaupdatedUser { get; set; }

    [Column("AAUpdatedDate", TypeName = "datetime")]
    public DateTime? AaupdatedDate { get; set; }

    [Column("FK_ACDocumentID")]
    public int? FkAcdocumentId { get; set; }

    [Column("FK_ICProductID")]
    public int? FkIcproductId { get; set; }

    [Column("FK_ACAccountID")]
    public int? FkAcaccountId { get; set; }

    [Column("APFeePaymentItemNo")]
    [StringLength(512)]
    public string ApfeePaymentItemNo { get; set; }

    [Column("APFeePaymentItemName")]
    [StringLength(512)]
    public string ApfeePaymentItemName { get; set; }

    [Column("APFeePaymentItemType")]
    [StringLength(512)]
    public string ApfeePaymentItemType { get; set; }

    [Column("APFeePaymentItemQty", TypeName = "decimal(18, 5)")]
    public decimal? ApfeePaymentItemQty { get; set; }

    [Column("APFeePaymentItemUnitCost", TypeName = "decimal(18, 5)")]
    public decimal? ApfeePaymentItemUnitCost { get; set; }

    [Column("APFeePaymentItemTotalCost", TypeName = "decimal(18, 5)")]
    public decimal? ApfeePaymentItemTotalCost { get; set; }

    [Column("APFeePaymentItemReferenceNo")]
    [StringLength(512)]
    public string ApfeePaymentItemReferenceNo { get; set; }

    [Column("APFeePaymentItemReferenceItemID")]
    public int? ApfeePaymentItemReferenceItemId { get; set; }

    [Column("APFeePaymentItemCostAttribution", TypeName = "decimal(18, 5)")]
    public decimal? ApfeePaymentItemCostAttribution { get; set; }

    [ForeignKey("FkAcaccountId")]
    [InverseProperty("ApfeePaymentItems")]
    public virtual Acaccount FkAcaccount { get; set; }

    [ForeignKey("FkAcdocumentId")]
    [InverseProperty("ApfeePaymentItems")]
    public virtual Acdocument FkAcdocument { get; set; }

    [ForeignKey("FkIcproductId")]
    [InverseProperty("ApfeePaymentItems")]
    public virtual Icproduct FkIcproduct { get; set; }
}
