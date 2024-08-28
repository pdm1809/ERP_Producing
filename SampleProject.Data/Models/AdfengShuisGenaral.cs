using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SampleProject.Data.Models;

[Table("ADFengShuisGenarals")]
public partial class AdfengShuisGenaral
{
    [Key]
    [Column("ADFengShuisGenaralID")]
    public int AdfengShuisGenaralId { get; set; }

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

    [Column("ADFengShuisGenaralBirthdate")]
    [StringLength(256)]
    public string AdfengShuisGenaralBirthdate { get; set; }

    [Column("ADFengShuisGenaralFiveBasicElements")]
    [StringLength(256)]
    public string AdfengShuisGenaralFiveBasicElements { get; set; }

    [Column("ADFengShuisGenaralDescription")]
    [StringLength(256)]
    public string AdfengShuisGenaralDescription { get; set; }

    [Column("ADFengShuisGenaralMale")]
    [StringLength(256)]
    public string AdfengShuisGenaralMale { get; set; }

    [Column("ADFengShuisGenaralFemale")]
    [StringLength(256)]
    public string AdfengShuisGenaralFemale { get; set; }

    [InverseProperty("FkAdfengShuisGenaral")]
    public virtual ICollection<Arcustomer> Arcustomers { get; set; } = new List<Arcustomer>();
}
