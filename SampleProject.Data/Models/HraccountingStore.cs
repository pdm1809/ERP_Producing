using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SampleProject.Data.Models;

[Table("HRAccountingStores")]
public partial class HraccountingStore
{
    [Key]
    [Column("HRAccountingStoreID")]
    public int HraccountingStoreId { get; set; }

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

    [Column("HRConfigureAccording")]
    [StringLength(255)]
    public string HrconfigureAccording { get; set; }

    [Column("HRAccountingStoreLevel", TypeName = "decimal(18, 5)")]
    public decimal? HraccountingStoreLevel { get; set; }
}
