using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SampleProject.Data.Models;

[Table("MMOperationAndHardwareOperationTypes")]
public partial class MmoperationAndHardwareOperationType
{
    [Key]
    [Column("MMOperationAndHardwareOperationTypeID")]
    public int MmoperationAndHardwareOperationTypeId { get; set; }

    [Column("AAStatus")]
    [StringLength(50)]
    [Unicode(false)]
    public string Aastatus { get; set; }

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

    [Column("MMHardwareOperationType")]
    [StringLength(50)]
    public string MmhardwareOperationType { get; set; }

    [Column("FK_MMOperationID")]
    public int? FkMmoperationId { get; set; }
}
