using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SampleProject.Data.Models;

[Table("GEUserMessagesHidden")]
public partial class GeuserMessagesHidden
{
    [Key]
    [Column("GEUserMessagesHiddenID")]
    public int GeuserMessagesHiddenId { get; set; }

    [Column("AAStatus")]
    [StringLength(50)]
    [Unicode(false)]
    public string Aastatus { get; set; }

    [Column("ADUserID")]
    public int AduserId { get; set; }

    [Column("GEMessagesID")]
    public int GemessagesId { get; set; }

    [Column("GEMessageHiddenCount")]
    public int GemessageHiddenCount { get; set; }
}
