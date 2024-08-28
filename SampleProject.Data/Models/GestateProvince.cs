using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SampleProject.Data.Models;

[Table("GEStateProvinces")]
public partial class GestateProvince
{
    [Key]
    [Column("GEStateProvinceID")]
    public int GestateProvinceId { get; set; }

    [Column("AAStatus")]
    [StringLength(50)]
    public string Aastatus { get; set; }

    [Column("FK_GECountryID")]
    public int? FkGecountryId { get; set; }

    [Column("GEStateProvinceCode")]
    [StringLength(50)]
    public string GestateProvinceCode { get; set; }

    [Required]
    [Column("GEStateProvinceName")]
    [StringLength(512)]
    public string GestateProvinceName { get; set; }

    [Column("FK_GERegionID")]
    public int? FkGeregionId { get; set; }

    [InverseProperty("FkAclistAccountBankBranchCity")]
    public virtual ICollection<AclistAccountBank> AclistAccountBanks { get; set; } = new List<AclistAccountBank>();

    [InverseProperty("FkGestateProvince")]
    public virtual ICollection<Apsupplier> Apsuppliers { get; set; } = new List<Apsupplier>();

    [InverseProperty("FkGedeliveryStateProvince")]
    public virtual ICollection<Arcustomer> Arcustomers { get; set; } = new List<Arcustomer>();

    [InverseProperty("FkGedeliveryStateProvince")]
    public virtual ICollection<ArdeliveryPlanItem> ArdeliveryPlanItems { get; set; } = new List<ArdeliveryPlanItem>();

    [InverseProperty("FkGedeliveryStateProvince")]
    public virtual ICollection<ArdeliveryPlanMachineDevice> ArdeliveryPlanMachineDevices { get; set; } = new List<ArdeliveryPlanMachineDevice>();

    [InverseProperty("FkGedeliveryStateProvince")]
    public virtual ICollection<ArdeliveryPlanTruckPoint> ArdeliveryPlanTruckPoints { get; set; } = new List<ArdeliveryPlanTruckPoint>();

    [ForeignKey("FkGecountryId")]
    [InverseProperty("GestateProvinces")]
    public virtual Gecountry FkGecountry { get; set; }

    [ForeignKey("FkGeregionId")]
    [InverseProperty("GestateProvinces")]
    public virtual Geregion FkGeregion { get; set; }

    [InverseProperty("FkGestateProvince")]
    public virtual ICollection<Gedistrict> Gedistricts { get; set; } = new List<Gedistrict>();

    [InverseProperty("FkGeidcardStateProvince")]
    public virtual ICollection<Hrcandidate> HrcandidateFkGeidcardStateProvinces { get; set; } = new List<Hrcandidate>();

    [InverseProperty("FkGestateProvince")]
    public virtual ICollection<Hrcandidate> HrcandidateFkGestateProvinces { get; set; } = new List<Hrcandidate>();

    [InverseProperty("FkGestateProvince")]
    public virtual ICollection<HremployeeContactPerson> HremployeeContactPeople { get; set; } = new List<HremployeeContactPerson>();

    [InverseProperty("FkGestateProvince")]
    public virtual ICollection<HremployeeContact> HremployeeContacts { get; set; } = new List<HremployeeContact>();

    [InverseProperty("FkGeidcardStateProvince")]
    public virtual ICollection<Hremployee> HremployeeFkGeidcardStateProvinces { get; set; } = new List<Hremployee>();

    [InverseProperty("FkGenativeStateProvince")]
    public virtual ICollection<Hremployee> HremployeeFkGenativeStateProvinces { get; set; } = new List<Hremployee>();

    [InverseProperty("FkGestateProvinceBirthPlace")]
    public virtual ICollection<Hremployee> HremployeeFkGestateProvinceBirthPlaces { get; set; } = new List<Hremployee>();

    [InverseProperty("FkGestateProvinceIdbhxhNavigation")]
    public virtual ICollection<Hremployee> HremployeeFkGestateProvinceIdbhxhNavigations { get; set; } = new List<Hremployee>();

    [InverseProperty("FkGeidcardStateProvinceId2Navigation")]
    public virtual ICollection<HrsocialInsuranceDeclarationItem> HrsocialInsuranceDeclarationItemFkGeidcardStateProvinceId2Navigations { get; set; } = new List<HrsocialInsuranceDeclarationItem>();

    [InverseProperty("FkGeidcardStateProvince")]
    public virtual ICollection<HrsocialInsuranceDeclarationItem> HrsocialInsuranceDeclarationItemFkGeidcardStateProvinces { get; set; } = new List<HrsocialInsuranceDeclarationItem>();

    [InverseProperty("FkGestateProvince")]
    public virtual ICollection<HrworkingFeeConfig> HrworkingFeeConfigs { get; set; } = new List<HrworkingFeeConfig>();

    [InverseProperty("FkGestateProvince")]
    public virtual ICollection<PmprojectLocation> PmprojectLocations { get; set; } = new List<PmprojectLocation>();

    [InverseProperty("FkGestateProvince")]
    public virtual ICollection<Pmproject> Pmprojects { get; set; } = new List<Pmproject>();
}
