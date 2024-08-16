using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SampleProject.Data.Models;

[Table("FACreditNoteContacts")]
public partial class FacreditNoteContact
{
    [Key]
    [Column("FACreditNoteContactID")]
    public int FacreditNoteContactId { get; set; }

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

    [Column("FACreditNoteID")]
    public int FacreditNoteId { get; set; }

    [Column("FAContactID")]
    public int FacontactId { get; set; }

    [Column("FAContactTypeID")]
    [StringLength(50)]
    public string FacontactTypeId { get; set; }

    [Column("NEWFACreditNoteContact")]
    public int? NewfacreditNoteContact { get; set; }

    [ForeignKey("FacontactId")]
    [InverseProperty("FacreditNoteContacts")]
    public virtual Facontact Facontact { get; set; }

    [ForeignKey("FacreditNoteId")]
    [InverseProperty("FacreditNoteContacts")]
    public virtual FacreditNote FacreditNote { get; set; }
}
