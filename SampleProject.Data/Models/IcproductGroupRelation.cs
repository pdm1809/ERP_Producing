using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SampleProject.Data.Models;

[Table("ICProductGroupRelations")]
public partial class IcproductGroupRelation
{
    [Key]
    [Column("ICProductGroupRelationID")]
    public int IcproductGroupRelationId { get; set; }

    [Column("AAStatus")]
    [StringLength(10)]
    [Unicode(false)]
    public string Aastatus { get; set; }

    [Column("FK_ICProductGroupRelationParentID")]
    public int FkIcproductGroupRelationParentId { get; set; }

    [Column("FK_ICProductGroupRelationChildID")]
    public int FkIcproductGroupRelationChildId { get; set; }

    [Column("ICProductGroupRelationOrder")]
    public int IcproductGroupRelationOrder { get; set; }

    [ForeignKey("FkIcproductGroupRelationChildId")]
    [InverseProperty("IcproductGroupRelationFkIcproductGroupRelationChildren")]
    public virtual IcproductGroup FkIcproductGroupRelationChild { get; set; }

    [ForeignKey("FkIcproductGroupRelationParentId")]
    [InverseProperty("IcproductGroupRelationFkIcproductGroupRelationParents")]
    public virtual IcproductGroup FkIcproductGroupRelationParent { get; set; }
}
