using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SampleProject.Data.Models;

[Table("ADFengShuisDirections")]
public partial class AdfengShuisDirection
{
    [Key]
    [Column("ADFengShuisDirectionID")]
    public int AdfengShuisDirectionId { get; set; }

    [Column("AAStatus")]
    [StringLength(64)]
    [Unicode(false)]
    public string Aastatus { get; set; }

    [Column("AACreatedUser")]
    [StringLength(64)]
    public string AacreatedUser { get; set; }

    [Column("AACreatedDate", TypeName = "datetime")]
    public DateTime? AacreatedDate { get; set; }

    [Column("AAUpdatedUser")]
    [StringLength(64)]
    public string AaupdatedUser { get; set; }

    [Column("AAUpdatedDate", TypeName = "datetime")]
    public DateTime? AaupdatedDate { get; set; }

    [Column("ADFengShuisDirectionMain")]
    [StringLength(256)]
    public string AdfengShuisDirectionMain { get; set; }

    [Column("ADFengShuisDirectionBowLife")]
    [StringLength(256)]
    public string AdfengShuisDirectionBowLife { get; set; }

    [Column("ADFengShuisDirectionEast")]
    [StringLength(256)]
    public string AdfengShuisDirectionEast { get; set; }

    [Column("ADFengShuisDirectionSouthEast")]
    [StringLength(256)]
    public string AdfengShuisDirectionSouthEast { get; set; }

    [Column("ADFengShuisDirectionNorthEast")]
    [StringLength(256)]
    public string AdfengShuisDirectionNorthEast { get; set; }

    [Column("ADFengShuisDirectionWest")]
    [StringLength(256)]
    public string AdfengShuisDirectionWest { get; set; }

    [Column("ADFengShuisDirectionSouthWest")]
    [StringLength(256)]
    public string AdfengShuisDirectionSouthWest { get; set; }

    [Column("ADFengShuisDirectionNorthWest")]
    [StringLength(256)]
    public string AdfengShuisDirectionNorthWest { get; set; }

    [Column("ADFengShuisDirectionNorth")]
    [StringLength(256)]
    public string AdfengShuisDirectionNorth { get; set; }

    [Column("ADFengShuisDirectionSouth")]
    [StringLength(256)]
    public string AdfengShuisDirectionSouth { get; set; }

    [InverseProperty("FkAdfengShuisDirection")]
    public virtual ICollection<Arcustomer> Arcustomers { get; set; } = new List<Arcustomer>();
}
