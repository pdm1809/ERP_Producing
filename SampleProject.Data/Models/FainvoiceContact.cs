using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SampleProject.Data.Models;

[Table("FAInvoiceContacts")]
public partial class FainvoiceContact
{
    [Key]
    [Column("FAInvoiceContactID")]
    public int FainvoiceContactId { get; set; }

    [Column("AANumberString")]
    [StringLength(50)]
    [Unicode(false)]
    public string AanumberString { get; set; }

    [Column("AANumberInt")]
    public int? AanumberInt { get; set; }

    [Column("AAStat")]
    [StringLength(10)]
    [Unicode(false)]
    public string Aastat { get; set; }

    [Column("FAInvoiceID")]
    public int FainvoiceId { get; set; }

    [Column("FAContactID")]
    public int FacontactId { get; set; }

    [Column("FAContactTypeID")]
    [StringLength(50)]
    public string FacontactTypeId { get; set; }

    [Column("NEWFAInvoiceContact")]
    public int? NewfainvoiceContact { get; set; }

    [ForeignKey("FacontactId")]
    [InverseProperty("FainvoiceContacts")]
    public virtual Facontact Facontact { get; set; }

    [ForeignKey("FainvoiceId")]
    [InverseProperty("FainvoiceContacts")]
    public virtual Arinvoice Fainvoice { get; set; }
}
