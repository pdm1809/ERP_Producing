using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SampleProject.Data.Models;

[Table("HRConfigRewardBestSellers")]
public partial class HrconfigRewardBestSeller
{
    [Key]
    [Column("HRConfigRewardBestSellerID")]
    public int HrconfigRewardBestSellerId { get; set; }

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

    [Column("AAStatus")]
    [StringLength(10)]
    [Unicode(false)]
    public string Aastatus { get; set; }

    [Required]
    [Column("HRBestSellerType")]
    [StringLength(50)]
    public string HrbestSellerType { get; set; }

    [Column("HRConfigRewardBestSellerAmount", TypeName = "decimal(18, 5)")]
    public decimal? HrconfigRewardBestSellerAmount { get; set; }

    [Column("HRConfigRewardBestSellerSalesFrom", TypeName = "decimal(18, 5)")]
    public decimal? HrconfigRewardBestSellerSalesFrom { get; set; }

    [Column("HRConfigRewardBestSellerSalesTo", TypeName = "decimal(18, 5)")]
    public decimal? HrconfigRewardBestSellerSalesTo { get; set; }

    [Column("HRConfigRewardBestSellerDependenceType")]
    [StringLength(50)]
    public string HrconfigRewardBestSellerDependenceType { get; set; }

    [Column("HRConfigRewardBestSellerDependenceSalesFrom", TypeName = "decimal(18, 5)")]
    public decimal? HrconfigRewardBestSellerDependenceSalesFrom { get; set; }

    [Column("HRConfigRewardBestSellerDependenceSalesTo", TypeName = "decimal(18, 5)")]
    public decimal? HrconfigRewardBestSellerDependenceSalesTo { get; set; }

    [Column("HRConfigRewardBestSellerType")]
    [StringLength(50)]
    public string HrconfigRewardBestSellerType { get; set; }
}
