using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SampleProject.Data.Models;

[Table("ARCustomerTypeAccountConfigs")]
public partial class ArcustomerTypeAccountConfig
{
    [Key]
    [Column("ARCustomerTypeAccountConfigID")]
    public int ArcustomerTypeAccountConfigId { get; set; }

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

    [Column("ARCustomerTypeAccountConfigName")]
    [StringLength(512)]
    public string ArcustomerTypeAccountConfigName { get; set; }

    [Column("FK_ACAccountSaleID")]
    public int? FkAcaccountSaleId { get; set; }

    [Column("FK_ACAccountPurchaseID")]
    public int? FkAcaccountPurchaseId { get; set; }

    [Column("FK_ACAccountDepositID")]
    public int? FkAcaccountDepositId { get; set; }

    [Column("ARCustomerTypeAccountConfigSaleType")]
    [StringLength(100)]
    public string ArcustomerTypeAccountConfigSaleType { get; set; }

    [InverseProperty("FkArcustomerTypeAccountConfig")]
    public virtual ICollection<Arcustomer> Arcustomers { get; set; } = new List<Arcustomer>();

    [ForeignKey("FkAcaccountDepositId")]
    [InverseProperty("ArcustomerTypeAccountConfigFkAcaccountDeposits")]
    public virtual Acaccount FkAcaccountDeposit { get; set; }

    [ForeignKey("FkAcaccountPurchaseId")]
    [InverseProperty("ArcustomerTypeAccountConfigFkAcaccountPurchases")]
    public virtual Acaccount FkAcaccountPurchase { get; set; }

    [ForeignKey("FkAcaccountSaleId")]
    [InverseProperty("ArcustomerTypeAccountConfigFkAcaccountSales")]
    public virtual Acaccount FkAcaccountSale { get; set; }
}
