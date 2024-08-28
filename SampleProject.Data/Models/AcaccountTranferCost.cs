using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SampleProject.Data.Models;

[Table("ACAccountTranferCosts")]
public partial class AcaccountTranferCost
{
    [Key]
    [Column("ACAccountTranferCostID")]
    public int AcaccountTranferCostId { get; set; }

    [Column("AAStatus")]
    [StringLength(50)]
    [Unicode(false)]
    public string Aastatus { get; set; }

    [Column("FK_ACDocumentTypeID")]
    public int FkAcdocumentTypeId { get; set; }

    [Column("FK_ACEntryTypeID")]
    public int FkAcentryTypeId { get; set; }

    [Column("FK_ACFromAccountID")]
    public int? FkAcfromAccountId { get; set; }

    [Column("FK_ACToAccountID")]
    public int? FkActoAccountId { get; set; }

    [Required]
    [Column("ACAccountTranferCostType")]
    [StringLength(50)]
    public string AcaccountTranferCostType { get; set; }

    [Column("ACAccountTranferCostByCustomer")]
    public bool? AcaccountTranferCostByCustomer { get; set; }

    [Column("ACAccountTranferCostByBalance")]
    public bool? AcaccountTranferCostByBalance { get; set; }

    [Column("ACAccountTranferCostByProject")]
    public bool? AcaccountTranferCostByProject { get; set; }

    [Column("ACAccountTranferCostBySaleOrder")]
    public bool? AcaccountTranferCostBySaleOrder { get; set; }

    [Column("ACAccountTranferCostByProduct")]
    public bool? AcaccountTranferCostByProduct { get; set; }

    [Column("ACAccountTranferCostByCurrency")]
    public bool? AcaccountTranferCostByCurrency { get; set; }

    [Column("ACAccountTranferCostByDepartment")]
    public bool? AcaccountTranferCostByDepartment { get; set; }

    [Column("ACAccountTranferCostByCostCenter")]
    public bool? AcaccountTranferCostByCostCenter { get; set; }

    [Column("ACAccountTranferCostBySegment")]
    public bool? AcaccountTranferCostBySegment { get; set; }

    [Column("ACAccountTranferCostByBatch")]
    public bool? AcaccountTranferCostByBatch { get; set; }

    [Column("ACAccountTranferCostFromProductionCost")]
    public bool? AcaccountTranferCostFromProductionCost { get; set; }

    [ForeignKey("FkAcdocumentTypeId")]
    [InverseProperty("AcaccountTranferCosts")]
    public virtual AcdocumentType FkAcdocumentType { get; set; }

    [ForeignKey("FkAcentryTypeId")]
    [InverseProperty("AcaccountTranferCosts")]
    public virtual AcentryType FkAcentryType { get; set; }

    [ForeignKey("FkAcfromAccountId")]
    [InverseProperty("AcaccountTranferCostFkAcfromAccounts")]
    public virtual Acaccount FkAcfromAccount { get; set; }

    [ForeignKey("FkActoAccountId")]
    [InverseProperty("AcaccountTranferCostFkActoAccounts")]
    public virtual Acaccount FkActoAccount { get; set; }
}
