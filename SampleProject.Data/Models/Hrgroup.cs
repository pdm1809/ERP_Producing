using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SampleProject.Data.Models;

[Table("HRGroups")]
public partial class Hrgroup
{
    [Key]
    [Column("HRGroupID")]
    public int HrgroupId { get; set; }

    [Column("HRGroupDesc")]
    [StringLength(200)]
    public string HrgroupDesc { get; set; }

    [Required]
    [Column("HRGroupName")]
    [StringLength(100)]
    public string HrgroupName { get; set; }

    [Column("AAStatus")]
    [StringLength(10)]
    [Unicode(false)]
    public string Aastatus { get; set; }

    [Column("FK_BRBranchID")]
    public int FkBrbranchId { get; set; }

    [Column("HRLanguageIDCombo")]
    [StringLength(50)]
    public string HrlanguageIdcombo { get; set; }

    [Column("HRGroupSkinCombo")]
    [StringLength(50)]
    public string HrgroupSkinCombo { get; set; }

    [Column("HRGroupActiveCheck")]
    public bool? HrgroupActiveCheck { get; set; }

    [Column("HRGroupCode")]
    [StringLength(50)]
    public string HrgroupCode { get; set; }

    [Column("HRGroupCanBeModify")]
    public bool? HrgroupCanBeModify { get; set; }

    [Column("HRGroupSystem")]
    [StringLength(10)]
    [Unicode(false)]
    public string HrgroupSystem { get; set; }

    [Column("AACreatedDate", TypeName = "datetime")]
    public DateTime? AacreatedDate { get; set; }

    [Column("FK_CreatedUserID")]
    public int? FkCreatedUserId { get; set; }

    [Column("HRGroupRole")]
    [StringLength(50)]
    [Unicode(false)]
    public string HrgroupRole { get; set; }

    [Column("HRGroupIsManager")]
    public bool? HrgroupIsManager { get; set; }

    [InverseProperty("FkHrgroup")]
    public virtual ICollection<AduserGroupFunction> AduserGroupFunctions { get; set; } = new List<AduserGroupFunction>();

    [InverseProperty("FkHrgroup")]
    public virtual ICollection<Aractivity> Aractivities { get; set; } = new List<Aractivity>();

    [InverseProperty("FkHrgroup")]
    public virtual ICollection<Arcampaign> Arcampaigns { get; set; } = new List<Arcampaign>();

    [InverseProperty("FkHrgroup")]
    public virtual ICollection<ArcustomerContact> ArcustomerContacts { get; set; } = new List<ArcustomerContact>();

    [InverseProperty("FkHrgroup")]
    public virtual ICollection<Arcustomer> Arcustomers { get; set; } = new List<Arcustomer>();

    [InverseProperty("FkHrgroup")]
    public virtual ICollection<Arnotification> Arnotifications { get; set; } = new List<Arnotification>();

    [InverseProperty("FkHrgroup")]
    public virtual ICollection<Aropportunity> Aropportunities { get; set; } = new List<Aropportunity>();

    [InverseProperty("FkHrgroup")]
    public virtual ICollection<ArprospectCustomer> ArprospectCustomers { get; set; } = new List<ArprospectCustomer>();

    [ForeignKey("FkBrbranchId")]
    [InverseProperty("Hrgroups")]
    public virtual Brbranch FkBrbranch { get; set; }

    [ForeignKey("FkCreatedUserId")]
    [InverseProperty("Hrgroups")]
    public virtual Hremployee FkCreatedUser { get; set; }

    [InverseProperty("FkHrgroup")]
    public virtual ICollection<HremployeeGroup> HremployeeGroups { get; set; } = new List<HremployeeGroup>();

    [InverseProperty("FkHrgroup")]
    public virtual ICollection<PmtaskAssign> PmtaskAssigns { get; set; } = new List<PmtaskAssign>();

    [InverseProperty("FkHrgroup")]
    public virtual ICollection<Pmtask> Pmtasks { get; set; } = new List<Pmtask>();
}
