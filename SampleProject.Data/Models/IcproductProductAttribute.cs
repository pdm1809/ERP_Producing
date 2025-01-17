﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SampleProject.Data.Models;

[Table("ICProductProductAttributes")]
public partial class IcproductProductAttribute
{
    [Key]
    [Column("ICProductProductAttributeID")]
    public int IcproductProductAttributeId { get; set; }

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

    [Column("FK_ICProductAttributeID")]
    public int? FkIcproductAttributeId { get; set; }

    [Required]
    [Column("ICProductProductAttributeGroup")]
    [StringLength(50)]
    public string IcproductProductAttributeGroup { get; set; }

    [ForeignKey("FkIcproductId")]
    [InverseProperty("IcproductProductAttributes")]
    public virtual Icproduct FkIcproduct { get; set; }

    [ForeignKey("FkIcproductAttributeId")]
    [InverseProperty("IcproductProductAttributes")]
    public virtual IcproductAttribute FkIcproductAttribute { get; set; }
}
