﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SampleProject.Data.Models;

[Table("ICProductTolenrances")]
public partial class IcproductTolenrance
{
    [Key]
    [Column("ICProductTolenranceID")]
    public int IcproductTolenranceId { get; set; }

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

    [Column("FK_ICProductID")]
    public int? FkIcproductId { get; set; }

    [Column("ICProductTolenranceType")]
    [StringLength(100)]
    [Unicode(false)]
    public string IcproductTolenranceType { get; set; }

    [Column("ICProductTolenranceCalculateType")]
    [StringLength(100)]
    [Unicode(false)]
    public string IcproductTolenranceCalculateType { get; set; }

    [Column("ICProductTolenrancePlus", TypeName = "decimal(18, 5)")]
    public decimal? IcproductTolenrancePlus { get; set; }

    [Column("ICProductTolenranceMinus", TypeName = "decimal(18, 5)")]
    public decimal? IcproductTolenranceMinus { get; set; }

    [Column("ICProductTolenranceSortOrder")]
    public int? IcproductTolenranceSortOrder { get; set; }

    [ForeignKey("FkIcproductId")]
    [InverseProperty("IcproductTolenrances")]
    public virtual Icproduct FkIcproduct { get; set; }
}
