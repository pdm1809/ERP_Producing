using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SampleProject.Data.Models;

[Table("STModuleFunctionParameterValues")]
public partial class StmoduleFunctionParameterValue
{
    [Key]
    [Column("STModuleFunctionParameterValueID")]
    public int StmoduleFunctionParameterValueId { get; set; }

    [Column("STModuleFunctionParameterID")]
    public int StmoduleFunctionParameterId { get; set; }

    [Column("STUserGroupID")]
    public int StuserGroupId { get; set; }

    [Required]
    [Column("STModuleFunctionParameterValue")]
    [StringLength(255)]
    [Unicode(false)]
    public string StmoduleFunctionParameterValue1 { get; set; }

    [ForeignKey("StmoduleFunctionParameterId")]
    [InverseProperty("StmoduleFunctionParameterValues")]
    public virtual StmoduleFunctionParameter StmoduleFunctionParameter { get; set; }

    [ForeignKey("StuserGroupId")]
    [InverseProperty("StmoduleFunctionParameterValues")]
    public virtual AduserGroup StuserGroup { get; set; }
}
