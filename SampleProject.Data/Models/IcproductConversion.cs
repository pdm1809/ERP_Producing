using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SampleProject.Data.Models;

[Table("ICProductConversions")]
public partial class IcproductConversion
{
    [Key]
    [Column("ICProductConversionID")]
    public int IcproductConversionId { get; set; }

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

    [Column("FK_BRBranchID")]
    public int? FkBrbranchId { get; set; }

    [Column("FK_HREmployeeID")]
    public int? FkHremployeeId { get; set; }

    [Column("ICProductConversionNo")]
    [StringLength(50)]
    public string IcproductConversionNo { get; set; }

    [Column("ICProductConversionName")]
    [StringLength(256)]
    public string IcproductConversionName { get; set; }

    [Column("ICProductConversionDesc")]
    [StringLength(512)]
    public string IcproductConversionDesc { get; set; }

    [Column("ICProductConversionDate", TypeName = "datetime")]
    public DateTime? IcproductConversionDate { get; set; }

    [Column("FK_ICFromStockID")]
    public int FkIcfromStockId { get; set; }

    [Column("FK_ICToStockID")]
    public int FkIctoStockId { get; set; }

    [Column("ICProductConversionStatus")]
    [StringLength(50)]
    public string IcproductConversionStatus { get; set; }

    [Column("ICProductConversionPostedStatus")]
    [StringLength(50)]
    public string IcproductConversionPostedStatus { get; set; }

    [Column("STToolbarActionName")]
    [StringLength(256)]
    [Unicode(false)]
    public string SttoolbarActionName { get; set; }

    [Column("FK_HREmployeeConfirmedID")]
    public int? FkHremployeeConfirmedId { get; set; }

    [Column("ICProductConversionConfirmedDate", TypeName = "datetime")]
    public DateTime? IcproductConversionConfirmedDate { get; set; }

    [Column("FK_HREmployeeCompletedID")]
    public int? FkHremployeeCompletedId { get; set; }

    [Column("ICProductConversionCompletedDate", TypeName = "datetime")]
    public DateTime? IcproductConversionCompletedDate { get; set; }

    [Column("ICProductConversionType")]
    [StringLength(50)]
    public string IcproductConversionType { get; set; }

    [Column("ICProductConversionProductType")]
    [StringLength(50)]
    public string IcproductConversionProductType { get; set; }

    [Column("ICProductConversionRuleOfAllocationFactorGeneration")]
    [StringLength(50)]
    public string IcproductConversionRuleOfAllocationFactorGeneration { get; set; }

    [ForeignKey("FkHremployeeId")]
    [InverseProperty("IcproductConversions")]
    public virtual Hremployee FkHremployee { get; set; }

    [ForeignKey("FkIcfromStockId")]
    [InverseProperty("IcproductConversionFkIcfromStocks")]
    public virtual Icstock FkIcfromStock { get; set; }

    [ForeignKey("FkIctoStockId")]
    [InverseProperty("IcproductConversionFkIctoStocks")]
    public virtual Icstock FkIctoStock { get; set; }

    [InverseProperty("FkIcproductConversion")]
    public virtual ICollection<IcproductConversionItem> IcproductConversionItems { get; set; } = new List<IcproductConversionItem>();
}
