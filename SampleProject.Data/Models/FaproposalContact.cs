using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SampleProject.Data.Models;

[Table("FAProposalContacts")]
public partial class FaproposalContact
{
    [Key]
    [Column("FAProposalContactID")]
    public int FaproposalContactId { get; set; }

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

    [Column("FAProposalID")]
    public int FaproposalId { get; set; }

    [Column("FAContactID")]
    public int FacontactId { get; set; }

    [Column("FAContactTypeID")]
    [StringLength(50)]
    public string FacontactTypeId { get; set; }

    [Column("NEWFAProposalContact")]
    public int? NewfaproposalContact { get; set; }

    [ForeignKey("FacontactId")]
    [InverseProperty("FaproposalContacts")]
    public virtual Facontact Facontact { get; set; }

    [ForeignKey("FaproposalId")]
    [InverseProperty("FaproposalContacts")]
    public virtual Oeproposal Faproposal { get; set; }
}
