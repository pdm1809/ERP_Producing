using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SampleProject.Data.Models;

[PrimaryKey("ArcustomerContactId", "Rev")]
[Table("ARCustomerContacts_HISTORYS", Schema = "CRM_VINMUS_AUDIT")]
public partial class ArcustomerContactsHistory
{
    [Key]
    [Column("ARCustomerContactID")]
    public int ArcustomerContactId { get; set; }

    [Key]
    [Column("REV")]
    public int Rev { get; set; }

    [Column("REVTYPE")]
    public short? Revtype { get; set; }

    [Column("ARCustomerContactAddress")]
    [StringLength(200)]
    public string ArcustomerContactAddress { get; set; }

    [Column("ARCustomerContactAddress2")]
    [StringLength(200)]
    public string ArcustomerContactAddress2 { get; set; }

    [Column("ARCustomerContactAssignedTo")]
    [StringLength(50)]
    public string ArcustomerContactAssignedTo { get; set; }

    [Column("ARCustomerContactAssistant")]
    [StringLength(100)]
    public string ArcustomerContactAssistant { get; set; }

    [Column("ARCustomerContactAssistantPhone")]
    [StringLength(255)]
    [Unicode(false)]
    public string ArcustomerContactAssistantPhone { get; set; }

    [Column("ARCustomerContactBirthday", TypeName = "datetime")]
    public DateTime? ArcustomerContactBirthday { get; set; }

    [Column("ARCustomerContactCellularPhone")]
    [StringLength(255)]
    [Unicode(false)]
    public string ArcustomerContactCellularPhone { get; set; }

    [Column("ARCustomerContactAddressCity")]
    [StringLength(50)]
    public string ArcustomerContactAddressCity { get; set; }

    [Column("ARCustomerContactAddressCity2")]
    [StringLength(50)]
    public string ArcustomerContactAddressCity2 { get; set; }

    [Column("ARCustomerContactAddressCountry")]
    [StringLength(50)]
    public string ArcustomerContactAddressCountry { get; set; }

    [Column("ARCustomerContactAddressCountry2")]
    [StringLength(50)]
    public string ArcustomerContactAddressCountry2 { get; set; }

    [Column("AACreatedDate", TypeName = "datetime")]
    public DateTime? AacreatedDate { get; set; }

    [Column("AACreatedUser")]
    [StringLength(50)]
    public string AacreatedUser { get; set; }

    [Column("CreatedUserID")]
    public int? CreatedUserId { get; set; }

    [Column("FK_ARCustomerID")]
    public int? FkArcustomerId { get; set; }

    [Column("ARCustomerContactDepartment")]
    [StringLength(50)]
    public string ArcustomerContactDepartment { get; set; }

    [Column("ARCustomerContactAddressDistrict")]
    [StringLength(50)]
    public string ArcustomerContactAddressDistrict { get; set; }

    [Column("ARCustomerContactAddressDistrict2")]
    [StringLength(50)]
    public string ArcustomerContactAddressDistrict2 { get; set; }

    [Column("ARCustomerContactEmail1")]
    [StringLength(100)]
    public string ArcustomerContactEmail1 { get; set; }

    [Column("FK_HRGroupID")]
    public int? FkHrgroupId { get; set; }

    [Column("FK_HREmployeeID")]
    public int? FkHremployeeId { get; set; }

    [Column("ARCustomerContactFirstName")]
    [StringLength(50)]
    public string ArcustomerContactFirstName { get; set; }

    [Column("ARCustomerContactHomePhone")]
    [StringLength(255)]
    [Unicode(false)]
    public string ArcustomerContactHomePhone { get; set; }

    [Column("ARCustomerContactImage")]
    public byte[] ArcustomerContactImage { get; set; }

    [Column("ARCustomerContactInformation")]
    [StringLength(2000)]
    public string ArcustomerContactInformation { get; set; }

    [Column("ARCustomerContactJobTitle")]
    [StringLength(100)]
    public string ArcustomerContactJobTitle { get; set; }

    [Column("ARCustomerContactLastName")]
    [StringLength(50)]
    public string ArcustomerContactLastName { get; set; }

    [Column("ARCustomerContactName")]
    [StringLength(100)]
    public string ArcustomerContactName { get; set; }

    [Column("ARCustomerContactPhone")]
    [StringLength(255)]
    [Unicode(false)]
    public string ArcustomerContactPhone { get; set; }

    [Column("ARCustomerContactPotentialSource")]
    [StringLength(100)]
    public string ArcustomerContactPotentialSource { get; set; }

    [Column("ARCustomerContactSecondaryPhone")]
    [StringLength(255)]
    [Unicode(false)]
    public string ArcustomerContactSecondaryPhone { get; set; }

    [Column("AAStatus")]
    [StringLength(10)]
    [Unicode(false)]
    public string Aastatus { get; set; }

    [Column("ARCustomerContactTitle")]
    [StringLength(50)]
    public string ArcustomerContactTitle { get; set; }

    [Column("ARContactType")]
    [StringLength(100)]
    public string ArcontactType { get; set; }

    [Column("AAUpdatedDate", TypeName = "datetime")]
    public DateTime? AaupdatedDate { get; set; }

    [Column("AAUpdatedUser")]
    [StringLength(50)]
    public string AaupdatedUser { get; set; }

    [Column("UpdatedUserID")]
    public int? UpdatedUserId { get; set; }

    [Column("ARCustomerContactWebsite")]
    [StringLength(100)]
    public string ArcustomerContactWebsite { get; set; }

    [Column("FK_ARCustomerResourceID")]
    public int? FkArcustomerResourceId { get; set; }

    [Column("FK_ADUserGroupID")]
    public int? FkAduserGroupId { get; set; }

    [ForeignKey("Rev")]
    [InverseProperty("ArcustomerContactsHistories")]
    public virtual Revinfo RevNavigation { get; set; }
}
