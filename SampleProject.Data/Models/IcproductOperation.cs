using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SampleProject.Data.Models;

[Table("ICProductOperations")]
public partial class IcproductOperation
{
    [Key]
    [Column("ICProductOperationID")]
    public int IcproductOperationId { get; set; }

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

    [Column("FK_ICProductID")]
    public int? FkIcproductId { get; set; }

    [Column("FK_MMOperationID")]
    public int? FkMmoperationId { get; set; }

    [Column("ICProductOperationNo")]
    [StringLength(50)]
    public string IcproductOperationNo { get; set; }

    [Column("ICProductOperationName")]
    [StringLength(50)]
    public string IcproductOperationName { get; set; }

    [Column("ICProductOperationDesc")]
    [StringLength(512)]
    public string IcproductOperationDesc { get; set; }

    [Column("ICProductOperationSetupTime", TypeName = "decimal(18, 5)")]
    public decimal? IcproductOperationSetupTime { get; set; }

    [Column("ICProductOperationCapacity", TypeName = "decimal(18, 5)")]
    public decimal? IcproductOperationCapacity { get; set; }

    [Column("ICCapacityUnit")]
    [StringLength(50)]
    public string IccapacityUnit { get; set; }

    [ForeignKey("FkIcproductId")]
    [InverseProperty("IcproductOperations")]
    public virtual Icproduct FkIcproduct { get; set; }
}
