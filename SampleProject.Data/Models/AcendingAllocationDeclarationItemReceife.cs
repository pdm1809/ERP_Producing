using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SampleProject.Data.Models;

[Table("ACEndingAllocationDeclarationItemReceives")]
public partial class AcendingAllocationDeclarationItemReceife
{
    [Key]
    [Column("ACEndingAllocationDeclarationItemReceiveID")]
    public int AcendingAllocationDeclarationItemReceiveId { get; set; }

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

    [Column("FK_ACEndingAllocationDeclarationID")]
    public int? FkAcendingAllocationDeclarationId { get; set; }

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

    [Column("ACEndingAllocationDeclarationItemReceiveFactor", TypeName = "decimal(18, 5)")]
    public decimal? AcendingAllocationDeclarationItemReceiveFactor { get; set; }

    [Column("FK_ACByDebitAccountID")]
    public int? FkAcbyDebitAccountId { get; set; }

    [Column("FK_ACByCreditAccountID")]
    public int? FkAcbyCreditAccountId { get; set; }

    [Column("FK_PMProjectID")]
    public int? FkPmprojectId { get; set; }

    [ForeignKey("FkAcaccountId")]
    [InverseProperty("AcendingAllocationDeclarationItemReceifeFkAcaccounts")]
    public virtual Acaccount FkAcaccount { get; set; }

    [ForeignKey("FkAcbyCreditAccountId")]
    [InverseProperty("AcendingAllocationDeclarationItemReceifeFkAcbyCreditAccounts")]
    public virtual Acaccount FkAcbyCreditAccount { get; set; }

    [ForeignKey("FkAcbyDebitAccountId")]
    [InverseProperty("AcendingAllocationDeclarationItemReceifeFkAcbyDebitAccounts")]
    public virtual Acaccount FkAcbyDebitAccount { get; set; }

    [ForeignKey("FkAccostCenterId")]
    [InverseProperty("AcendingAllocationDeclarationItemReceives")]
    public virtual AccostCenter FkAccostCenter { get; set; }

    [ForeignKey("FkAcendingAllocationDeclarationId")]
    [InverseProperty("AcendingAllocationDeclarationItemReceives")]
    public virtual AcendingAllocationDeclaration FkAcendingAllocationDeclaration { get; set; }

    [ForeignKey("FkAcsegmentId")]
    [InverseProperty("AcendingAllocationDeclarationItemReceives")]
    public virtual Acsegment FkAcsegment { get; set; }

    [ForeignKey("FkHrdepartmentId")]
    [InverseProperty("AcendingAllocationDeclarationItemReceives")]
    public virtual Hrdepartment FkHrdepartment { get; set; }

    [ForeignKey("FkHrdepartmentRoomId")]
    [InverseProperty("AcendingAllocationDeclarationItemReceives")]
    public virtual HrdepartmentRoom FkHrdepartmentRoom { get; set; }

    [ForeignKey("FkHrdepartmentRoomGroupItemId")]
    [InverseProperty("AcendingAllocationDeclarationItemReceives")]
    public virtual HrdepartmentRoomGroupItem FkHrdepartmentRoomGroupItem { get; set; }

    [ForeignKey("FkIcproductId")]
    [InverseProperty("AcendingAllocationDeclarationItemReceives")]
    public virtual Icproduct FkIcproduct { get; set; }

    [ForeignKey("FkMmbatchProductId")]
    [InverseProperty("AcendingAllocationDeclarationItemReceives")]
    public virtual MmbatchProduct FkMmbatchProduct { get; set; }

    [ForeignKey("FkMmlineId")]
    [InverseProperty("AcendingAllocationDeclarationItemReceives")]
    public virtual Mmline FkMmline { get; set; }

    [ForeignKey("FkMmoperationId")]
    [InverseProperty("AcendingAllocationDeclarationItemReceives")]
    public virtual Mmoperation FkMmoperation { get; set; }

    [ForeignKey("FkMmworkShopId")]
    [InverseProperty("AcendingAllocationDeclarationItemReceives")]
    public virtual MmworkShop FkMmworkShop { get; set; }

    [ForeignKey("FkPmprojectId")]
    [InverseProperty("AcendingAllocationDeclarationItemReceives")]
    public virtual Pmproject FkPmproject { get; set; }
}
