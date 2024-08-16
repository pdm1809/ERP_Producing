using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SampleProject.Data.Models;

[Table("HRRegisterDormitoryItems")]
public partial class HrregisterDormitoryItem
{
    [Key]
    [Column("HRRegisterDormitoryItemID")]
    public int HrregisterDormitoryItemId { get; set; }

    [Column("AACreatedDate", TypeName = "datetime")]
    public DateTime? AacreatedDate { get; set; }

    [Column("AACreatedUser")]
    [StringLength(50)]
    public string AacreatedUser { get; set; }

    [Column("AAUpdatedDate", TypeName = "datetime")]
    public DateTime? AaupdatedDate { get; set; }

    [Column("AAUpdatedUser")]
    [StringLength(50)]
    public string AaupdatedUser { get; set; }

    [Column("AAStatus")]
    [StringLength(10)]
    [Unicode(false)]
    public string Aastatus { get; set; }

    [Column("FK_HRRegisterDormitoryID")]
    public int? FkHrregisterDormitoryId { get; set; }

    [Column("FK_HREmployeeID")]
    public int? FkHremployeeId { get; set; }

    [Column("HRRegisterDormitoryItemEmployeeName")]
    [StringLength(50)]
    public string HrregisterDormitoryItemEmployeeName { get; set; }

    [Column("HRRegisterDormitoryItemEmployeeTypeCombo")]
    [StringLength(50)]
    public string HrregisterDormitoryItemEmployeeTypeCombo { get; set; }

    [Column("HRRegisterDormitoryItemEmployeeLevelID")]
    public int? HrregisterDormitoryItemEmployeeLevelId { get; set; }

    [Column("HRRegisterDormitoryItemGenderCombo")]
    [StringLength(50)]
    public string HrregisterDormitoryItemGenderCombo { get; set; }

    [Column("HRRegisterDormitoryItemBirthday", TypeName = "datetime")]
    public DateTime? HrregisterDormitoryItemBirthday { get; set; }

    [Column("HRRegisterDormitoryItemPhone")]
    [StringLength(50)]
    public string HrregisterDormitoryItemPhone { get; set; }

    [Column("HRRegisterDormitoryItemAddressStreet")]
    [StringLength(200)]
    public string HrregisterDormitoryItemAddressStreet { get; set; }

    [Column("HRRegisterDormitoryItemPersonName")]
    [StringLength(50)]
    public string HrregisterDormitoryItemPersonName { get; set; }

    [Column("HRRegisterDormitoryItemFromDate", TypeName = "datetime")]
    public DateTime? HrregisterDormitoryItemFromDate { get; set; }

    [Column("HRRegisterDormitoryItemToDate", TypeName = "datetime")]
    public DateTime? HrregisterDormitoryItemToDate { get; set; }

    [Column("FK_HREmployeeContactPersonID")]
    public int? FkHremployeeContactPersonId { get; set; }

    [Column("FK_HRRelationshipID")]
    public int? FkHrrelationshipId { get; set; }

    [ForeignKey("FkHremployeeId")]
    [InverseProperty("HrregisterDormitoryItems")]
    public virtual Hremployee FkHremployee { get; set; }

    [ForeignKey("FkHremployeeContactPersonId")]
    [InverseProperty("HrregisterDormitoryItems")]
    public virtual HremployeeContactPerson FkHremployeeContactPerson { get; set; }

    [ForeignKey("FkHrregisterDormitoryId")]
    [InverseProperty("HrregisterDormitoryItems")]
    public virtual HrregisterDormitory FkHrregisterDormitory { get; set; }

    [ForeignKey("FkHrrelationshipId")]
    [InverseProperty("HrregisterDormitoryItems")]
    public virtual Hrrelationship FkHrrelationship { get; set; }
}
