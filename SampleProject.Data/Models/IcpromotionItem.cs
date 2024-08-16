using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SampleProject.Data.Models;

[Table("ICPromotionItems")]
[Microsoft.EntityFrameworkCore.Index("FkIcproductId", "FkIcpromotionId", Name = "Idx_ICPromotionItems")]
public partial class IcpromotionItem
{
    [Key]
    [Column("ICPromotionItemID")]
    public int IcpromotionItemId { get; set; }

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

    [Column("AAStatus")]
    [StringLength(50)]
    [Unicode(false)]
    public string Aastatus { get; set; }

    [Column("FK_ICPromotionID")]
    public int FkIcpromotionId { get; set; }

    [Column("FK_ICDepartmentID")]
    public int? FkIcdepartmentId { get; set; }

    [Column("FK_ICProductGroupID")]
    public int? FkIcproductGroupId { get; set; }

    [Column("FK_ICProductID")]
    public int? FkIcproductId { get; set; }

    [Column("ICPromotionItemProductSerialNo")]
    [StringLength(50)]
    public string IcpromotionItemProductSerialNo { get; set; }

    [Column("ICPromotionItemProductAttribute")]
    [StringLength(200)]
    public string IcpromotionItemProductAttribute { get; set; }

    [Column("ICPromotionItemProductName")]
    [StringLength(50)]
    public string IcpromotionItemProductName { get; set; }

    [Column("ICPromotionItemProductDesc")]
    [StringLength(512)]
    public string IcpromotionItemProductDesc { get; set; }

    [ForeignKey("FkIcdepartmentId")]
    [InverseProperty("IcpromotionItems")]
    public virtual Icdepartment FkIcdepartment { get; set; }

    [ForeignKey("FkIcproductId")]
    [InverseProperty("IcpromotionItems")]
    public virtual Icproduct FkIcproduct { get; set; }

    [ForeignKey("FkIcproductGroupId")]
    [InverseProperty("IcpromotionItems")]
    public virtual IcproductGroup FkIcproductGroup { get; set; }

    [ForeignKey("FkIcpromotionId")]
    [InverseProperty("IcpromotionItems")]
    public virtual Icpromotion FkIcpromotion { get; set; }

    [InverseProperty("FkIcpromotionItem")]
    public virtual ICollection<IcpromotionItemDetail> IcpromotionItemDetails { get; set; } = new List<IcpromotionItemDetail>();
}
