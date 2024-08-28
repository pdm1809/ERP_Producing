using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SampleProject.Data.Models;

[Table("ARSaleContractGroups")]
public partial class ArsaleContractGroup
{
    [Key]
    [Column("ARSaleContractGroupID")]
    public int ArsaleContractGroupId { get; set; }

    [Column("AAStatus")]
    [StringLength(50)]
    [Unicode(false)]
    public string Aastatus { get; set; }

    [Column("ARSaleContractGroupNo")]
    [StringLength(50)]
    public string ArsaleContractGroupNo { get; set; }

    [Column("ARSaleContractGroupName")]
    [StringLength(256)]
    public string ArsaleContractGroupName { get; set; }

    [InverseProperty("FkArsaleContractGroup")]
    public virtual ICollection<ArsaleContract> ArsaleContracts { get; set; } = new List<ArsaleContract>();
}
