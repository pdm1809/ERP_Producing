using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SampleProject.Data.Models;

[Table("ADUserGroups")]
public partial class AduserGroup
{
    [Key]
    [Column("ADUserGroupID")]
    public int AduserGroupId { get; set; }

    [Column("AANumberString")]
    [StringLength(50)]
    [Unicode(false)]
    public string AanumberString { get; set; }

    [Column("AANumberInt")]
    public int? AanumberInt { get; set; }

    [Column("AAStatus")]
    [StringLength(10)]
    [Unicode(false)]
    public string Aastatus { get; set; }

    [Column("ADLanguageIDCombo")]
    public int AdlanguageIdcombo { get; set; }

    [Column("ADUserGroupSkinCombo")]
    [StringLength(50)]
    public string AduserGroupSkinCombo { get; set; }

    [Required]
    [Column("ADUserGroupName")]
    [StringLength(50)]
    public string AduserGroupName { get; set; }

    [Column("ADUserGroupDesc")]
    [StringLength(255)]
    public string AduserGroupDesc { get; set; }

    [Column("ADUserGroupActiveCheck")]
    public bool? AduserGroupActiveCheck { get; set; }

    [Column("ADUserGroupCreatedDate", TypeName = "datetime")]
    public DateTime? AduserGroupCreatedDate { get; set; }

    [Column("ADUserGroupCode")]
    [StringLength(50)]
    [Unicode(false)]
    public string AduserGroupCode { get; set; }

    [Column("ADUserGroupCanBeModify")]
    public bool? AduserGroupCanBeModify { get; set; }

    [Column("ADUserGroupSystem")]
    [StringLength(10)]
    [Unicode(false)]
    public string AduserGroupSystem { get; set; }

    [InverseProperty("FkAduserGroup")]
    public virtual ICollection<AdappUserPermission> AdappUserPermissions { get; set; } = new List<AdappUserPermission>();

    [InverseProperty("FkAduserGroup")]
    public virtual ICollection<AdcompletePermissionConfig> AdcompletePermissionConfigs { get; set; } = new List<AdcompletePermissionConfig>();

    [InverseProperty("FkAduserGroup")]
    public virtual ICollection<AdgroupTimeSheetPermission> AdgroupTimeSheetPermissions { get; set; } = new List<AdgroupTimeSheetPermission>();

    [ForeignKey("AdlanguageIdcombo")]
    [InverseProperty("AduserGroups")]
    public virtual Gelanguage AdlanguageIdcomboNavigation { get; set; }

    [InverseProperty("FkAduserGroup")]
    public virtual ICollection<AdprivilegeUserGroup> AdprivilegeUserGroups { get; set; } = new List<AdprivilegeUserGroup>();

    [InverseProperty("FkAduserGroup")]
    public virtual ICollection<AdreportPermission> AdreportPermissions { get; set; } = new List<AdreportPermission>();

    [InverseProperty("FkAduserGroup")]
    public virtual ICollection<AduserGroupFunction> AduserGroupFunctions { get; set; } = new List<AduserGroupFunction>();

    [InverseProperty("FkAduserGroup")]
    public virtual ICollection<AduserGroupMember> AduserGroupMembers { get; set; } = new List<AduserGroupMember>();

    [InverseProperty("AduserGroup")]
    public virtual ICollection<AduserGroupSection> AduserGroupSections { get; set; } = new List<AduserGroupSection>();

    [InverseProperty("AduserGroup")]
    public virtual ICollection<Aduser> Adusers { get; set; } = new List<Aduser>();

    [InverseProperty("FkAduserGroup")]
    public virtual ICollection<Aractivity> Aractivities { get; set; } = new List<Aractivity>();

    [InverseProperty("FkAduserGroup")]
    public virtual ICollection<Arcampaign> Arcampaigns { get; set; } = new List<Arcampaign>();

    [InverseProperty("FkAduserGroup")]
    public virtual ICollection<ArcustomerContact> ArcustomerContacts { get; set; } = new List<ArcustomerContact>();

    [InverseProperty("FkAduserGroup")]
    public virtual ICollection<Arcustomer> Arcustomers { get; set; } = new List<Arcustomer>();

    [InverseProperty("FkAduserGroup")]
    public virtual ICollection<Arnotification> Arnotifications { get; set; } = new List<Arnotification>();

    [InverseProperty("FkAduserGroup")]
    public virtual ICollection<Aropportunity> Aropportunities { get; set; } = new List<Aropportunity>();

    [InverseProperty("FkAduserGroup")]
    public virtual ICollection<ArprospectCustomer> ArprospectCustomers { get; set; } = new List<ArprospectCustomer>();

    [InverseProperty("FkAduserGroup")]
    public virtual ICollection<CscompanyConfig> CscompanyConfigs { get; set; } = new List<CscompanyConfig>();

    [InverseProperty("FkAduserGroup")]
    public virtual ICollection<IcinventoryPermission> IcinventoryPermissions { get; set; } = new List<IcinventoryPermission>();

    [InverseProperty("FkAduserGroup")]
    public virtual ICollection<PmtaskAssign> PmtaskAssigns { get; set; } = new List<PmtaskAssign>();

    [InverseProperty("FkAduserGroup")]
    public virtual ICollection<Pmtask> Pmtasks { get; set; } = new List<Pmtask>();

    [InverseProperty("FkAduserGroup")]
    public virtual ICollection<StfieldColumnPermission> StfieldColumnPermissions { get; set; } = new List<StfieldColumnPermission>();

    [InverseProperty("FkAduserGroup")]
    public virtual ICollection<StfieldPermission> StfieldPermissions { get; set; } = new List<StfieldPermission>();

    [InverseProperty("StuserGroup")]
    public virtual ICollection<Stfield> Stfields { get; set; } = new List<Stfield>();

    [InverseProperty("StuserGroup")]
    public virtual ICollection<StmoduleFunctionParameterValue> StmoduleFunctionParameterValues { get; set; } = new List<StmoduleFunctionParameterValue>();

    [InverseProperty("FkAduserGroup")]
    public virtual ICollection<StscreenPermission> StscreenPermissions { get; set; } = new List<StscreenPermission>();

    [InverseProperty("StuserGroup")]
    public virtual ICollection<Stscreen> Stscreens { get; set; } = new List<Stscreen>();

    [InverseProperty("StuserGroup")]
    public virtual ICollection<Sttoolbar> Sttoolbars { get; set; } = new List<Sttoolbar>();
}
