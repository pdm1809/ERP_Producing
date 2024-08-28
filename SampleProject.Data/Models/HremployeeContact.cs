using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SampleProject.Data.Models;

[Table("HREmployeeContacts")]
public partial class HremployeeContact
{
    [Key]
    [Column("HREmployeeContactID")]
    public int HremployeeContactId { get; set; }

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

    [Column("FK_HREmployeeID")]
    public int? FkHremployeeId { get; set; }

    [Required]
    [Column("HREmployeeContactAddress")]
    [StringLength(512)]
    public string HremployeeContactAddress { get; set; }

    [Column("FK_GEDistrictID")]
    public int? FkGedistrictId { get; set; }

    [Column("FK_GEStateProvinceID")]
    public int? FkGestateProvinceId { get; set; }

    [Column("FK_GECountryID")]
    public int? FkGecountryId { get; set; }

    [Column("HREmployeeContactPostalCode")]
    [StringLength(50)]
    public string HremployeeContactPostalCode { get; set; }

    [Column("HREmployeeContactZipCode")]
    [StringLength(50)]
    public string HremployeeContactZipCode { get; set; }

    [Column("HREmployeeContactTypeCombo")]
    [StringLength(256)]
    public string HremployeeContactTypeCombo { get; set; }

    [Column("FK_GEWardID")]
    public int? FkGewardId { get; set; }

    [ForeignKey("FkGecountryId")]
    [InverseProperty("HremployeeContacts")]
    public virtual Gecountry FkGecountry { get; set; }

    [ForeignKey("FkGedistrictId")]
    [InverseProperty("HremployeeContacts")]
    public virtual Gedistrict FkGedistrict { get; set; }

    [ForeignKey("FkGestateProvinceId")]
    [InverseProperty("HremployeeContacts")]
    public virtual GestateProvince FkGestateProvince { get; set; }

    [ForeignKey("FkGewardId")]
    [InverseProperty("HremployeeContacts")]
    public virtual Geward FkGeward { get; set; }

    [ForeignKey("FkHremployeeId")]
    [InverseProperty("HremployeeContacts")]
    public virtual Hremployee FkHremployee { get; set; }
}
