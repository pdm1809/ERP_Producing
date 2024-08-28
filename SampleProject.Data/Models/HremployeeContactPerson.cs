using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SampleProject.Data.Models;

[Table("HREmployeeContactPersons")]
public partial class HremployeeContactPerson
{
    [Key]
    [Column("HREmployeeContactPersonID")]
    public int HremployeeContactPersonId { get; set; }

    [Column("AACreatedDate", TypeName = "datetime")]
    public DateTime? AacreatedDate { get; set; }

    [Column("AACreatedUser")]
    [StringLength(512)]
    public string AacreatedUser { get; set; }

    [Column("AAUpdatedDate", TypeName = "datetime")]
    public DateTime? AaupdatedDate { get; set; }

    [Column("AAUpdatedUser")]
    [StringLength(512)]
    public string AaupdatedUser { get; set; }

    [Column("AAStatus")]
    [StringLength(50)]
    public string Aastatus { get; set; }

    [Required]
    [Column("HREmployeeContactPersonName")]
    [StringLength(100)]
    public string HremployeeContactPersonName { get; set; }

    [Column("FK_HREmployeeID")]
    public int FkHremployeeId { get; set; }

    [Column("HREmployeeContactPersonBirthday", TypeName = "datetime")]
    public DateTime? HremployeeContactPersonBirthday { get; set; }

    [Column("HREmployeeContactPersonFirstName")]
    [StringLength(50)]
    public string HremployeeContactPersonFirstName { get; set; }

    [Column("HREmployeeContactPersonLastName")]
    [StringLength(50)]
    public string HremployeeContactPersonLastName { get; set; }

    [Column("HREmployeeContactPersonGenderCombo")]
    [StringLength(50)]
    public string HremployeeContactPersonGenderCombo { get; set; }

    [Column("HREmployeeContactPersonRelationshipCombo")]
    [StringLength(100)]
    public string HremployeeContactPersonRelationshipCombo { get; set; }

    [Column("HREmployeeContactPersonEmail")]
    [StringLength(100)]
    public string HremployeeContactPersonEmail { get; set; }

    [Column("HREmployeeContactPersonWebsite")]
    [StringLength(100)]
    public string HremployeeContactPersonWebsite { get; set; }

    [Column("HREmployeeContactPersonPhone")]
    [StringLength(50)]
    [Unicode(false)]
    public string HremployeeContactPersonPhone { get; set; }

    [Column("HREmployeeContactPersonCellPhone")]
    [StringLength(50)]
    [Unicode(false)]
    public string HremployeeContactPersonCellPhone { get; set; }

    [Column("HREmployeeContactPersonFax")]
    [StringLength(50)]
    public string HremployeeContactPersonFax { get; set; }

    [Column("HREmployeeContactPersonAddressStreet")]
    [StringLength(200)]
    public string HremployeeContactPersonAddressStreet { get; set; }

    [Column("FK_GEDistrictID")]
    public int? FkGedistrictId { get; set; }

    [Column("FK_GEStateProvinceID")]
    public int? FkGestateProvinceId { get; set; }

    [Column("FK_GECountryID")]
    public int? FkGecountryId { get; set; }

    [Column("HREmployeeContactPersonAddressPostalCode")]
    [StringLength(50)]
    public string HremployeeContactPersonAddressPostalCode { get; set; }

    [Column("HREmployeeContactPersonAddressZipCode")]
    [StringLength(50)]
    public string HremployeeContactPersonAddressZipCode { get; set; }

    [Column("FK_HRRelationshipID")]
    public int? FkHrrelationshipId { get; set; }

    [Column("HREmployeeContactPersonTaxNumber")]
    [StringLength(50)]
    public string HremployeeContactPersonTaxNumber { get; set; }

    [Column("HREmployeeContactPersonDependency")]
    public bool? HremployeeContactPersonDependency { get; set; }

    [Column("HREmployeeContactPersonStartApplyDate", TypeName = "datetime")]
    public DateTime? HremployeeContactPersonStartApplyDate { get; set; }

    [Column("HREmployeeContactPersonEndApplyDate", TypeName = "datetime")]
    public DateTime? HremployeeContactPersonEndApplyDate { get; set; }

    [ForeignKey("FkGecountryId")]
    [InverseProperty("HremployeeContactPeople")]
    public virtual Gecountry FkGecountry { get; set; }

    [ForeignKey("FkGedistrictId")]
    [InverseProperty("HremployeeContactPeople")]
    public virtual Gedistrict FkGedistrict { get; set; }

    [ForeignKey("FkGestateProvinceId")]
    [InverseProperty("HremployeeContactPeople")]
    public virtual GestateProvince FkGestateProvince { get; set; }

    [ForeignKey("FkHremployeeId")]
    [InverseProperty("HremployeeContactPeople")]
    public virtual Hremployee FkHremployee { get; set; }

    [ForeignKey("FkHrrelationshipId")]
    [InverseProperty("HremployeeContactPeople")]
    public virtual Hrrelationship FkHrrelationship { get; set; }

    [InverseProperty("FkHremployeeContactPerson")]
    public virtual ICollection<HrregisterDormitoryItem> HrregisterDormitoryItems { get; set; } = new List<HrregisterDormitoryItem>();
}
