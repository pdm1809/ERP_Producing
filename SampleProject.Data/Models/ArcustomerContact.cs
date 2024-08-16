using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SampleProject.Data.Models;

[Table("ARCustomerContacts")]
[Microsoft.EntityFrameworkCore.Index("FkArcustomerId", Name = "Idx_ARCustomerContacts")]
public partial class ArcustomerContact
{
    [Key]
    [Column("ARCustomerContactID")]
    public int ArcustomerContactId { get; set; }

    [Column("AAStatus")]
    [StringLength(50)]
    [Unicode(false)]
    public string Aastatus { get; set; }

    [Required]
    [Column("ARCustomerContactName")]
    [StringLength(100)]
    public string ArcustomerContactName { get; set; }

    [Column("FK_ARCustomerID")]
    public int FkArcustomerId { get; set; }

    [Column("ARCustomerContactBirthday", TypeName = "datetime")]
    public DateTime? ArcustomerContactBirthday { get; set; }

    [Column("ARCustomerContactFirstName")]
    [StringLength(50)]
    public string ArcustomerContactFirstName { get; set; }

    [Column("ARCustomerContactLastName")]
    [StringLength(50)]
    public string ArcustomerContactLastName { get; set; }

    [Column("ARCustomerContactTitle")]
    [StringLength(50)]
    public string ArcustomerContactTitle { get; set; }

    /// <summary>
    /// fuer Umschlag: zB. Z.Hand Herrn Meyer
    /// </summary>
    [Column("ARCustomerContactHeaderLetter")]
    [StringLength(100)]
    public string ArcustomerContactHeaderLetter { get; set; }

    /// <summary>
    /// Anrede fuer Briefe
    /// </summary>
    [Column("ARCustomerContactHeaderMessage")]
    [StringLength(255)]
    public string ArcustomerContactHeaderMessage { get; set; }

    [Column("ARCustomerContactEmail1")]
    [StringLength(100)]
    public string ArcustomerContactEmail1 { get; set; }

    [Column("ARCustomerContactEmail2")]
    [StringLength(100)]
    public string ArcustomerContactEmail2 { get; set; }

    [Column("ARCustomerContactWebsite")]
    [StringLength(100)]
    public string ArcustomerContactWebsite { get; set; }

    [Column("ARCustomerContactPhonePrivate")]
    [StringLength(50)]
    [Unicode(false)]
    public string ArcustomerContactPhonePrivate { get; set; }

    [Column("ARCustomerContactPhone")]
    [StringLength(50)]
    [Unicode(false)]
    public string ArcustomerContactPhone { get; set; }

    [Column("ARCustomerContactPhone1")]
    [StringLength(50)]
    [Unicode(false)]
    public string ArcustomerContactPhone1 { get; set; }

    [Column("ARCustomerContactCellPhone1")]
    [StringLength(50)]
    [Unicode(false)]
    public string ArcustomerContactCellPhone1 { get; set; }

    [Column("ARCustomerContactCellPhone")]
    [StringLength(50)]
    [Unicode(false)]
    public string ArcustomerContactCellPhone { get; set; }

    [Column("ARCustomerContactCellPhonePrivate")]
    [StringLength(50)]
    [Unicode(false)]
    public string ArcustomerContactCellPhonePrivate { get; set; }

    [Column("ARCustomerContactFax")]
    [StringLength(50)]
    public string ArcustomerContactFax { get; set; }

    [Column("ARContactType")]
    [StringLength(100)]
    public string ArcontactType { get; set; }

    [Column("ARCustomerContactTypeDisplay")]
    [StringLength(100)]
    public string ArcustomerContactTypeDisplay { get; set; }

    [Column("ARCustomerContactInformation")]
    [StringLength(2000)]
    public string ArcustomerContactInformation { get; set; }

    [Column("ARCustomerContactDepartment")]
    [StringLength(50)]
    public string ArcustomerContactDepartment { get; set; }

