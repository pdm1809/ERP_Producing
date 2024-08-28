using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SampleProject.Data.Models;

[Table("APPurchaseContractGroups")]
public partial class AppurchaseContractGroup
{
    [Key]
    [Column("APPurchaseContractGroupID")]
    public int AppurchaseContractGroupId { get; set; }

    [Column("AAStatus")]
    [StringLength(50)]
    [Unicode(false)]
    public string Aastatus { get; set; }

    [Column("APPurchaseContractGroupNo")]
    [StringLength(50)]
    public string AppurchaseContractGroupNo { get; set; }

    [Column("APPurchaseContractGroupName")]
    [StringLength(256)]
    public string AppurchaseContractGroupName { get; set; }

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

    [Column("APPurchaseContractGroupDesc")]
    [StringLength(512)]
    public string AppurchaseContractGroupDesc { get; set; }
}
