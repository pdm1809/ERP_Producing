using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SampleProject.Data.Models;

[Table("STScreens")]
public partial class Stscreen
{
    [Key]
    [Column("STScreenID")]
    public int StscreenId { get; set; }

    [Column("STScreenNumber")]
    [StringLength(100)]
    [Unicode(false)]
    public string StscreenNumber { get; set; }

    [Column("STScreenText")]
    [StringLength(255)]
    public string StscreenText { get; set; }

    [Required]
    [Column("STScreenName")]
    [StringLength(50)]
    [Unicode(false)]
    public string StscreenName { get; set; }

    [Column("STModuleID")]
    public int StmoduleId { get; set; }

    [Column("STUserGroupID")]
    public int StuserGroupId { get; set; }

    [Column("STScreenBackColor")]
    public int StscreenBackColor { get; set; }

    [Column("STScreenForeColor")]
    public int StscreenForeColor { get; set; }

    [Required]
    [Column("STScreenFontName")]
    [StringLength(500)]
    public string StscreenFontName { get; set; }

    [Column("STScreenFontSize")]
    public double? StscreenFontSize { get; set; }

    [Required]
    [Column("STScreenFontStyle")]
    [StringLength(100)]
    [Unicode(false)]
    public string StscreenFontStyle { get; set; }

    [Column("STScreenTag")]
    [StringLength(50)]
    [Unicode(false)]
    public string StscreenTag { get; set; }

    [Column("STScreenSizeWidth")]
    public int? StscreenSizeWidth { get; set; }

    [Column("STScreenSizeHeight")]
    public int? StscreenSizeHeight { get; set; }

    [Column("STScreenLocationX")]
    public int? StscreenLocationX { get; set; }

    [Column("STScreenLocationY")]
    public int? StscreenLocationY { get; set; }

    [Column("STScreenShowModal")]
    public bool? StscreenShowModal { get; set; }

    [Column("STScreenTopMost")]
    public bool? StscreenTopMost { get; set; }

    [Column("STScreenMatchCode01")]
    [StringLength(50)]
    public string StscreenMatchCode01 { get; set; }

    [Column("STScreenShowInfoPanel")]
    public bool? StscreenShowInfoPanel { get; set; }

    [Column("STScreenSortOrder")]
    public int? StscreenSortOrder { get; set; }

    [Column("STScreenPrivilege")]
    [StringLength(50)]
    public string StscreenPrivilege { get; set; }

    [Column("STScreenVisible")]
    public bool? StscreenVisible { get; set; }

    [InverseProperty("Stscreen")]
    public virtual ICollection<Stfield> Stfields { get; set; } = new List<Stfield>();

    [ForeignKey("StmoduleId")]
    [InverseProperty("Stscreens")]
    public virtual Stmodule Stmodule { get; set; }

    [ForeignKey("StuserGroupId")]
    [InverseProperty("Stscreens")]
    public virtual AduserGroup StuserGroup { get; set; }
}
