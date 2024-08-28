using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SampleProject.Data.Models;

[PrimaryKey("ArcustomerId", "Rev")]
[Table("ARCustomers_HISTORYS", Schema = "CRM_VINMUS_AUDIT")]
public partial class ArcustomersHistory
{
    [Key]
    [Column("ARCustomerID")]
    public int ArcustomerId { get; set; }

    [Key]
    [Column("REV")]
    public int Rev { get; set; }

    [Column("REVTYPE")]
    public short? Revtype { get; set; }

    [Column("ARCustomerContactAddressLine1")]
    [StringLength(2000)]
    public string ArcustomerContactAddressLine1 { get; set; }

    [Column("ARCustomerAssignedTo")]
    [StringLength(2000)]
    public string ArcustomerAssignedTo { get; set; }

    [Column("ARCustomerBonusScore")]
    public long? ArcustomerBonusScore { get; set; }

    [Column("ARCustomerBusiness")]
    [StringLength(2000)]
    public string ArcustomerBusiness { get; set; }

    [Column("ARCustomerChangedUser")]
    [StringLength(50)]
    public string ArcustomerChangedUser { get; set; }

    [Column("ARCustomerActiveCheck")]
    public bool? ArcustomerActiveCheck { get; set; }

    [Column("ARCustomerContactAddressCity")]
    [StringLength(2000)]
    public string ArcustomerContactAddressCity { get; set; }

    [Column("ARCustomerClassify")]
    [StringLength(2000)]
    public string ArcustomerClassify { get; set; }

    [Column("ARCustomerCompanyEstablishmentDay", TypeName = "datetime")]
    public DateTime? ArcustomerCompanyEstablishmentDay { get; set; }

    [Column("ARCustomerContactPhone1")]
    [StringLength(50)]
    [Unicode(false)]
    public string ArcustomerContactPhone1 { get; set; }

    [Column("ARCustomerContactAddressCountry")]
    [StringLength(2000)]
    public string ArcustomerContactAddressCountry { get; set; }

    [Column("AACreatedDate", TypeName = "datetime")]
    public DateTime? AacreatedDate { get; set; }

    [Column("AACreatedUser")]
    [StringLength(50)]
    public string AacreatedUser { get; set; }

    [Column("CreatedUserID")]
    public int? CreatedUserId { get; set; }

    [Column("ARCustomerNo")]
    [StringLength(50)]
    public string ArcustomerNo { get; set; }

    [Column("ARCustomerTypeCombo")]
    [StringLength(50)]
    public string ArcustomerTypeCombo { get; set; }

    [Column("ARCustomerContactAddressDistrict")]
    [StringLength(2000)]
    public string ArcustomerContactAddressDistrict { get; set; }

    [Column("ARCustomerContactBirthday", TypeName = "datetime")]
    public DateTime? ArcustomerContactBirthday { get; set; }

    [Column("ARCustomerContactEmail1")]
    [StringLength(1000)]
    public string ArcustomerContactEmail1 { get; set; }

    [Column("ARCustomerContactEmail2")]
    [StringLength(2000)]
    public string ArcustomerContactEmail2 { get; set; }

    [Column("FK_HRGroupID")]
    public int? FkHrgroupId { get; set; }

    [Column("FK_HREmployeeID")]
    public int? FkHremployeeId { get; set; }

    [Column("ARCustomerEvaluate")]
    public long? ArcustomerEvaluate { get; set; }

    [Column("ARCustomerContactFax")]
    [StringLength(50)]
    public string ArcustomerContactFax { get; set; }

    [Column("ARGender")]
    [StringLength(255)]
    [Unicode(false)]
    public string Argender { get; set; }

    [Column("ARCustomerGroup")]
    [StringLength(500)]
    public string ArcustomerGroup { get; set; }

    [Column("ARCustomerContactInformation")]
    [StringLength(4000)]
    public string ArcustomerContactInformation { get; set; }

    [Column("ARCustomerName")]
    [StringLength(4000)]
    public string ArcustomerName { get; set; }

    [Column("ARCustomerContactCellPhone1")]
    [StringLength(50)]
    public string ArcustomerContactCellPhone1 { get; set; }

    [Column("ARCustomerContactName")]
    [StringLength(2000)]
    public string ArcustomerContactName { get; set; }

    [Column("ARCustomerRevenueDueYear", TypeName = "decimal(18, 5)")]
    public decimal? ArcustomerRevenueDueYear { get; set; }

    [Column("AAStatus")]
    [StringLength(10)]
    [Unicode(false)]
    public string Aastatus { get; set; }

    [Column("ARCustomerStockCode")]
    [StringLength(500)]
    [Unicode(false)]
    public string ArcustomerStockCode { get; set; }

    [Column("ARCustomerTaxNumber")]
    [StringLength(50)]
    [Unicode(false)]
    public string ArcustomerTaxNumber { get; set; }

    [Column("ARCustomerContactPhone")]
    [StringLength(50)]
    public string ArcustomerContactPhone { get; set; }

    [Column("ARCustomerContactCellPhone")]
    [StringLength(50)]
    public string ArcustomerContactCellPhone { get; set; }

    [Column("AAUpdatedDate", TypeName = "datetime")]
    public DateTime? AaupdatedDate { get; set; }

    [Column("AAUpdatedUser")]
    [StringLength(50)]
    public string AaupdatedUser { get; set; }

    [Column("UpdatedUserID")]
    public int? UpdatedUserId { get; set; }

    [Column("ARCustomerWebsite")]
    [StringLength(2000)]
    public string ArcustomerWebsite { get; set; }

    [Column("ARCustomerCRMType")]
    [StringLength(50)]
    public string ArcustomerCrmtype { get; set; }

    [Column("FK_ADUserGroupID")]
    public int? FkAduserGroupId { get; set; }

    [Column("ARCustomerSex")]
    [StringLength(256)]
    public string ArcustomerSex { get; set; }

    [ForeignKey("Rev")]
    [InverseProperty("ArcustomersHistories")]
    public virtual Revinfo RevNavigation { get; set; }
}
