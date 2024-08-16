using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SampleProject.Data.Models;

[Table("ICConfigAccordWoodTypes")]
public partial class IcconfigAccordWoodType
{
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

    [Column("FK_ICProductAttributeWoodTypeID")]
    public int? FkIcproductAttributeWoodTypeId { get; set; }

    [Column("FK_ICProductAttributeID")]
    public int? FkIcproductAttributeId { get; set; }

    [Column("ICConfigAccordWoodTypeAttributeType")]
    [StringLength(50)]
    public string IcconfigAccordWoodTypeAttributeType { get; set; }

    [Key]
    [Column("ICConfigAccordWoodTypeID")]
    public int IcconfigAccordWoodTypeId { get; set; }

    [ForeignKey("FkIcproductAttributeId")]
    [InverseProperty("IcconfigAccordWoodTypeFkIcproductAttributes")]
    public virtual IcproductAttribute FkIcproductAttribute { get; set; }

    [ForeignKey("FkIcproductAttributeWoodTypeId")]
    [InverseProperty("IcconfigAccordWoodTypeFkIcproductAttributeWoodTypes")]
    public virtual IcproductAttribute FkIcproductAttributeWoodType { get; set; }
}
