using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SampleProject.Data.Models;

[Table("GEDistricts")]
public partial class Gedistrict
{
    [Key]
    [Column("GEDistrictID")]
    public int GedistrictId { get; set; }

    [Column("AAStatus")]
    [StringLength(50)]
    public string Aastatus { get; set; }

    [Column("FK_GEStateProvinceID")]
    public int? FkGestateProvinceId { get; set; }

    [Column("GEDistrictCode")]
    [StringLength(256)]
    public string GedistrictCode { get; set; }

    [Required]
    [Column("GEDistrictName")]
    [StringLength(512)]
    public string GedistrictName { get; set; }

    [InverseProperty("FkGedistrict")]
    public virtual ICollection<Apsupplier> Apsuppliers { get; set; } = new List<Apsupplier>();

    [InverseProperty("FkGedeliveryDistrict")]
    public virtual ICollection<Arcustomer> Arcustomers { get; set; } = new List<Arcustomer>();

    [InverseProperty("FkGedeliveryDistrict")]
    public virtual ICollection<ArdeliveryPlanItem> ArdeliveryPlanItems { get; set; } = new List<ArdeliveryPlanItem>();

    [InverseProperty("FkGedeliveryDistrict")]
    public virtual ICollection<ArdeliveryPlanMachineDevice> ArdeliveryPlanMachineDevices { get; set; } = new List<ArdeliveryPlanMachineDevice>();

    [InverseProperty("FkGedeliveryDistrict")]
    public virtual ICollection<ArdeliveryPlanTruckPoint> ArdeliveryPlanTruckPoints { get; set; } = new List<ArdeliveryPlanTruckPoint>();

    [ForeignKey("FkGestateProvinceId")]
    [InverseProperty("Gedistricts")]
    public virtual GestateProvince FkGestateProvince { get; set; }

    [InverseProperty("FkGedistrict")]
    public virtual ICollection<Geward> Gewards { get; set; } = new List<Geward>();

    [InverseProperty("FkGedistrict")]
    public virtual ICollection<Hrcandidate> Hrcandidates { get; set; } = new List<Hrcandidate>();

    [InverseProperty("FkGedistrict")]
    public virtual ICollection<HremployeeContactPerson> HremployeeContactPeople { get; set; } = new List<HremployeeContactPerson>();

    [InverseProperty("FkGedistrict")]
    public virtual ICollection<HremployeeContact> HremployeeContacts { get; set; } = new List<HremployeeContact>();

    [InverseProperty("FkGedistrict")]
    public virtual ICollection<HrsocialInsuranceDeclarationItem> HrsocialInsuranceDeclarationItems { get; set; } = new List<HrsocialInsuranceDeclarationItem>();

    [InverseProperty("FkGedistrict")]
    public virtual ICollection<PmprojectLocation> PmprojectLocations { get; set; } = new List<PmprojectLocation>();

    [InverseProperty("FkGedistrict")]
    public virtual ICollection<Pmproject> Pmprojects { get; set; } = new List<Pmproject>();
}
