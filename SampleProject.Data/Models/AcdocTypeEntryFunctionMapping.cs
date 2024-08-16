using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SampleProject.Data.Models;

[Table("ACDocTypeEntryFunctionMappings")]
public partial class AcdocTypeEntryFunctionMapping
{
    [Key]
    [Column("ACDocTypeEntryFunctionMappingID")]
    public int AcdocTypeEntryFunctionMappingId { get; set; }

    [Column("AAStatus")]
    [StringLength(50)]
    public string Aastatus { get; set; }

    [Column("FK_STModuleID")]
    public int? FkStmoduleId { get; set; }

    [Column("FK_STToolbarID")]
    public int? FkSttoolbarId { get; set; }

    [Column("FK_ACDocumentTypeID")]
    public int? FkAcdocumentTypeId { get; set; }

    [Column("FK_ACEntryTypeID")]
    public int? FkAcentryTypeId { get; set; }

    [ForeignKey("FkAcdocumentTypeId")]
    [InverseProperty("AcdocTypeEntryFunctionMappings")]
    public virtual AcdocumentType FkAcdocumentType { get; set; }

    [ForeignKey("FkAcentryTypeId")]
    [InverseProperty("AcdocTypeEntryFunctionMappings")]
    public virtual AcentryType FkAcentryType { get; set; }

    [ForeignKey("FkStmoduleId")]
    [InverseProperty("AcdocTypeEntryFunctionMappings")]
    public virtual Stmodule FkStmodule { get; set; }
}
