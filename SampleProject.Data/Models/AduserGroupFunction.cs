using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SampleProject.Data.Models;

[Table("ADUserGroupFunctions")]
public partial class AduserGroupFunction
{
    [Key]
    [Column("ADUserGroupFunctionID")]
    public int AduserGroupFunctionId { get; set; }

    [Required]
    [Column("AAStatus")]
    [StringLength(50)]
    public string Aastatus { get; set; }

    [Column("AACreatedDate", TypeName = "datetime")]
    public DateTime? AacreatedDate { get; set; }

    [Column("AACreatedUser")]
    [StringLength(50)]
    public string AacreatedUser { get; set; }

    [Column("AAUpdatedUser")]
    [StringLength(50)]
    public string AaupdatedUser { get; set; }

    [Column("FK_ADUserGroupID")]
    public int? FkAduserGroupId { get; set; }

    [Column("ADUserGroupFunctionCategory")]
    [StringLength(50)]
    public string AduserGroupFunctionCategory { get; set; }

    [Column("FK_ADFunctionWebID")]
    public int FkAdfunctionWebId { get; set; }

    [Column("ADUserGroupFunctionType")]
    public bool AduserGroupFunctionType { get; set; }

    [Column("AAUpdatedDate", TypeName = "datetime")]
    public DateTime? AaupdatedDate { get; set; }

    [Column("FK_HRGroupID")]
    public int? FkHrgroupId { get; set; }

    [ForeignKey("FkAdfunctionWebId")]
    [InverseProperty("AduserGroupFunctions")]
    public virtual AdfunctionWeb FkAdfunctionWeb { get; set; }

    [ForeignKey("FkAduserGroupId")]
    [InverseProperty("AduserGroupFunctions")]
    public virtual AduserGroup FkAduserGroup { get; set; }

    [ForeignKey("FkHrgroupId")]
    [InverseProperty("AduserGroupFunctions")]
    public virtual Hrgroup FkHrgroup { get; set; }
}
