using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SampleProject.Data.Models;

[Table("ICProductProfiles")]
public partial class IcproductProfile
{
    [Key]
    [Column("ICProductProfileID")]
    public int IcproductProfileId { get; set; }

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

    [Column("FK_ICProductID")]
    public int FkIcproductId { get; set; }

    [Column("ICProductProfileComment")]
    [StringLength(256)]
    public string IcproductProfileComment { get; set; }

    [Column("ICProductProfileLink")]
    [StringLength(512)]
    public string IcproductProfileLink { get; set; }

    [Column("ICProductProfileName")]
    [StringLength(256)]
    public string IcproductProfileName { get; set; }

    [Column("ICProductProfileType")]
    [StringLength(50)]
    [Unicode(false)]
    public string IcproductProfileType { get; set; }

    [ForeignKey("FkIcproductId")]
    [InverseProperty("IcproductProfiles")]
    public virtual Icproduct FkIcproduct { get; set; }
}
