using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SampleProject.Data.Models;

[Table("HRDormitoryItems")]
public partial class HrdormitoryItem
{
    [Key]
    [Column("HRDormitoryItemID")]
    public int HrdormitoryItemId { get; set; }

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
    [Unicode(false)]
    public string Aastatus { get; set; }

    [Column("FK_HRDormitoryID")]
    public int? FkHrdormitoryId { get; set; }

    [Column("FK_ICProductID")]
    public int? FkIcproductId { get; set; }

    [Column("HRDormitoryItemProductName")]
    [StringLength(50)]
    public string HrdormitoryItemProductName { get; set; }

    [Column("HRDormitoryItemProductQty")]
    public int? HrdormitoryItemProductQty { get; set; }

    [Column("HRDormitoryItemProductDesc", TypeName = "ntext")]
    public string HrdormitoryItemProductDesc { get; set; }

    [ForeignKey("FkHrdormitoryId")]
    [InverseProperty("HrdormitoryItems")]
    public virtual Hrdormitory FkHrdormitory { get; set; }

    [ForeignKey("FkIcproductId")]
    [InverseProperty("HrdormitoryItems")]
    public virtual Icproduct FkIcproduct { get; set; }
}
