using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SampleProject.Data.Models;

[Table("STToolbars")]
public partial class Sttoolbar
{
    [Key]
    [Column("STToolbarID")]
    public int SttoolbarId { get; set; }

    [Required]
    [Column("AAStatus")]
    [StringLength(50)]
    [Unicode(false)]
    public string Aastatus { get; set; }

    [Column("STModuleID")]
    public int StmoduleId { get; set; }

    [Column("STUserGroupID")]
    public int StuserGroupId { get; set; }

    [Required]
    [Column("STToolbarName")]
    [StringLength(50)]
    public string SttoolbarName { get; set; }

    [Column("STToolbarDesc")]
    [StringLength(255)]
    public string SttoolbarDesc { get; set; }

    [Column("STToolbarTag")]
    [StringLength(50)]
    [Unicode(false)]
    public string SttoolbarTag { get; set; }

    [Required]
    [Column("STToolbarStyle")]
    [StringLength(50)]
    [Unicode(false)]
    public string SttoolbarStyle { get; set; }

    [Required]
    [Column("STToolbarCaption")]
    [StringLength(50)]
    public string SttoolbarCaption { get; set; }

    [Required]
    [Column("STToolbarGroup")]
    [StringLength(50)]
    public string SttoolbarGroup { get; set; }

    [Column("STToolbarOrder")]
    public int SttoolbarOrder { get; set; }

    [Column("STToolbarVisible")]
    public bool? SttoolbarVisible { get; set; }

    [Column("STToolbarPrivilege")]
    [StringLength(50)]
    public string SttoolbarPrivilege { get; set; }

    [Column("STToolbarParentID")]
    public int? SttoolbarParentId { get; set; }

    [Column("STToolbarImage")]
    [StringLength(50)]
    public string SttoolbarImage { get; set; }

    [ForeignKey("StmoduleId")]
    [InverseProperty("Sttoolbars")]
    public virtual Stmodule Stmodule { get; set; }

    [InverseProperty("Sttoolbar")]
    public virtual ICollection<SttoolbarFunction> SttoolbarFunctions { get; set; } = new List<SttoolbarFunction>();

    [ForeignKey("StuserGroupId")]
    [InverseProperty("Sttoolbars")]
    public virtual AduserGroup StuserGroup { get; set; }
}
