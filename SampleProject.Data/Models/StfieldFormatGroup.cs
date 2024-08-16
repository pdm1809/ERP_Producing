using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SampleProject.Data.Models;

[Table("STFieldFormatGroups")]
public partial class StfieldFormatGroup
{
    [Key]
    [Column("STFieldFormatGroupID")]
    public int StfieldFormatGroupId { get; set; }

    [Column("STFieldFormatGroupName")]
    [StringLength(50)]
    [Unicode(false)]
    public string StfieldFormatGroupName { get; set; }

    [Column("STFieldFormatGroupMaskEdit")]
    [StringLength(60)]
    [Unicode(false)]
    public string StfieldFormatGroupMaskEdit { get; set; }

    [Column("STFieldFormatGroupMaskType")]
    [StringLength(50)]
    [Unicode(false)]
    public string StfieldFormatGroupMaskType { get; set; }

    [Column("STFieldFormatGroupRepository")]
    [StringLength(50)]
    [Unicode(false)]
    public string StfieldFormatGroupRepository { get; set; }

    [Column("STFieldFormatGroupDecimalRound")]
    public int? StfieldFormatGroupDecimalRound { get; set; }

    [Column("STFieldFormatGroupUnit")]
    [StringLength(30)]
    public string StfieldFormatGroupUnit { get; set; }

    [Column("STFieldFormatGroupFieldType")]
    [StringLength(50)]
    [Unicode(false)]
    public string StfieldFormatGroupFieldType { get; set; }

    [Column("STFieldFormatGroupFieldLength")]
    public int? StfieldFormatGroupFieldLength { get; set; }

    [Column("STFieldFormatGroupTextAlign")]
    [StringLength(50)]
    [Unicode(false)]
    public string StfieldFormatGroupTextAlign { get; set; }

    [Column("STFieldFormatGroupFontName")]
    [StringLength(50)]
    [Unicode(false)]
    public string StfieldFormatGroupFontName { get; set; }

    [Column("STFieldFormatGroupFontSize")]
    public int? StfieldFormatGroupFontSize { get; set; }

    [Column("STFieldFormatGroupBackColor")]
    public int? StfieldFormatGroupBackColor { get; set; }

    [Column("STFieldFormatGroupForeColor")]
    public int? StfieldFormatGroupForeColor { get; set; }

    [Column("STFieldFormatGroupFormatType")]
    [StringLength(50)]
    [Unicode(false)]
    public string StfieldFormatGroupFormatType { get; set; }

    [Column("STFieldFormatGroupFormatString")]
    [StringLength(50)]
    [Unicode(false)]
    public string StfieldFormatGroupFormatString { get; set; }

    [InverseProperty("FkStfieldFormatGroup")]
    public virtual ICollection<Gecurrency> Gecurrencies { get; set; } = new List<Gecurrency>();

    [InverseProperty("FkStfieldFormatGroup")]
    public virtual ICollection<IcdepartmentFormat> IcdepartmentFormats { get; set; } = new List<IcdepartmentFormat>();

    [InverseProperty("StfieldFormatGroup")]
    public virtual ICollection<StfieldFormat> StfieldFormats { get; set; } = new List<StfieldFormat>();
}
