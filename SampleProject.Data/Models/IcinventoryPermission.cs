using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SampleProject.Data.Models;

[Table("ICInventoryPermissions")]
[Microsoft.EntityFrameworkCore.Index("FkIcstockId", "IcinventoryPermissionType", Name = "Idx_ICInventoryPermissions")]
public partial class IcinventoryPermission
{
    [Key]
    [Column("ICInventoryPermissionID")]
    public int IcinventoryPermissionId { get; set; }

    [Column("AAStatus")]
    [StringLength(50)]
    [Unicode(false)]
    public string Aastatus { get; set; }

    [Column("FK_ADUserGroupID")]
    public int FkAduserGroupId { get; set; }

    [Column("FK_ICStockID")]
    public int FkIcstockId { get; set; }

    [Column("ICInventoryPermissionType")]
    public byte IcinventoryPermissionType { get; set; }

    [ForeignKey("FkAduserGroupId")]
    [InverseProperty("IcinventoryPermissions")]
    public virtual AduserGroup FkAduserGroup { get; set; }

    [ForeignKey("FkIcstockId")]
    [InverseProperty("IcinventoryPermissions")]
    public virtual Icstock FkIcstock { get; set; }
}
