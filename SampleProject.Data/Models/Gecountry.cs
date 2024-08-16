using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SampleProject.Data.Models;

[Table("GECountrys")]
public partial class Gecountry
{
    [Key]
    [Column("GECountryID")]
    public int GecountryId { get; set; }

    [Column("AAStatus")]
    [StringLength(50)]
    public string Aastatus { get; set; }

    [Required]
    [Column("GECountryCode")]
    [StringLength(50)]
    public string GecountryCode { get; set; }

    [Required]
    [Column("GECountryName")]
    [StringLength(512)]
    public string GecountryName { get; set; }

    [InverseProperty("FkGecountry")]
    public virtual ICollection<ApinvoiceInItem> ApinvoiceInItems { get; set; } = new List<ApinvoiceInItem>();

    [InverseProperty("FkGecountry")]
    public virtual ICollection<ApinvoiceIn> ApinvoiceIns { get; set; } = new List<ApinvoiceIn>();

    [InverseProperty("FkGecountry")]
    public virtual ICollection<AppurchaseOrderItem> AppurchaseOrderItems { get; set; } = new List<AppurchaseOrderItem>();

    [InverseProperty("FkGecountry")]
    public virtual ICollection<AppurchaseOrder> AppurchaseOrders { get; set; } = new List<AppurchaseOrder>();

    [InverseProperty("FkGecountry")]
    public virtual ICollection<Apsupplier> Apsuppliers { get; set; } = new List<Apsupplier>();

    [InverseProperty("FkGedeliveryCountry")]
    public virtual ICollection<Arcustomer> Arcustomers { get; set; } = new List<Arcustomer>();

    [InverseProperty("FkGecountry")]
    public virtual ICollection<ArinvoiceItem> ArinvoiceItems { get; set; } = new List<ArinvoiceItem>();

    [InverseProperty("FkGecountry")]
    public virtual ICollection<ArsaleOrderItem> ArsaleOrderItems { get; set; } = new List<ArsaleOrderItem>();

    [InverseProperty("FkGecountry")]
    public virtual ICollection<Geregion> Geregions { get; set; } = new List<Geregion>();

    [InverseProperty("FkGecountry")]
    public virtual ICollection<GestateProvince> GestateProvinces { get; set; } = new List<GestateProvince>();

    [InverseProperty("FkGecountry")]
    public virtual ICollection<Hrcandidate> Hrcandidates { get; set; } = new List<Hrcandidate>();

    [InverseProperty("FkGecountry")]
    public virtual ICollection<HremployeeContactPerson> HremployeeContactPeople { get; set; } = new List<HremployeeContactPerson>();

    [InverseProperty("FkGecountry")]
    public virtual ICollection<HremployeeContact> HremployeeContacts { get; set; } = new List<HremployeeContact>();

    [InverseProperty("FkGecountry")]
    public virtual ICollection<HrsocialInsuranceDeclarationItem> HrsocialInsuranceDeclarationItems { get; set; } = new List<HrsocialInsuranceDeclarationItem>();

    [InverseProperty("FkGecountry")]
    public virtual ICollection<IcproductSeries> IcproductSeries { get; set; } = new List<IcproductSeries>();

    [InverseProperty("FkGecountry")]
    public virtual ICollection<Icproduct> Icproducts { get; set; } = new List<Icproduct>();

    [InverseProperty("FkGecountry")]
    public virtual ICollection<IcreceiptCditem> IcreceiptCditems { get; set; } = new List<IcreceiptCditem>();

    [InverseProperty("FkGecountry")]
    public virtual ICollection<IcreceiptCd> IcreceiptCds { get; set; } = new List<IcreceiptCd>();

    [InverseProperty("FkGecountry")]
    public virtual ICollection<IcreceiptItem> IcreceiptItems { get; set; } = new List<IcreceiptItem>();

    [InverseProperty("FkGecountry")]
    public virtual ICollection<Icreceipt> Icreceipts { get; set; } = new List<Icreceipt>();

    [InverseProperty("FkGecountry")]
    public virtual ICollection<IcshipmentItem> IcshipmentItems { get; set; } = new List<IcshipmentItem>();

    [InverseProperty("FkGecountry")]
    public virtual ICollection<IcshipmentProposalItem> IcshipmentProposalItems { get; set; } = new List<IcshipmentProposalItem>();

    [InverseProperty("FkGecountry")]
    public virtual ICollection<Icshipment> Icshipments { get; set; } = new List<Icshipment>();

    [InverseProperty("FkGecountry")]
    public virtual ICollection<MmallocationProposalItem> MmallocationProposalItems { get; set; } = new List<MmallocationProposalItem>();

    [InverseProperty("FkGecountry")]
    public virtual ICollection<MmbatchProductItem> MmbatchProductItems { get; set; } = new List<MmbatchProductItem>();

    [InverseProperty("FkGecountry")]
    public virtual ICollection<MmcancelAllocationProposalItem> MmcancelAllocationProposalItems { get; set; } = new List<MmcancelAllocationProposalItem>();
}
