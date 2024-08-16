using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SampleProject.Data.Models;

[Table("ADFunctionWebs")]
public partial class AdfunctionWeb
{
    [Key]
    [Column("ADFunctionWebID")]
    public int AdfunctionWebId { get; set; }

    [Column("ADFunctionWebParentId")]
    public int AdfunctionWebParentId { get; set; }

    [Column("AAStatus")]
    [StringLength(50)]
    public string Aastatus { get; set; }

    [Column("AACreatedDate")]
    [StringLength(50)]
    public string AacreatedDate { get; set; }

    [Column("AACreatedUser")]
    [StringLength(50)]
    public string AacreatedUser { get; set; }

    [Column("AAUpdatedDate")]
    [StringLength(50)]
    public string AaupdatedDate { get; set; }

    [Column("AAUpdatedUser")]
    [StringLength(50)]
    public string AaupdatedUser { get; set; }

    [Required]
    [Column("ADFunctionWebModule")]
    [StringLength(50)]
    public string AdfunctionWebModule { get; set; }

    [Required]
    [Column("ADFunctionWebName")]
    [StringLength(50)]
    public string AdfunctionWebName { get; set; }

    [Required]
    [Column("ADFunctionWebNo")]
    [StringLength(50)]
    public string AdfunctionWebNo { get; set; }

    [Required]
    [Column("ADFunctionWebDesc")]
    [StringLength(450)]
    public string AdfunctionWebDesc { get; set; }

    [InverseProperty("FkAdfunctionWeb")]
    public virtual ICollection<AduserGroupFunction> AduserGroupFunctions { get; set; } = new List<AduserGroupFunction>();
}
