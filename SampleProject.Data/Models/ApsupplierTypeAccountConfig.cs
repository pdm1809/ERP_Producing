using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SampleProject.Data.Models;

[Table("APSupplierTypeAccountConfigs")]
public partial class ApsupplierTypeAccountConfig
{
    [Key]
    [Column("APSupplierTypeAccountConfigID")]
    public int ApsupplierTypeAccountConfigId { get; set; }

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

    [Column("APSupplierTypeAccountConfigName")]
    [StringLength(512)]
    public string ApsupplierTypeAccountConfigName { get; set; }

    [Column("FK_ACAccountSaleID")]
    public int? FkAcaccountSaleId { get; set; }

    [Column("FK_ACAccountPurchaseID")]
    public int? FkAcaccountPurchaseId { get; set; }

    [Column("FK_ACAccountDepositID")]
    public int? FkAcaccountDepositId { get; set; }

    [InverseProperty("FkApsupplierTypeAccountConfig")]
    public virtual ICollection<Apsupplier> Apsuppliers { get; set; } = new List<Apsupplier>();

    [ForeignKey("FkAcaccountDepositId")]
    [InverseProperty("ApsupplierTypeAccountConfigFkAcaccountDeposits")]
    public virtual Acaccount FkAcaccountDeposit { get; set; }

    [ForeignKey("FkAcaccountPurchaseId")]
    [InverseProperty("ApsupplierTypeAccountConfigFkAcaccountPurchases")]
    public virtual Acaccount FkAcaccountPurchase { get; set; }

    [ForeignKey("FkAcaccountSaleId")]
    [InverseProperty("ApsupplierTypeAccountConfigFkAcaccountSales")]
    public virtual Acaccount FkAcaccountSale { get; set; }
}
