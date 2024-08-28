using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SampleProject.Data.Models;

[Table("ACSalaryCalculationDetails")]
public partial class AcsalaryCalculationDetail
{
    [Key]
    [Column("ACSalaryCalculationDetailID")]
    public int AcsalaryCalculationDetailId { get; set; }

    [Column("AAStatus")]
    [StringLength(50)]
    [Unicode(false)]
    public string Aastatus { get; set; }

    [Column("FK_ACSalaryEntryTypeID")]
    public int? FkAcsalaryEntryTypeId { get; set; }

    [Column("FK_ACSalaryCalculationID")]
    public int? FkAcsalaryCalculationId { get; set; }

    [Column("FK_ACDebitAccountID")]
    public int? FkAcdebitAccountId { get; set; }

    [Column("FK_ACCreditAccountID")]
    public int? FkAccreditAccountId { get; set; }

    [Column("FK_GECurrencyID")]
    public int? FkGecurrencyId { get; set; }

    [Column("ACSalaryCalculationDetailDesc")]
    [StringLength(255)]
    public string AcsalaryCalculationDetailDesc { get; set; }

    [Column("ACSalaryCalculationDetailExchangeRate", TypeName = "decimal(18, 5)")]
    public decimal? AcsalaryCalculationDetailExchangeRate { get; set; }

    [Column("ACSalaryCalculationDetailAmount", TypeName = "decimal(18, 5)")]
    public decimal? AcsalaryCalculationDetailAmount { get; set; }

    [Column("ACSalaryCalculationDetailExchangeAmount", TypeName = "decimal(18, 5)")]
    public decimal? AcsalaryCalculationDetailExchangeAmount { get; set; }

    [Column("FK_ACCostCenterID")]
    public int? FkAccostCenterId { get; set; }

    [Column("FK_ACSegmentID")]
    public int? FkAcsegmentId { get; set; }

    [Column("FK_HRDepartmentID")]
    public int? FkHrdepartmentId { get; set; }

    [Column("FK_HRDepartmentRoomID")]
    public int? FkHrdepartmentRoomId { get; set; }

    [Column("FK_ACCostObjectID")]
    public int? FkAccostObjectId { get; set; }

    [Column("FK_ACUnfinishedConstructionCostID")]
    public int? FkAcunfinishedConstructionCostId { get; set; }

    [Column("FK_PMProjectID")]
    public int? FkPmprojectId { get; set; }

    [Column("FK_ACDebitObjectID")]
    public int? FkAcdebitObjectId { get; set; }

    [Column("ACDebitObjectType")]
    [StringLength(128)]
    public string AcdebitObjectType { get; set; }

    [Column("FK_ACCreditObjectID")]
    public int? FkAccreditObjectId { get; set; }

    [Column("ACCreditObjectType")]
    [StringLength(128)]
    public string AccreditObjectType { get; set; }

    [Column("ACSalaryCalculationDetailSymbol")]
    [StringLength(128)]
    public string AcsalaryCalculationDetailSymbol { get; set; }

    [ForeignKey("FkAccostCenterId")]
    [InverseProperty("AcsalaryCalculationDetails")]
    public virtual AccostCenter FkAccostCenter { get; set; }

    [ForeignKey("FkAccostObjectId")]
    [InverseProperty("AcsalaryCalculationDetails")]
    public virtual AccostObject FkAccostObject { get; set; }

    [ForeignKey("FkAccreditAccountId")]
    [InverseProperty("AcsalaryCalculationDetailFkAccreditAccounts")]
    public virtual Acaccount FkAccreditAccount { get; set; }

    [ForeignKey("FkAcdebitAccountId")]
    [InverseProperty("AcsalaryCalculationDetailFkAcdebitAccounts")]
    public virtual Acaccount FkAcdebitAccount { get; set; }

    [ForeignKey("FkAcsalaryCalculationId")]
    [InverseProperty("AcsalaryCalculationDetails")]
    public virtual AcsalaryCalculation FkAcsalaryCalculation { get; set; }

    [ForeignKey("FkAcsalaryEntryTypeId")]
    [InverseProperty("AcsalaryCalculationDetails")]
    public virtual AcsalaryEntryType FkAcsalaryEntryType { get; set; }

    [ForeignKey("FkAcsegmentId")]
    [InverseProperty("AcsalaryCalculationDetails")]
    public virtual Acsegment FkAcsegment { get; set; }

    [ForeignKey("FkAcunfinishedConstructionCostId")]
    [InverseProperty("AcsalaryCalculationDetails")]
    public virtual AcunfinishedConstructionCost FkAcunfinishedConstructionCost { get; set; }

    [ForeignKey("FkGecurrencyId")]
    [InverseProperty("AcsalaryCalculationDetails")]
    public virtual Gecurrency FkGecurrency { get; set; }

    [ForeignKey("FkHrdepartmentId")]
    [InverseProperty("AcsalaryCalculationDetails")]
    public virtual Hrdepartment FkHrdepartment { get; set; }

    [ForeignKey("FkHrdepartmentRoomId")]
    [InverseProperty("AcsalaryCalculationDetails")]
    public virtual HrdepartmentRoom FkHrdepartmentRoom { get; set; }

    [ForeignKey("FkPmprojectId")]
    [InverseProperty("AcsalaryCalculationDetails")]
    public virtual Pmproject FkPmproject { get; set; }
}
