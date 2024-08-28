using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SampleProject.Data.Models;

[Table("ACEndingAllocationItems")]
public partial class AcendingAllocationItem
{
    [Key]
    [Column("ACEndingAllocationItemID")]
    public int AcendingAllocationItemId { get; set; }

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

    [Column("FK_ACEndingAllocationID")]
    public int? FkAcendingAllocationId { get; set; }

    [Column("FK_ACAccountID")]
    public int? FkAcaccountId { get; set; }

    [Column("FK_ACCostCenterID")]
    public int? FkAccostCenterId { get; set; }

    [Column("FK_ACSegmentID")]
    public int? FkAcsegmentId { get; set; }

    [Column("FK_HRDepartmentID")]
    public int? FkHrdepartmentId { get; set; }

    [Column("FK_HRDepartmentRoomID")]
    public int? FkHrdepartmentRoomId { get; set; }

    [Column("FK_ICProductID")]
    public int? FkIcproductId { get; set; }

    [Column("FK_MMBatchProductID")]
    public int? FkMmbatchProductId { get; set; }

    [Column("FK_MMOperationID")]
    public int? FkMmoperationId { get; set; }

    [Column("FK_MMWorkShopID")]
    public int? FkMmworkShopId { get; set; }

    [Column("FK_MMLineID")]
    public int? FkMmlineId { get; set; }

    [Column("FK_HRDepartmentRoomGroupItemID")]
    public int? FkHrdepartmentRoomGroupItemId { get; set; }

    [Column("ACEndingAllocationItemFactor", TypeName = "decimal(18, 5)")]
    public decimal? AcendingAllocationItemFactor { get; set; }

    [Column("FK_ACByDebitAccountID")]
    public int? FkAcbyDebitAccountId { get; set; }

    [Column("FK_ACByCreditAccountID")]
    public int? FkAcbyCreditAccountId { get; set; }

    [Column("ACEndingAllocationItemAmount", TypeName = "decimal(18, 5)")]
    public decimal? AcendingAllocationItemAmount { get; set; }

    [Column("ACEndingAllocationItemExchangeAmount", TypeName = "decimal(18, 5)")]
    public decimal? AcendingAllocationItemExchangeAmount { get; set; }

    [Column("ACEndingAllocationItemType")]
    [StringLength(50)]
    public string AcendingAllocationItemType { get; set; }

    [Column("ACEndingAllocationItemAccountType")]
    [StringLength(50)]
    public string AcendingAllocationItemAccountType { get; set; }

    [Column("ACEndingAllocationItemGroupOrder")]
    [StringLength(50)]
    public string AcendingAllocationItemGroupOrder { get; set; }

    [ForeignKey("FkAcaccountId")]
    [InverseProperty("AcendingAllocationItemFkAcaccounts")]
    public virtual Acaccount FkAcaccount { get; set; }

    [ForeignKey("FkAcbyCreditAccountId")]
    [InverseProperty("AcendingAllocationItemFkAcbyCreditAccounts")]
    public virtual Acaccount FkAcbyCreditAccount { get; set; }

    [ForeignKey("FkAcbyDebitAccountId")]
    [InverseProperty("AcendingAllocationItemFkAcbyDebitAccounts")]
    public virtual Acaccount FkAcbyDebitAccount { get; set; }

    [ForeignKey("FkAccostCenterId")]
    [InverseProperty("AcendingAllocationItems")]
    public virtual AccostCenter FkAccostCenter { get; set; }

    [ForeignKey("FkAcendingAllocationId")]
    [InverseProperty("AcendingAllocationItems")]
    public virtual AcendingAllocation FkAcendingAllocation { get; set; }

    [ForeignKey("FkAcsegmentId")]
    [InverseProperty("AcendingAllocationItems")]
    public virtual Acsegment FkAcsegment { get; set; }

    [ForeignKey("FkHrdepartmentId")]
    [InverseProperty("AcendingAllocationItems")]
    public virtual Hrdepartment FkHrdepartment { get; set; }

    [ForeignKey("FkHrdepartmentRoomId")]
    [InverseProperty("AcendingAllocationItems")]
    public virtual HrdepartmentRoom FkHrdepartmentRoom { get; set; }

    [ForeignKey("FkHrdepartmentRoomGroupItemId")]
    [InverseProperty("AcendingAllocationItems")]
    public virtual HrdepartmentRoomGroupItem FkHrdepartmentRoomGroupItem { get; set; }

    [ForeignKey("FkIcproductId")]
    [InverseProperty("AcendingAllocationItems")]
    public virtual Icproduct FkIcproduct { get; set; }

    [ForeignKey("FkMmbatchProductId")]
    [InverseProperty("AcendingAllocationItems")]
    public virtual MmbatchProduct FkMmbatchProduct { get; set; }

    [ForeignKey("FkMmlineId")]
    [InverseProperty("AcendingAllocationItems")]
    public virtual Mmline FkMmline { get; set; }

    [ForeignKey("FkMmoperationId")]
    [InverseProperty("AcendingAllocationItems")]
    public virtual Mmoperation FkMmoperation { get; set; }

    [ForeignKey("FkMmworkShopId")]
    [InverseProperty("AcendingAllocationItems")]
    public virtual MmworkShop FkMmworkShop { get; set; }
}
