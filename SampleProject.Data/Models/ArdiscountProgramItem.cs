using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SampleProject.Data.Models;

[Table("ARDiscountProgramItems")]
public partial class ArdiscountProgramItem
{
    [Key]
    [Column("ARDiscountProgramItemID")]
    public int ArdiscountProgramItemId { get; set; }

    [Column("AAStatus")]
    [StringLength(10)]
    [Unicode(false)]
    public string Aastatus { get; set; }

    [Column("AACreatedUser")]
    [StringLength(50)]
    public string AacreatedUser { get; set; }

    [Column("AAUpdatedUser")]
    [StringLength(50)]
    public string AaupdatedUser { get; set; }

    [Column("AACreatedDate", TypeName = "datetime")]
    public DateTime? AacreatedDate { get; set; }

    [Column("AAUpdatedDate", TypeName = "datetime")]
    public DateTime? AaupdatedDate { get; set; }

    [Column("FK_ICProductID")]
    public int? FkIcproductId { get; set; }

    [Column("FK_ARDiscountProgramID")]
    public int? FkArdiscountProgramId { get; set; }

    [Column("ARDiscountProgramItemProductName")]
    [StringLength(256)]
    public string ArdiscountProgramItemProductName { get; set; }

    [Column("ARDiscountProgramItemProductDesc")]
    [StringLength(1024)]
    public string ArdiscountProgramItemProductDesc { get; set; }

    [Column("ARDiscountProgramItemProductType")]
    [StringLength(50)]
    public string ArdiscountProgramItemProductType { get; set; }

    [Column("ARDiscountProgramItemApplyOn")]
    [StringLength(50)]
    public string ArdiscountProgramItemApplyOn { get; set; }

    [Column("ARDiscountProgramItemBasicPrice", TypeName = "decimal(18, 5)")]
    public decimal? ArdiscountProgramItemBasicPrice { get; set; }

    [Column("ARDiscountProgramItemProductUnitPrice", TypeName = "decimal(18, 5)")]
    public decimal? ArdiscountProgramItemProductUnitPrice { get; set; }

    [Column("ARDiscountProgramItemValue", TypeName = "decimal(18, 5)")]
    public decimal? ArdiscountProgramItemValue { get; set; }

    [Column("ARDiscountProgramItemIsExhibit")]
    public bool? ArdiscountProgramItemIsExhibit { get; set; }

    [Column("ARDiscountProgramItemPriorityQty", TypeName = "decimal(18, 5)")]
    public decimal? ArdiscountProgramItemPriorityQty { get; set; }

    [Column("ARDiscountProgramItemPriorityPrice", TypeName = "decimal(18, 5)")]
    public decimal? ArdiscountProgramItemPriorityPrice { get; set; }

    [Column("ARDiscountProgramItemBonusAmount", TypeName = "decimal(18, 5)")]
    public decimal? ArdiscountProgramItemBonusAmount { get; set; }

    [Column("ARDiscountProgramItemProductNoOfOldSys")]
    [StringLength(100)]
    public string ArdiscountProgramItemProductNoOfOldSys { get; set; }

    [Column("ARDiscountProgramItemProductCustomerNumber")]
    [StringLength(50)]
    public string ArdiscountProgramItemProductCustomerNumber { get; set; }

    [ForeignKey("FkArdiscountProgramId")]
    [InverseProperty("ArdiscountProgramItems")]
    public virtual ArdiscountProgram FkArdiscountProgram { get; set; }

    [ForeignKey("FkIcproductId")]
    [InverseProperty("ArdiscountProgramItems")]
    public virtual Icproduct FkIcproduct { get; set; }
}
