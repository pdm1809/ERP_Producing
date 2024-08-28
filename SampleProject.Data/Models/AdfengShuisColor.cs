using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SampleProject.Data.Models;

[Table("ADFengShuisColors")]
public partial class AdfengShuisColor
{
    [Key]
    [Column("ADFengShuisColorID")]
    public int AdfengShuisColorId { get; set; }

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

    [Column("ADFengShuisColorLife")]
    [StringLength(256)]
    public string AdfengShuisColorLife { get; set; }

    [Column("ADFengShuisColorMutual")]
    [StringLength(256)]
    public string AdfengShuisColorMutual { get; set; }

    [Column("ADFengShuisColorHarmony")]
    [StringLength(256)]
    public string AdfengShuisColorHarmony { get; set; }

    [Column("ADFengShuisColorFightDown")]
    [StringLength(256)]
    public string AdfengShuisColorFightDown { get; set; }

    [Column("ADFengShuisColorConflict")]
    [StringLength(256)]
    public string AdfengShuisColorConflict { get; set; }

    [InverseProperty("FkAdfengShuisColor")]
    public virtual ICollection<Arcustomer> Arcustomers { get; set; } = new List<Arcustomer>();
}
