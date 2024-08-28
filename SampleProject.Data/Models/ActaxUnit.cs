using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SampleProject.Data.Models;

[Table("ACTaxUnits")]
public partial class ActaxUnit
{
    [Key]
    [Column("ACTaxUnitID")]
    public int ActaxUnitId { get; set; }

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

    [Column("FK_BRBranchID")]
    public int? FkBrbranchId { get; set; }

    [Column("ACTaxUnitNo")]
    [StringLength(50)]
    public string ActaxUnitNo { get; set; }

    [Column("ACTaxUnitName")]
    [StringLength(100)]
    public string ActaxUnitName { get; set; }

    [InverseProperty("FkActaxUnit")]
    public virtual ICollection<AceinvoiceConfig> AceinvoiceConfigs { get; set; } = new List<AceinvoiceConfig>();

    [InverseProperty("FkActaxUnit")]
    public virtual ICollection<AceinvoiceGeneral> AceinvoiceGenerals { get; set; } = new List<AceinvoiceGeneral>();

    [InverseProperty("FkActaxUnit")]
    public virtual ICollection<AcretailVat> AcretailVats { get; set; } = new List<AcretailVat>();

    [InverseProperty("FkActaxUnit")]
    public virtual ICollection<Arinvoice> Arinvoices { get; set; } = new List<Arinvoice>();

    [ForeignKey("FkBrbranchId")]
    [InverseProperty("ActaxUnits")]
    public virtual Brbranch FkBrbranch { get; set; }
}
