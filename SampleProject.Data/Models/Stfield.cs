using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SampleProject.Data.Models;

[Table("STFields")]
[Microsoft.EntityFrameworkCore.Index("StfieldType", Name = "Idx_STFields")]
public partial class Stfield
{
    [Key]
    [Column("STFieldID")]
    public int StfieldId { get; set; }

    [Required]
    [Column("STFieldName")]
    [StringLength(50)]
    [Unicode(false)]
    public string StfieldName { get; set; }

    [Column("STFieldDesc")]
    [StringLength(255)]
    public string StfieldDesc { get; set; }

    [Column("STFieldText")]
    [StringLength(255)]
    public string StfieldText { get; set; }

    [Column("STFieldHint")]
    [StringLength(500)]
    public string StfieldHint { get; set; }

    [Column("STFieldType")]
    [StringLength(50)]
    [Unicode(false)]
    public string StfieldType { get; set; }

    [Column("STScreenID")]
    public int StscreenId { get; set; }

    [Column("STUserGroupID")]
    public int StuserGroupId { get; set; }

    [Column("STFieldLocationX")]
    public int StfieldLocationX { get; set; }

    [Column("STFieldLocationY")]
    public int StfieldLocationY { get; set; }

    [Column("STFieldSizeHeight")]
    public int StfieldSizeHeight { get; set; }

    [Column("STFieldSizeWidth")]
    public int StfieldSizeWidth { get; set; }

    [Column("STFieldBackColor")]
    public int StfieldBackColor { get; set; }

    [Column("STFieldForeColor")]
    public int StfieldForeColor { get; set; }

    [Column("STFieldEnabled")]
    public bool StfieldEnabled { get; set; }

    [Column("STFieldVisible")]
    public bool? StfieldVisible { get; set; }

    [Column("STFieldTag")]
    [StringLength(50)]
    [Unicode(false)]
    public string StfieldTag { get; set; }

    [Column("STFieldDataSource")]
    [StringLength(255)]
    [Unicode(false)]
    public string StfieldDataSource { get; set; }

    [Column("STFieldDataMember")]
    [StringLength(255)]
    [Unicode(false)]
    public string StfieldDataMember { get; set; }

    [Column("STFieldBindingPropertyName")]
    [StringLength(50)]
    [Unicode(false)]
    public string StfieldBindingPropertyName { get; set; }

    [Column("STFieldTabIndex")]
    public int StfieldTabIndex { get; set; }

    [Required]
    [Column("STFieldFontName")]
    [StringLength(500)]
    public string StfieldFontName { get; set; }

    [Column("STFieldFontSize")]
    public double? StfieldFontSize { get; set; }

    [Required]
    [Column("STFieldFontStyle")]
    [StringLength(100)]
    [Unicode(false)]
    public string StfieldFontStyle { get; set; }

    [Column("STFieldTextEditStyle")]
    [StringLength(50)]
    [Unicode(false)]
    public string StfieldTextEditStyle { get; set; }

    [Column("STFieldEditMask")]
    [StringLength(255)]
    [Unicode(false)]
    public string StfieldEditMask { get; set; }

    [Column("STFieldMaskType")]
    [StringLength(50)]
    [Unicode(false)]
    public string StfieldMaskType { get; set; }

    [Column("STFieldTextAlign")]
    [StringLength(100)]
    [Unicode(false)]
    public string StfieldTextAlign { get; set; }

    [Column("STFieldDateTimeFormat")]
    [StringLength(50)]
    [Unicode(false)]
    public string StfieldDateTimeFormat { get; set; }

    [Column("STFieldQueryBuilder")]
    [StringLength(1000)]
    [Unicode(false)]
    public string StfieldQueryBuilder { get; set; }

    [Column("STFieldDock")]
    [StringLength(50)]
    [Unicode(false)]
    public string StfieldDock { get; set; }

    [Column("STFieldItemCollection")]
    [StringLength(500)]
    public string StfieldItemCollection { get; set; }

    [Column("STFieldGridControlType")]
    [StringLength(50)]
    [Unicode(false)]
    public string StfieldGridControlType { get; set; }

    /// <summary>
    /// Active
    /// Deleted
    /// </summary>
    [Required]
    [Column("STFieldStatus")]
    [StringLength(50)]
    [Unicode(false)]
    public string StfieldStatus { get; set; }

    [Column("STFieldDataStatus")]
    [StringLength(50)]
    [Unicode(false)]
    public string StfieldDataStatus { get; set; }

    [Column("STFieldCharacterCase")]
    [StringLength(50)]
    [Unicode(false)]
    public string StfieldCharacterCase { get; set; }

    [Column("STFieldDisplayMember")]
    [StringLength(50)]
    [Unicode(false)]
    public string StfieldDisplayMember { get; set; }

    [Column("STFieldValueMember")]
    [StringLength(50)]
    [Unicode(false)]
    public string StfieldValueMember { get; set; }

    [Column("STFieldCheckedStyle")]
    [StringLength(50)]
    [Unicode(false)]
    public string StfieldCheckedStyle { get; set; }

    [Column("STFieldReadOnly")]
    public bool? StfieldReadOnly { get; set; }

    [Column("STFieldGroup")]
    [StringLength(50)]
    public string StfieldGroup { get; set; }

    [Column("STFieldError")]
    [StringLength(500)]
    public string StfieldError { get; set; }

    [Column("STFieldScrollBars")]
    [StringLength(50)]
    public string StfieldScrollBars { get; set; }

    [Column("STFieldBorderStyle")]
    [StringLength(50)]
    [Unicode(false)]
    public string StfieldBorderStyle { get; set; }

    [Column("STFieldRightToLeft")]
    [StringLength(50)]
    [Unicode(false)]
    public string StfieldRightToLeft { get; set; }

    [Column("STFieldFieldRelation")]
    [StringLength(50)]
    [Unicode(false)]
    public string StfieldFieldRelation { get; set; }

    [Column("STFieldFieldParent")]
    [StringLength(50)]
    [Unicode(false)]
    public string StfieldFieldParent { get; set; }

    [Column("STFieldAllowDummy")]
    public bool? StfieldAllowDummy { get; set; }

    [Column("STFieldSelectType")]
    [StringLength(50)]
    [Unicode(false)]
    public string StfieldSelectType { get; set; }

    [Column("STFieldSelectTypeValue")]
    [StringLength(50)]
    [Unicode(false)]
    public string StfieldSelectTypeValue { get; set; }

    [Column("STFieldDisplayRoot")]
    public bool? StfieldDisplayRoot { get; set; }

    [Column("STFieldDisplayOption")]
    public bool? StfieldDisplayOption { get; set; }

    [Column("STFieldPrivilege")]
    [StringLength(50)]
    public string StfieldPrivilege { get; set; }

    [Column("STFieldParentID")]
    public int? StfieldParentId { get; set; }

    [InverseProperty("Stfield")]
    public virtual ICollection<StfieldColumn> StfieldColumns { get; set; } = new List<StfieldColumn>();

    [InverseProperty("Stfield")]
    public virtual ICollection<StfieldEvent> StfieldEvents { get; set; } = new List<StfieldEvent>();

    [ForeignKey("StscreenId")]
    [InverseProperty("Stfields")]
    public virtual Stscreen Stscreen { get; set; }

    [ForeignKey("StuserGroupId")]
    [InverseProperty("Stfields")]
    public virtual AduserGroup StuserGroup { get; set; }
}
