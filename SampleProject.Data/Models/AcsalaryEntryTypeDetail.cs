using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SampleProject.Data.Models;

[Table("ACSalaryEntryTypeDetails")]
public partial class AcsalaryEntryTypeDetail
{
    [Key]
    [Column("ACSalaryEntryTypeDetailID")]
    public int AcsalaryEntryTypeDetailId { get; set; }

    [Column("AAStatus")]
    [StringLength(50)]
    [Unicode(false)]
    public string Aastatus { get; set; }

    [Column("FK_ACSalaryDocumentTypeID")]
    public int FkAcsalaryDocumentTypeId { get; set; }

    [Column("FK_ACSalaryEntryTypeID")]
    public int FkAcsalaryEntryTypeId { get; set; }

    [Column("ACSalaryEntryTypeDetailSortOrder")]
    public int? AcsalaryEntryTypeDetailSortOrder { get; set; }

    [Column("FK_ACDebitAccountID")]
    public int FkAcdebitAccountId { get; set; }

    [Column("FK_ACCreditAccountID")]
    public int FkAccreditAccountId { get; set; }

    [Column("ACSalaryEntryTypeDetailIsGroupByBranch")]
    public bool? AcsalaryEntryTypeDetailIsGroupByBranch { get; set; }

    [Column("ACSalaryEntryTypeDetailIsGroupByDepartment")]
    public bool? AcsalaryEntryTypeDetailIsGroupByDepartment { get; set; }

    [Column("ACSalaryEntryTypeDetailIsGroupByDepartmentGroup")]
    public bool? AcsalaryEntryTypeDetailIsGroupByDepartmentGroup { get; set; }

    [Column("FK_ACCostCenterID")]
    public int? FkAccostCenterId { get; set; }

    [Column("FK_ACSegmentID")]
    public int? FkAcsegmentId { get; set; }

    [ForeignKey("FkAccostCenterId")]
    [InverseProperty("AcsalaryEntryTypeDetails")]
    public virtual AccostCenter FkAccostCenter { get; set; }

    [ForeignKey("FkAccreditAccountId")]
    [InverseProperty("AcsalaryEntryTypeDetailFkAccreditAccounts")]
    public virtual Acaccount FkAccreditAccount { get; set; }

    [ForeignKey("FkAcdebitAccountId")]
    [InverseProperty("AcsalaryEntryTypeDetailFkAcdebitAccounts")]
    public virtual Acaccount FkAcdebitAccount { get; set; }

    [ForeignKey("FkAcsalaryDocumentTypeId")]
    [InverseProperty("AcsalaryEntryTypeDetails")]
    public virtual AcsalaryDocumentType FkAcsalaryDocumentType { get; set; }

    [ForeignKey("FkAcsalaryEntryTypeId")]
    [InverseProperty("AcsalaryEntryTypeDetails")]
    public virtual AcsalaryEntryType FkAcsalaryEntryType { get; set; }

    [ForeignKey("FkAcsegmentId")]
    [InverseProperty("AcsalaryEntryTypeDetails")]
    public virtual Acsegment FkAcsegment { get; set; }
}
