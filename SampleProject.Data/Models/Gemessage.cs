using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SampleProject.Data.Models;

[Table("GEMessages")]
public partial class Gemessage
{
    [Key]
    [Column("GEMessagesID")]
    public int GemessagesId { get; set; }

    [Column("AAStatus")]
    [StringLength(50)]
    [Unicode(false)]
    public string Aastatus { get; set; }

    [Column("GEMessagesNo")]
    [StringLength(100)]
    [Unicode(false)]
    public string GemessagesNo { get; set; }

    [Column("GEMessagesDefault")]
    [StringLength(500)]
    [Unicode(false)]
    public string GemessagesDefault { get; set; }

    [Column("GEMessagesContentEN")]
    [StringLength(500)]
    [Unicode(false)]
    public string GemessagesContentEn { get; set; }

    [Column("GEMessagesContentVN")]
    [StringLength(300)]
    [Unicode(false)]
    public string GemessagesContentVn { get; set; }

    [Column("GEMessagesContentFR")]
    [StringLength(300)]
    [Unicode(false)]
    public string GemessagesContentFr { get; set; }

    [Column("GEMessagesContentGE")]
    [StringLength(300)]
    [Unicode(false)]
    public string GemessagesContentGe { get; set; }

    [Column("GEMessagesTitleEN")]
    [StringLength(100)]
    [Unicode(false)]
    public string GemessagesTitleEn { get; set; }

    [Column("GEMessagesTitleVN")]
    [StringLength(100)]
    [Unicode(false)]
    public string GemessagesTitleVn { get; set; }

    [Column("GEMessagesTitleFR")]
    [StringLength(100)]
    [Unicode(false)]
    public string GemessagesTitleFr { get; set; }

    [Column("GEMessagesTitleGE")]
    [StringLength(100)]
    [Unicode(false)]
    public string GemessagesTitleGe { get; set; }

    [Column("GEMessagesType")]
    public int? GemessagesType { get; set; }

    [Column("GEMessagesHiddenMaxCount")]
    public int? GemessagesHiddenMaxCount { get; set; }

    [Column("GEMessagesButtonsType")]
    public int? GemessagesButtonsType { get; set; }
}
