using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SampleProject.Data.Models;

[Table("ICProductSerialNumbers")]
public partial class IcproductSerialNumber
{
    [Key]
    [Column("ICProductSerialNumberID")]
    public int IcproductSerialNumberId { get; set; }

    [Column("AACreatedUser")]
    [StringLength(50)]
    public string AacreatedUser { get; set; }

    [Column("AACreatedDate", TypeName = "datetime")]
    public DateTime? AacreatedDate { get; set; }

    [Column("AAUpdatedUser")]
    [StringLength(50)]
    public string AaupdatedUser { get; set; }

    [Column("AAUpdatedDate", TypeName = "datetime")]
    public DateTime? AaupdatedDate { get; set; }

    [Column("AAStatus")]
    [StringLength(10)]
    [Unicode(false)]
    public string Aastatus { get; set; }

    [Required]
    [Column("ICProductSerialNumberNo")]
    [StringLength(50)]
    public string IcproductSerialNumberNo { get; set; }

    [Column("FK_ICProductID")]
    public int FkIcproductId { get; set; }

    [Column("FK_ICProductSerieID")]
    public int FkIcproductSerieId { get; set; }

    [Column("ICProductSerialNumberStatus")]
    [StringLength(50)]
    public string IcproductSerialNumberStatus { get; set; }

    [ForeignKey("FkIcproductId")]
    [InverseProperty("IcproductSerialNumbers")]
    public virtual Icproduct FkIcproduct { get; set; }

    [ForeignKey("FkIcproductSerieId")]
    [InverseProperty("IcproductSerialNumbers")]
    public virtual IcproductSeries FkIcproductSerie { get; set; }
}
