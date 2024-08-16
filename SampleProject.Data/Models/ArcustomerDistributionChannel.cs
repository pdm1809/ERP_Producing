using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SampleProject.Data.Models;

[Table("ARCustomerDistributionChannels")]
public partial class ArcustomerDistributionChannel
{
    [Key]
    [Column("ARCustomerDistributionChannelID")]
    public int ArcustomerDistributionChannelId { get; set; }

    [Column("AAStatus")]
    [StringLength(10)]
    [Unicode(false)]
    public string Aastatus { get; set; }

    [Column("AACreatedUser")]
    [StringLength(50)]
    public string AacreatedUser { get; set; }

    [Column("AAUpdatedUser")]
    [StringLength(50)]
    public string AaupdatedUser { get; set; }

    [Column("AACreatedDate", TypeName = "datetime")]
    public DateTime? AacreatedDate { get; set; }

    [Column("AAUpdatedDate", TypeName = "datetime")]
    public DateTime? AaupdatedDate { get; set; }

    [Column("ARCustomerDistributionChannelNo")]
    [StringLength(128)]
    public string ArcustomerDistributionChannelNo { get; set; }

    [Column("ARCustomerDistributionChannelName")]
    [StringLength(128)]
    public string ArcustomerDistributionChannelName { get; set; }

    [Column("ARCustomerDistributionChannelDesc")]
    [StringLength(256)]
    public string ArcustomerDistributionChannelDesc { get; set; }

    [Column("ARCustomerDistributionChannelShowWeb")]
    public bool? ArcustomerDistributionChannelShowWeb { get; set; }

    [InverseProperty("FkArcustomerDistributionChannel")]
    public virtual ICollection<ArcalculateDiscount> ArcalculateDiscounts { get; set; } = new List<ArcalculateDiscount>();

    [InverseProperty("FkArcustomerDistributionChannel")]
    public virtual ICollection<ArdiscountProgram> ArdiscountPrograms { get; set; } = new List<ArdiscountProgram>();
}
