using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SampleProject.Data.Models;

[Table("ADModuleFieldsToUsers")]
public partial class AdmoduleFieldsToUser
{
    [Key]
    [Column("ADModuleFieldsToUserID")]
    public int AdmoduleFieldsToUserId { get; set; }

    [Column("ADUserID")]
    public int AduserId { get; set; }

    [Column("STModuleID")]
    public int StmoduleId { get; set; }

    [Required]
    [Column("ADModuleFieldsToUserScreenNumber")]
    [StringLength(50)]
    [Unicode(false)]
    public string AdmoduleFieldsToUserScreenNumber { get; set; }

    [Required]
    [Column("ADModuleFieldsToUserFieldName")]
    [StringLength(50)]
    [Unicode(false)]
    public string AdmoduleFieldsToUserFieldName { get; set; }

    [Column("ADModuleFieldsToUserFieldStatus")]
    public int AdmoduleFieldsToUserFieldStatus { get; set; }

    [Required]
    [Column("AAStat")]
    [StringLength(10)]
    [Unicode(false)]
    public string Aastat { get; set; }

    [ForeignKey("AduserId")]
    [InverseProperty("AdmoduleFieldsToUsers")]
    public virtual Aduser Aduser { get; set; }

    [ForeignKey("StmoduleId")]
    [InverseProperty("AdmoduleFieldsToUsers")]
    public virtual Stmodule Stmodule { get; set; }
}
