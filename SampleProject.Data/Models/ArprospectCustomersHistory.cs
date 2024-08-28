using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SampleProject.Data.Models;

[PrimaryKey("ArprospectCustomerId", "Rev")]
[Table("ARProspectCustomers_HISTORYS", Schema = "CRM_VINMUS_AUDIT")]
public partial class ArprospectCustomersHistory
{
    [Key]
    [Column("ARProspectCustomerID")]
    public int ArprospectCustomerId { get; set; }

    [Key]
    [Column("REV")]
    public int Rev { get; set; }

    [Column("REVTYPE")]
    public short? Revtype { get; set; }

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
    [StringLength(200)]
    public string ArprospectCustomerFirstName { get; set; }

    [Column("ARProspectCustomerLastName")]
    [StringLength(200)]
    public string ArprospectCustomerLastName { get; set; }

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

    [Column("ARProspectObjectType")]
    [StringLength(50)]
    public string ArprospectObjectType { get; set; }

    [Column("ARProspectObjectID")]
    public int? ArprospectObjectId { get; set; }

    [Column("FK_ARCustomerResourceID")]
    public int? FkArcustomerResourceId { get; set; }

    [Column("ARProspectCustomerCreatedDate", TypeName = "datetime")]
    public DateTime? ArprospectCustomerCreatedDate { get; set; }

    [Column("FK_ADUserGroupID")]
    public int? FkAduserGroupId { get; set; }

    [ForeignKey("Rev")]
    [InverseProperty("ArprospectCustomersHistories")]
    public virtual Revinfo RevNavigation { get; set; }
}
