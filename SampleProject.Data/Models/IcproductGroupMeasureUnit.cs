using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SampleProject.Data.Models;

[Table("ICProductGroupMeasureUnits")]
public partial class IcproductGroupMeasureUnit
{
    [Key]
    [Column("ICProductGroupMeasureUnitID")]
    public int IcproductGroupMeasureUnitId { get; set; }

    [Column("AAStatus")]
    [StringLength(50)]
    [Unicode(false)]
    public string Aastatus { get; set; }

    [Column("FK_ICProductGroupID")]
    public int? FkIcproductGroupId { get; set; }

    [Column("ICMeasureUnitListID")]
    [StringLength(200)]
    public string IcmeasureUnitListId { get; set; }

    [ForeignKey("FkIcproductGroupId")]
    [InverseProperty("IcproductGroupMeasureUnits")]
    public virtual IcproductGroup FkIcproductGroup { get; set; }
}
