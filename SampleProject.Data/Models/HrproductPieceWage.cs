using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SampleProject.Data.Models;

[Table("HRProductPieceWages")]
public partial class HrproductPieceWage
{
    [Key]
    [Column("HRProductPieceWageID")]
    public int HrproductPieceWageId { get; set; }

    [Column("AAStatus")]
    [StringLength(50)]
    [Unicode(false)]
    public string Aastatus { get; set; }

    [Column("AACreatedDate", TypeName = "datetime")]
    public DateTime? AacreatedDate { get; set; }

    [Column("AACreatedUser")]
    [StringLength(50)]
    public string AacreatedUser { get; set; }

    [Column("AAUpdatedDate", TypeName = "datetime")]
    public DateTime? AaupdatedDate { get; set; }

    [Column("AAUpdatedUser")]
    [StringLength(50)]
    public string AaupdatedUser { get; set; }

    [Required]
    [Column("HRProductPieceWageNo")]
    [StringLength(50)]
    public string HrproductPieceWageNo { get; set; }

    [Column("HRProductPieceWageName")]
    [StringLength(100)]
    public string HrproductPieceWageName { get; set; }

    [Column("HRProductPieceWageDesc")]
    [StringLength(512)]
    public string HrproductPieceWageDesc { get; set; }

    [Column("HRProductPieceWageQuantity", TypeName = "decimal(18, 5)")]
    public decimal? HrproductPieceWageQuantity { get; set; }

    [Column("HRProductPieceWageUnitPrice", TypeName = "decimal(18, 5)")]
    public decimal? HrproductPieceWageUnitPrice { get; set; }

    [InverseProperty("FkHrproductPieceWage")]
    public virtual ICollection<HremployeePieceWage> HremployeePieceWages { get; set; } = new List<HremployeePieceWage>();
}
