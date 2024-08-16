using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SampleProject.Data.Models;

[Keyless]
public partial class VAcobject
{
    [Required]
    [Column("ACObjectNo")]
    [StringLength(50)]
    public string AcobjectNo { get; set; }

    [Column("ACObjectID")]
    public int AcobjectId { get; set; }

    [Required]
    [Column("ACObjectType")]
    [StringLength(8)]
    [Unicode(false)]
    public string AcobjectType { get; set; }

    [Column("ACObjectName")]
    [StringLength(4000)]
    public string AcobjectName { get; set; }

    [Column("FK_ObjectBRBranchID")]
    public int? FkObjectBrbranchId { get; set; }

    [Column("FK_ACAccountSaleID")]
    public int? FkAcaccountSaleId { get; set; }

    [Column("FK_ACAccountPurchaseID")]
    public int? FkAcaccountPurchaseId { get; set; }

    [Column("FK_ACAccountDepositID")]
    public int? FkAcaccountDepositId { get; set; }

    [Column("ACObjectTaxNumber")]
    [StringLength(50)]
    [Unicode(false)]
    public string AcobjectTaxNumber { get; set; }

    [Column("ACObjectContactAddressLine3")]
    [StringLength(200)]
    public string AcobjectContactAddressLine3 { get; set; }

    [Column("ACObjectDeliveryAddressLine1")]
    [StringLength(200)]
    public string AcobjectDeliveryAddressLine1 { get; set; }

    [Column("ACObjectContactPhone")]
    [StringLength(50)]
    public string AcobjectContactPhone { get; set; }

    [Column("GELocationID")]
    public int? GelocationId { get; set; }

    [Column("ACObjectMail")]
    [StringLength(100)]
    public string AcobjectMail { get; set; }

    [Column("ACObjectBankAccount1")]
    [StringLength(50)]
    [Unicode(false)]
    public string AcobjectBankAccount1 { get; set; }

    [Column("ACObjectBankName")]
    [StringLength(250)]
    public string AcobjectBankName { get; set; }

    [StringLength(50)]
    public string NoOfOldSys { get; set; }

    [Column("ACObjectGroup")]
    public int? AcobjectGroup { get; set; }
}
