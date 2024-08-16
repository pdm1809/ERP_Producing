using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SampleProject.Data.Models;

[Table("ICBarcodes")]
public partial class Icbarcode
{
    [Key]
    [Column("ICBarcodeID")]
    public int IcbarcodeId { get; set; }

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

    [Required]
    [Column("ICBarcodeNo")]
    [StringLength(50)]
    public string IcbarcodeNo { get; set; }

    [Column("ICBarcodeDate", TypeName = "datetime")]
    public DateTime? IcbarcodeDate { get; set; }

    [Column("ICBarcodeDesc")]
    [StringLength(512)]
    public string IcbarcodeDesc { get; set; }

    [Column("ICBarcodeReference")]
    [StringLength(50)]
    [Unicode(false)]
    public string IcbarcodeReference { get; set; }

    [Column("ICBarcodeStatus")]
    [StringLength(50)]
    [Unicode(false)]
    public string IcbarcodeStatus { get; set; }

    [Column("FK_HREmployeeID")]
    public int? FkHremployeeId { get; set; }

    [ForeignKey("FkHremployeeId")]
    [InverseProperty("Icbarcodes")]
    public virtual Hremployee FkHremployee { get; set; }

    [InverseProperty("FkIcbarcode")]
    public virtual ICollection<IcbarcodeItem> IcbarcodeItems { get; set; } = new List<IcbarcodeItem>();
}