    [Column("ARCustomerContactRoom")]
    [StringLength(30)]
    [Unicode(false)]
    public string ArcustomerContactRoom { get; set; }

    [Column("ARCustomerContactAddressLine1")]
    [StringLength(200)]
    public string ArcustomerContactAddressLine1 { get; set; }

    [Column("ARCustomerContactAddressLine2")]
    [StringLength(200)]
    public string ArcustomerContactAddressLine2 { get; set; }

    [Column("ARCustomerContactAddressLine3")]
    [StringLength(200)]
    public string ArcustomerContactAddressLine3 { get; set; }

    [Column("ARCustomerContactAddressStreet")]
    [StringLength(200)]
    public string ArcustomerContactAddressStreet { get; set; }

    [Column("ARCustomerContactAddressCity")]
    [StringLength(50)]
    public string ArcustomerContactAddressCity { get; set; }

    [Column("ARCustomerContactAddressPostalCode")]
    [StringLength(50)]
    public string ArcustomerContactAddressPostalCode { get; set; }

    [Column("ARCustomerContactAddressStateProvince")]
    [StringLength(50)]
    public string ArcustomerContactAddressStateProvince { get; set; }

    [Column("ARCustomerContactAddressZipCode")]
    [StringLength(50)]
    public string ArcustomerContactAddressZipCode { get; set; }

    [Column("ARCustomerContactAddressCountry")]
    [StringLength(50)]
    public string ArcustomerContactAddressCountry { get; set; }

    [Column("ARCustomerContactTaxCode")]
    [StringLength(50)]
    [Unicode(false)]
    public string ArcustomerContactTaxCode { get; set; }

    [Column("ARCustomerContactDefaultAddress")]
    public bool? ArcustomerContactDefaultAddress { get; set; }

    [Column("ARCustomerContactComment")]
    [StringLength(512)]
    public string ArcustomerContactComment { get; set; }

    [Column("ARCustomerContactTransactionContactInfo")]
    public bool? ArcustomerContactTransactionContactInfo { get; set; }

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

    [Column("ARCustomerContactCellularPhone")]
    [StringLength(255)]
    [Unicode(false)]
    public string ArcustomerContactCellularPhone { get; set; }

    [Column("ARCustomerContactAddressCity2")]
    [StringLength(50)]
    public string ArcustomerContactAddressCity2 { get; set; }

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

    [Column("ARCustomerContactAddressDistrict")]
    [StringLength(50)]
    public string ArcustomerContactAddressDistrict { get; set; }

    [Column("ARCustomerContactAddressDistrict2")]
    [StringLength(50)]
    public string ArcustomerContactAddressDistrict2 { get; set; }

    [Column("FK_HRGroupID")]
    public int? FkHrgroupId { get; set; }

    [Column("FK_HREmployeeID")]
    public int? FkHremployeeId { get; set; }

    [Column("ARCustomerContactHomePhone")]
    [StringLength(255)]
    [Unicode(false)]
    public string ArcustomerContactHomePhone { get; set; }

    [Column("ARCustomerContactImage")]
    public byte[] ArcustomerContactImage { get; set; }

    [Column("ARCustomerContactJobTitle")]
    [StringLength(100)]
    public string ArcustomerContactJobTitle { get; set; }

    [Column("ARCustomerContactPotentialSource")]
    [StringLength(100)]
    public string ArcustomerContactPotentialSource { get; set; }

    [Column("REV")]
    public long? Rev { get; set; }

    [Column("REVTYPE")]
    public long? Revtype { get; set; }

    [Column("ARCustomerContactSecondaryPhone")]
    [StringLength(255)]
    [Unicode(false)]
    public string ArcustomerContactSecondaryPhone { get; set; }

    [Column("AAUpdatedDate", TypeName = "datetime")]
    public DateTime? AaupdatedDate { get; set; }

