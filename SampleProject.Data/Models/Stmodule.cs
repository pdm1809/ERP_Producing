using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SampleProject.Data.Models;

[Table("STModules")]
public partial class Stmodule
{
    [Key]
    [Column("STModuleID")]
    public int StmoduleId { get; set; }

    [Column("AAStatus")]
    [StringLength(50)]
    [Unicode(false)]
    public string Aastatus { get; set; }

    [Required]
    [Column("STModuleName")]
    [StringLength(50)]
    [Unicode(false)]
    public string StmoduleName { get; set; }

    [Column("STModuleCode")]
    [StringLength(20)]
    [Unicode(false)]
    public string StmoduleCode { get; set; }

    [Column("STModuleMain")]
    public int StmoduleMain { get; set; }

    public int? IsVisible { get; set; }

    [Column("STModuleViewType")]
    [StringLength(50)]
    public string StmoduleViewType { get; set; }

    [InverseProperty("FkStmodule")]
    public virtual ICollection<AcdocTypeEntryFunctionMapping> AcdocTypeEntryFunctionMappings { get; set; } = new List<AcdocTypeEntryFunctionMapping>();

    [InverseProperty("FkStmodule")]
    public virtual ICollection<Adcriteria> Adcriteria { get; set; } = new List<Adcriteria>();

    [InverseProperty("Stmodule")]
    public virtual ICollection<AdmoduleFieldsToUser> AdmoduleFieldsToUsers { get; set; } = new List<AdmoduleFieldsToUser>();

    [InverseProperty("FkStmodule")]
    public virtual ICollection<AdobjectViewPermission> AdobjectViewPermissions { get; set; } = new List<AdobjectViewPermission>();

    [InverseProperty("FkStmodule")]
    public virtual ICollection<Adprivilege> Adprivileges { get; set; } = new List<Adprivilege>();

    [InverseProperty("Gemodule")]
    public virtual ICollection<Gecorrespondence> Gecorrespondences { get; set; } = new List<Gecorrespondence>();

    [InverseProperty("FkStmodule")]
    public virtual ICollection<IcproductConfigRate> IcproductConfigRates { get; set; } = new List<IcproductConfigRate>();

    [InverseProperty("Stmodule")]
    public virtual ICollection<StgridResultColumnDisplay> StgridResultColumnDisplays { get; set; } = new List<StgridResultColumnDisplay>();

    [InverseProperty("Stmodule")]
    public virtual ICollection<StmoduleDescription> StmoduleDescriptions { get; set; } = new List<StmoduleDescription>();

    [InverseProperty("Stmodule")]
    public virtual ICollection<StmoduleFunction> StmoduleFunctions { get; set; } = new List<StmoduleFunction>();

    [InverseProperty("Stmodule")]
    public virtual ICollection<StmoduleStatus> StmoduleStatuses { get; set; } = new List<StmoduleStatus>();

    [InverseProperty("Stmodule")]
    public virtual ICollection<StmoduleTable> StmoduleTables { get; set; } = new List<StmoduleTable>();

    [InverseProperty("Stmodule")]
    public virtual ICollection<StmoduleToUserGroupSection> StmoduleToUserGroupSections { get; set; } = new List<StmoduleToUserGroupSection>();

    [InverseProperty("Stmodule")]
    public virtual ICollection<StobjectStatus> StobjectStatuses { get; set; } = new List<StobjectStatus>();

    [InverseProperty("Stmodule")]
    public virtual ICollection<Stscreen> Stscreens { get; set; } = new List<Stscreen>();

    [InverseProperty("Stmodule")]
    public virtual ICollection<Sttoolbar> Sttoolbars { get; set; } = new List<Sttoolbar>();
}
