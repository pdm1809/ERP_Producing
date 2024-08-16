using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SampleProject.Data.Models;

[Table("ADObjectViewPermissions")]
public partial class AdobjectViewPermission
{
    [Key]
    [Column("ADObjectViewPermissionID")]
    public int AdobjectViewPermissionId { get; set; }

    [Column("AAStatus")]
    [StringLength(50)]
    public string Aastatus { get; set; }

    [Column("FK_STModuleID")]
    public int? FkStmoduleId { get; set; }

    [Column("ADObjectDataViewPermissionIsShowBranch")]
    public bool? AdobjectDataViewPermissionIsShowBranch { get; set; }

    [Column("ADObjectDataViewPermissionIsShowCustomer")]
    public bool? AdobjectDataViewPermissionIsShowCustomer { get; set; }

    [Column("ADObjectDataViewPermissionIsShowEmployee")]
    public bool? AdobjectDataViewPermissionIsShowEmployee { get; set; }

    [Column("ADObjectDataViewPermissionIsShowSupplier")]
    public bool? AdobjectDataViewPermissionIsShowSupplier { get; set; }

    [ForeignKey("FkStmoduleId")]
    [InverseProperty("AdobjectViewPermissions")]
    public virtual Stmodule FkStmodule { get; set; }
}