    [Column("AAUpdatedUser")]
    [StringLength(50)]
    public string AaupdatedUser { get; set; }

    [Column("UpdatedUserID")]
    public int? UpdatedUserId { get; set; }

    [Column("FK_BRBranchID")]
    public int? FkBrbranchId { get; set; }

    [Column("FK_GELocationID")]
    public int? FkGelocationId { get; set; }

    [Column("FK_ARProspectCustomerID")]
    public int? FkArprospectCustomerId { get; set; }

    [Column("FK_ARCustomerResourceID")]
    public int? FkArcustomerResourceId { get; set; }

    [Column("FK_ADUserGroupID")]
    public int? FkAduserGroupId { get; set; }

    [InverseProperty("FkArcustomerContact")]
    public virtual ICollection<ArcustomerContactGroup> ArcustomerContactGroups { get; set; } = new List<ArcustomerContactGroup>();

    [InverseProperty("FkArcustomerContact")]
    public virtual ICollection<AropportunityContactGroup> AropportunityContactGroups { get; set; } = new List<AropportunityContactGroup>();

    [InverseProperty("FkArcustomerContact")]
    public virtual ICollection<AropportunityContact> AropportunityContacts { get; set; } = new List<AropportunityContact>();

    [InverseProperty("FkArcustomerContactDelivery")]
    public virtual ICollection<ArsaleForecast> ArsaleForecastFkArcustomerContactDeliveries { get; set; } = new List<ArsaleForecast>();

    [InverseProperty("FkArcustomerContactPayment")]
    public virtual ICollection<ArsaleForecast> ArsaleForecastFkArcustomerContactPayments { get; set; } = new List<ArsaleForecast>();

    [InverseProperty("FkArcustomerContactSf")]
    public virtual ICollection<ArsaleForecast> ArsaleForecastFkArcustomerContactSfs { get; set; } = new List<ArsaleForecast>();

    [InverseProperty("FkArcustomerContactDelivery")]
    public virtual ICollection<ArsaleOrder> ArsaleOrderFkArcustomerContactDeliveries { get; set; } = new List<ArsaleOrder>();

    [InverseProperty("FkArcustomerContactPayment")]
    public virtual ICollection<ArsaleOrder> ArsaleOrderFkArcustomerContactPayments { get; set; } = new List<ArsaleOrder>();

    [InverseProperty("FkArcustomerContactSo")]
    public virtual ICollection<ArsaleOrder> ArsaleOrderFkArcustomerContactSos { get; set; } = new List<ArsaleOrder>();

    [ForeignKey("FkAduserGroupId")]
    [InverseProperty("ArcustomerContacts")]
    public virtual AduserGroup FkAduserGroup { get; set; }

    [ForeignKey("FkArcustomerId")]
    [InverseProperty("ArcustomerContacts")]
    public virtual Arcustomer FkArcustomer { get; set; }

    [ForeignKey("FkArcustomerResourceId")]
    [InverseProperty("ArcustomerContacts")]
    public virtual ArcustomerResource FkArcustomerResource { get; set; }

    [ForeignKey("FkArprospectCustomerId")]
    [InverseProperty("ArcustomerContacts")]
    public virtual ArprospectCustomer FkArprospectCustomer { get; set; }

    [ForeignKey("FkBrbranchId")]
    [InverseProperty("ArcustomerContacts")]
    public virtual Brbranch FkBrbranch { get; set; }

    [ForeignKey("FkGelocationId")]
    [InverseProperty("ArcustomerContacts")]
    public virtual Gelocation FkGelocation { get; set; }

    [ForeignKey("FkHremployeeId")]
    [InverseProperty("ArcustomerContacts")]
    public virtual Hremployee FkHremployee { get; set; }

    [ForeignKey("FkHrgroupId")]
    [InverseProperty("ArcustomerContacts")]
    public virtual Hrgroup FkHrgroup { get; set; }
}
