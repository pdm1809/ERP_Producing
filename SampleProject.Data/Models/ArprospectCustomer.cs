using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SampleProject.Data.Models;

[Table("ARProspectCustomers")]
public partial class ArprospectCustomer
{
    [Key]
    [Column("ARProspectCustomerID")]
    public int ArprospectCustomerId { get; set; }

    [Column("ARProspectCustomerAddress")]
    [StringLength(200)]
    public string ArprospectCustomerAddress { get; set; }

    [Column("ARProspectCustomerAssign")]
    [StringLength(50)]
    public string ArprospectCustomerAssign { get; set; }

    [Column("ARProspectCustomerBusiness")]
    [StringLength(100)]
    public string ArprospectCustomerBusiness { get; set; }

    [Column("ARProspectCustomerCellPhone")]
    [StringLength(50)]
    [Unicode(false)]
    public string ArprospectCustomerCellPhone { get; set; }

    [Column("ARProspectCustomerAddressCity")]
    [StringLength(100)]
    public string ArprospectCustomerAddressCity { get; set; }

    [Column("ARProspectCustomerCompany")]
    [StringLength(200)]
    public string ArprospectCustomerCompany { get; set; }

    [Column("ARProspectCustomerAddressCountry")]
    [StringLength(100)]
    public string ArprospectCustomerAddressCountry { get; set; }

    [Column("AACreatedDate", TypeName = "datetime")]
    public DateTime? AacreatedDate { get; set; }

    [Column("AACreatedUser")]
    [StringLength(50)]
    public string AacreatedUser { get; set; }

    [Column("CreatedUserID")]
    public int? CreatedUserId { get; set; }

    [Column("ARProspectCustomerDescription")]
    [StringLength(2000)]
    public string ArprospectCustomerDescription { get; set; }

    [Column("ARProspectCustomerAddressDistrict")]
    [StringLength(100)]
    public string ArprospectCustomerAddressDistrict { get; set; }

    [Column("ARProspectCustomerEmail")]
    [StringLength(50)]
    [Unicode(false)]
    public string ArprospectCustomerEmail { get; set; }

    [Column("FK_HRGroupID")]
    public int? FkHrgroupId { get; set; }

    [Column("FK_HREmployeeID")]
    public int? FkHremployeeId { get; set; }

    [Column("ARProspectCustomerFirstName")]
    [StringLength(256)]
    public string ArprospectCustomerFirstName { get; set; }

    [Column("ARProspectCustomerLastName")]
    [StringLength(256)]
    public string ArprospectCustomerLastName { get; set; }

    [Required]
    [Column("ARProspectCustomerName")]
    [StringLength(50)]
    public string ArprospectCustomerName { get; set; }

    [Column("ARProspectCustomerTel")]
    [StringLength(50)]
    [Unicode(false)]
    public string ArprospectCustomerTel { get; set; }

    [Column("ARProspectCustomerPotentialSource")]
    [StringLength(200)]
    public string ArprospectCustomerPotentialSource { get; set; }

    [Column("ARProspectCustomerStatus")]
    [StringLength(50)]
    [Unicode(false)]
    public string ArprospectCustomerStatus { get; set; }

    [Column("ARProspectCustomerRate")]
    [StringLength(50)]
    public string ArprospectCustomerRate { get; set; }

    [Column("REV")]
    public int? Rev { get; set; }

    [Column("REVTYPE")]
    public int? Revtype { get; set; }

    [Column("ARPropectRevenueDueYear", TypeName = "decimal(18, 5)")]
    public decimal? ArpropectRevenueDueYear { get; set; }

    [Column("AAStatus")]
    [StringLength(10)]
    [Unicode(false)]
    public string Aastatus { get; set; }

    [Column("ARProspectCustomerTitle")]
    [StringLength(50)]
    public string ArprospectCustomerTitle { get; set; }

    [Column("AAUpdatedDate", TypeName = "datetime")]
    public DateTime? AaupdatedDate { get; set; }

    [Column("AAUpdatedUser")]
    [StringLength(50)]
    public string AaupdatedUser { get; set; }

    [Column("UpdatedUserID")]
    public int? UpdatedUserId { get; set; }

    [Column("ARProspectCustomerWebsite")]
    [StringLength(50)]
    [Unicode(false)]
    public string ArprospectCustomerWebsite { get; set; }

    [Column("FK_BRBranchID")]
    public int? FkBrbranchId { get; set; }

    [Column("FK_GELocationID")]
    public int? FkGelocationId { get; set; }

    [Column("ARProspectObjectType")]
    [StringLength(50)]
    public string ArprospectObjectType { get; set; }

    [Column("ARProspectObjectID")]
    public int? ArprospectObjectId { get; set; }

    [Column("ARProspectCustomerLunarBirthday")]
    [StringLength(50)]
    public string ArprospectCustomerLunarBirthday { get; set; }

    [Column("ARProspectCustomerGender")]
    [StringLength(50)]
    public string ArprospectCustomerGender { get; set; }

    [Column("ARProspectCustomerBirthday", TypeName = "datetime")]
    public DateTime? ArprospectCustomerBirthday { get; set; }

    [Column("FK_ARCustomerResourceID")]
    public int? FkArcustomerResourceId { get; set; }

    [Column("ARProspectCustomerCreatedDate", TypeName = "datetime")]
    public DateTime? ArprospectCustomerCreatedDate { get; set; }

    [Column("FK_ADUserGroupID")]
    public int? FkAduserGroupId { get; set; }

    [InverseProperty("FkArprospectCustomer")]
    public virtual ICollection<ArcustomerContact> ArcustomerContacts { get; set; } = new List<ArcustomerContact>();

    [InverseProperty("FkArprospectCustomer")]
    public virtual ICollection<Arcustomer> Arcustomers { get; set; } = new List<Arcustomer>();

    [ForeignKey("FkAduserGroupId")]
    [InverseProperty("ArprospectCustomers")]
    public virtual AduserGroup FkAduserGroup { get; set; }

    [ForeignKey("FkArcustomerResourceId")]
    [InverseProperty("ArprospectCustomers")]
    public virtual ArcustomerResource FkArcustomerResource { get; set; }

    [ForeignKey("FkBrbranchId")]
    [InverseProperty("ArprospectCustomers")]
    public virtual Brbranch FkBrbranch { get; set; }

    [ForeignKey("FkGelocationId")]
    [InverseProperty("ArprospectCustomers")]
    public virtual Gelocation FkGelocation { get; set; }

    [ForeignKey("FkHremployeeId")]
    [InverseProperty("ArprospectCustomers")]
    public virtual Hremployee FkHremployee { get; set; }

    [ForeignKey("FkHrgroupId")]
    [InverseProperty("ArprospectCustomers")]
    public virtual Hrgroup FkHrgroup { get; set; }

    [InverseProperty("FkArprospectCustomer")]
    public virtual ICollection<Pmproject> Pmprojects { get; set; } = new List<Pmproject>();
}
