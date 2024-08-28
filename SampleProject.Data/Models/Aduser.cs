using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SampleProject.Data.Models;

[Table("ADUsers")]
[Microsoft.EntityFrameworkCore.Index("FkHremployeeId", Name = "Idx_ADUsers")]
public partial class Aduser
{
    [Key]
    [Column("ADUserID")]
    public int AduserId { get; set; }

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

    [Column("ADUserGroupID")]
    public int AduserGroupId { get; set; }

    [Column("FK_HREmployeeID")]
    public int? FkHremployeeId { get; set; }

    [Column("ADContactID")]
    public int? AdcontactId { get; set; }

    [Required]
    [Column("ADUserName")]
    [StringLength(50)]
    public string AduserName { get; set; }

    [Required]
    [Column("ADPassword")]
    [StringLength(100)]
    [Unicode(false)]
    public string Adpassword { get; set; }

    [Column("ADProfileDirectory")]
    [StringLength(255)]
    public string AdprofileDirectory { get; set; }

    [Column("ADUserStyle")]
    [StringLength(50)]
    [Unicode(false)]
    public string AduserStyle { get; set; }

    [Column("ADUserStyleSkin")]
    [StringLength(50)]
    [Unicode(false)]
    public string AduserStyleSkin { get; set; }

    [Column("ADUserActiveCheck")]
    public bool? AduserActiveCheck { get; set; }

    [Column("AACreatedDate")]
    public DateTime? AacreatedDate { get; set; }

    [Column("AAUpdatedDate")]
    public DateTime? AaupdatedDate { get; set; }

    [Column("ADUserResetToken")]
    [StringLength(50)]
    public string AduserResetToken { get; set; }

    [Column("ADUserIsCustomizeColumn")]
    public bool? AduserIsCustomizeColumn { get; set; }

    [Column("ADUserIsAllowExportExcel")]
    public bool? AduserIsAllowExportExcel { get; set; }

    [Column("ADUserIsExceptionalSalePermission")]
    public bool? AduserIsExceptionalSalePermission { get; set; }

    [InverseProperty("FkAduser")]
    public virtual ICollection<Adcriteria> Adcriteria { get; set; } = new List<Adcriteria>();

    [InverseProperty("FkAduser")]
    public virtual ICollection<AddataViewPermission> AddataViewPermissions { get; set; } = new List<AddataViewPermission>();

    [InverseProperty("Aduser")]
    public virtual ICollection<AdmoduleFieldsToUser> AdmoduleFieldsToUsers { get; set; } = new List<AdmoduleFieldsToUser>();

    [InverseProperty("FkAduser")]
    public virtual ICollection<AdpushNotification> AdpushNotifications { get; set; } = new List<AdpushNotification>();

    [InverseProperty("FkAduser")]
    public virtual ICollection<AduserDevice> AduserDevices { get; set; } = new List<AduserDevice>();

    [ForeignKey("AduserGroupId")]
    [InverseProperty("Adusers")]
    public virtual AduserGroup AduserGroup { get; set; }

    [InverseProperty("FkAduser")]
    public virtual ICollection<AduserLocation> AduserLocations { get; set; } = new List<AduserLocation>();

    [InverseProperty("FkAduser")]
    public virtual ICollection<AppurchaseOrderHistory> AppurchaseOrderHistories { get; set; } = new List<AppurchaseOrderHistory>();

    [InverseProperty("FkAduser")]
    public virtual ICollection<ArsaleOrderHistory> ArsaleOrderHistories { get; set; } = new List<ArsaleOrderHistory>();

    [InverseProperty("Fauser")]
    public virtual ICollection<FacreditNoteHistory> FacreditNoteHistories { get; set; } = new List<FacreditNoteHistory>();

    [InverseProperty("Fauser")]
    public virtual ICollection<FainvoiceHistory> FainvoiceHistories { get; set; } = new List<FainvoiceHistory>();

    [InverseProperty("Fauser")]
    public virtual ICollection<FaproposalHistory> FaproposalHistories { get; set; } = new List<FaproposalHistory>();

    [InverseProperty("Fauser")]
    public virtual ICollection<FapurchaseOrderHistory> FapurchaseOrderHistories { get; set; } = new List<FapurchaseOrderHistory>();

    [InverseProperty("Fauser")]
    public virtual ICollection<FareceiptHistory> FareceiptHistories { get; set; } = new List<FareceiptHistory>();

    [InverseProperty("Fauser")]
    public virtual ICollection<FareturnSupplierHistory> FareturnSupplierHistories { get; set; } = new List<FareturnSupplierHistory>();

    [InverseProperty("Fauser")]
    public virtual ICollection<FasellReturnHistory> FasellReturnHistories { get; set; } = new List<FasellReturnHistory>();

    [InverseProperty("Fauser")]
    public virtual ICollection<FashipmentHistory> FashipmentHistories { get; set; } = new List<FashipmentHistory>();

    [InverseProperty("Fauser")]
    public virtual ICollection<FatransferHistory> FatransferHistories { get; set; } = new List<FatransferHistory>();

    [ForeignKey("FkHremployeeId")]
    [InverseProperty("Adusers")]
    public virtual Hremployee FkHremployee { get; set; }

    [InverseProperty("Stuser")]
    public virtual ICollection<StmoduleStatus> StmoduleStatuses { get; set; } = new List<StmoduleStatus>();
}
