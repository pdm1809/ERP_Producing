using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SampleProject.Data.Models;

[Table("ICPromotionItemDetails")]
[Microsoft.EntityFrameworkCore.Index("FkIcproductId", Name = "Idx_ICPromotionItemDetails")]
public partial class IcpromotionItemDetail
{
    [Key]
    [Column("ICPromotionItemDetailID")]
    public int IcpromotionItemDetailId { get; set; }

    [Column("AAStatus")]
    [StringLength(50)]
    [Unicode(false)]
    public string Aastatus { get; set; }

    [Column("FK_ICPromotionItemID")]
    public int FkIcpromotionItemId { get; set; }

    [Column("FK_ICProductID")]
    public int FkIcproductId { get; set; }

    [Column("ICPromotionItemDetailQty", TypeName = "decimal(18, 5)")]
    public decimal? IcpromotionItemDetailQty { get; set; }

    [Column("ICPromotionItemDetailUnitPrice", TypeName = "decimal(18, 5)")]
    public decimal? IcpromotionItemDetailUnitPrice { get; set; }

    [Column("ICPromotionItemDetailIncludeCheckPrice")]
    public bool? IcpromotionItemDetailIncludeCheckPrice { get; set; }

    [ForeignKey("FkIcproductId")]
    [InverseProperty("IcpromotionItemDetails")]
    public virtual Icproduct FkIcproduct { get; set; }

    [ForeignKey("FkIcpromotionItemId")]
    [InverseProperty("IcpromotionItemDetails")]
    public virtual IcpromotionItem FkIcpromotionItem { get; set; }
}
