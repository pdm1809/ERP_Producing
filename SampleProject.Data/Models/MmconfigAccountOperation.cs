using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SampleProject.Data.Models;

[Table("MMConfigAccountOperations")]
public partial class MmconfigAccountOperation
{
    [Key]
    [Column("MMConfigAccountOperationID")]
    public int MmconfigAccountOperationId { get; set; }

    [Column("AAStatus")]
    [StringLength(50)]
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

    [Column("FK_HRDepartmentID")]
    public int? FkHrdepartmentId { get; set; }

    [Column("FK_MMOperationID")]
    public int? FkMmoperationId { get; set; }

    [Column("FK_ACDebitAccountID")]
    public int? FkAcdebitAccountId { get; set; }

    [Column("FK_ACCostAccountID")]
    public int? FkAccostAccountId { get; set; }

    [Column("FK_ACAccountID")]
    public int? FkAcaccountId { get; set; }

    [Column("FK_MMWorkShopID")]
    public int? FkMmworkShopId { get; set; }

    [Column("MMConfigAccountOperationSpecifyBatchProduct")]
    public bool? MmconfigAccountOperationSpecifyBatchProduct { get; set; }

    [Column("MMConfigAccountOperationMainMaterial")]
    public bool? MmconfigAccountOperationMainMaterial { get; set; }

    [ForeignKey("FkAcaccountId")]
    [InverseProperty("MmconfigAccountOperationFkAcaccounts")]
    public virtual Acaccount FkAcaccount { get; set; }

    [ForeignKey("FkAccostAccountId")]
    [InverseProperty("MmconfigAccountOperationFkAccostAccounts")]
    public virtual Acaccount FkAccostAccount { get; set; }

    [ForeignKey("FkAcdebitAccountId")]
    [InverseProperty("MmconfigAccountOperationFkAcdebitAccounts")]
    public virtual Acaccount FkAcdebitAccount { get; set; }

    [ForeignKey("FkHrdepartmentId")]
    [InverseProperty("MmconfigAccountOperations")]
    public virtual Hrdepartment FkHrdepartment { get; set; }

    [ForeignKey("FkMmoperationId")]
    [InverseProperty("MmconfigAccountOperations")]
    public virtual Mmoperation FkMmoperation { get; set; }

    [ForeignKey("FkMmworkShopId")]
    [InverseProperty("MmconfigAccountOperations")]
    public virtual MmworkShop FkMmworkShop { get; set; }
}
