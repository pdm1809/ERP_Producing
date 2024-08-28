using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SampleProject.Data.Models;

[Table("ICProductTypeAccountConfigs")]
public partial class IcproductTypeAccountConfig
{
    [Key]
    [Column("ICProductTypeAccountConfigID")]
    public int IcproductTypeAccountConfigId { get; set; }

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

    [Column("ICProductTypeAccountConfigName")]
    [StringLength(512)]
    public string IcproductTypeAccountConfigName { get; set; }

    [Column("FK_ACAccountID")]
    public int? FkAcaccountId { get; set; }

    [Column("FK_ACAccountRevenueInternalID")]
    public int? FkAcaccountRevenueInternalId { get; set; }

    [Column("FK_ACAccountCostPriceID")]
    public int? FkAcaccountCostPriceId { get; set; }

    [Column("FK_ACAccountRevenueID")]
    public int? FkAcaccountRevenueId { get; set; }

    [Column("FK_ACAccountSaleReturnID")]
    public int? FkAcaccountSaleReturnId { get; set; }

    [Column("FK_ACAccountDiscountID")]
    public int? FkAcaccountDiscountId { get; set; }

    [Column("ICProductTypeCombo")]
    [StringLength(50)]
    public string IcproductTypeCombo { get; set; }

    [Column("FK_ACAccountRevenueHinterLandID")]
    public int? FkAcaccountRevenueHinterLandId { get; set; }

    [ForeignKey("FkAcaccountId")]
    [InverseProperty("IcproductTypeAccountConfigFkAcaccounts")]
    public virtual Acaccount FkAcaccount { get; set; }

    [ForeignKey("FkAcaccountCostPriceId")]
    [InverseProperty("IcproductTypeAccountConfigFkAcaccountCostPrices")]
    public virtual Acaccount FkAcaccountCostPrice { get; set; }

    [ForeignKey("FkAcaccountDiscountId")]
    [InverseProperty("IcproductTypeAccountConfigFkAcaccountDiscounts")]
    public virtual Acaccount FkAcaccountDiscount { get; set; }

    [ForeignKey("FkAcaccountRevenueId")]
    [InverseProperty("IcproductTypeAccountConfigFkAcaccountRevenues")]
    public virtual Acaccount FkAcaccountRevenue { get; set; }

    [ForeignKey("FkAcaccountRevenueHinterLandId")]
    [InverseProperty("IcproductTypeAccountConfigFkAcaccountRevenueHinterLands")]
    public virtual Acaccount FkAcaccountRevenueHinterLand { get; set; }

    [ForeignKey("FkAcaccountRevenueInternalId")]
    [InverseProperty("IcproductTypeAccountConfigFkAcaccountRevenueInternals")]
    public virtual Acaccount FkAcaccountRevenueInternal { get; set; }

    [ForeignKey("FkAcaccountSaleReturnId")]
    [InverseProperty("IcproductTypeAccountConfigFkAcaccountSaleReturns")]
    public virtual Acaccount FkAcaccountSaleReturn { get; set; }

    [InverseProperty("FkIcproductTypeAccountConfig")]
    public virtual ICollection<IcproductGroup> IcproductGroups { get; set; } = new List<IcproductGroup>();

    [InverseProperty("FkIcproductTypeAccountConfig")]
    public virtual ICollection<Icproduct> Icproducts { get; set; } = new List<Icproduct>();
}
