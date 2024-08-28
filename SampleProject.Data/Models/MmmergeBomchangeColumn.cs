using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SampleProject.Data.Models;

[Table("MMMergeBOMChangeColumns")]
public partial class MmmergeBomchangeColumn
{
    [Key]
    [Column("MMMergeBOMChangeColumnID")]
    public int MmmergeBomchangeColumnId { get; set; }

    [Column("AACreatedDate", TypeName = "datetime")]
    public DateTime? AacreatedDate { get; set; }

    [Column("AACreatedUser")]
    [StringLength(50)]
    public string AacreatedUser { get; set; }

    [Column("AAUpdatedDate", TypeName = "datetime")]
    public DateTime? AaupdatedDate { get; set; }

    [Column("AAUpdatedUser")]
    [StringLength(50)]
    public string AaupdatedUser { get; set; }

    [Column("AAStatus")]
    [StringLength(10)]
    public string Aastatus { get; set; }

    [Column("MMMergeBOMChangeType")]
    [StringLength(50)]
    public string MmmergeBomchangeType { get; set; }

    [Column("MMColumnName")]
    [StringLength(100)]
    public string MmcolumnName { get; set; }

    [Column("MMColumnCaption")]
    [StringLength(100)]
    public string MmcolumnCaption { get; set; }

    [Column("MMColumnIndex")]
    public int? MmcolumnIndex { get; set; }

    [Column("MMTableLookUp")]
    [StringLength(100)]
    public string MmtableLookUp { get; set; }

    [Column("MMTableLookUpDisplayColumn")]
    [StringLength(100)]
    public string MmtableLookUpDisplayColumn { get; set; }

    [Column("MMTableLookUpValueColumn")]
    [StringLength(100)]
    public string MmtableLookUpValueColumn { get; set; }

    [Column("MMFormatType")]
    [StringLength(50)]
    public string MmformatType { get; set; }

    [Column("MMFormatString")]
    [StringLength(50)]
    public string MmformatString { get; set; }
}
