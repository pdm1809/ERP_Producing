using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SampleProject.Data.Models;

[Table("PMProjectContacts")]
public partial class PmprojectContact
{
    [Key]
    [Column("PMProjectContactID")]
    public int PmprojectContactId { get; set; }

    [Column("AAStatus")]
    [StringLength(50)]
    [Unicode(false)]
    public string Aastatus { get; set; }

    [Column("AACreatedUser")]
    [StringLength(50)]
    public string AacreatedUser { get; set; }

    [Column("AACreatedDate", TypeName = "datetime")]
    public DateTime? AacreatedDate { get; set; }

    [Column("AAUpdatedUser")]
    [StringLength(50)]
    public string AaupdatedUser { get; set; }

    [Column("AAUpdatedDate", TypeName = "datetime")]
    public DateTime? AaupdatedDate { get; set; }

    [Column("FK_PMProjectID")]
    public int? FkPmprojectId { get; set; }

    [Column("FK_GELocationID")]
    public int? FkGelocationId { get; set; }

    [Column("PMProjectContactNo")]
    [StringLength(50)]
    public string PmprojectContactNo { get; set; }

    [Column("PMProjectContactName")]
    [StringLength(250)]
    public string PmprojectContactName { get; set; }

    [Column("PMProjectContactDesc")]
    [StringLength(512)]
    public string PmprojectContactDesc { get; set; }

    [Column("PMProjectContactDOB", TypeName = "datetime")]
    public DateTime? PmprojectContactDob { get; set; }

    [Column("PMProjectContactEmail")]
    [StringLength(100)]
    public string PmprojectContactEmail { get; set; }

    [Column("PMProjectContactPhone")]
    [StringLength(50)]
    public string PmprojectContactPhone { get; set; }

    [Column("PMProjectContactFax")]
    [StringLength(50)]
    public string PmprojectContactFax { get; set; }

    [Column("PMProjectContactAddress")]
    [StringLength(250)]
    public string PmprojectContactAddress { get; set; }

    [Column("PMProjectContactComment")]
    [StringLength(512)]
    public string PmprojectContactComment { get; set; }

    [Column("PMProjectContactDefaultAddress")]
    public bool? PmprojectContactDefaultAddress { get; set; }

    [Column("PMProjectContactTransactionContactInfo")]
    public bool? PmprojectContactTransactionContactInfo { get; set; }

    [Column("PMProjectContactTaxCode")]
    [StringLength(50)]
    public string PmprojectContactTaxCode { get; set; }

    [ForeignKey("FkGelocationId")]
    [InverseProperty("PmprojectContacts")]
    public virtual Gelocation FkGelocation { get; set; }

    [ForeignKey("FkPmprojectId")]
    [InverseProperty("PmprojectContacts")]
    public virtual Pmproject FkPmproject { get; set; }
}
