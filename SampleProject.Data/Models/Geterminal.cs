using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SampleProject.Data.Models;

[Table("GETerminals")]
public partial class Geterminal
{
    [Key]
    [Column("GETerminalID")]
    public int GeterminalId { get; set; }

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

    [Column("GETerminalNo")]
    [StringLength(50)]
    public string GeterminalNo { get; set; }

    [Column("GETerminalName")]
    [StringLength(50)]
    public string GeterminalName { get; set; }

    [InverseProperty("FkGeterminal")]
    public virtual ICollection<ApfeePaymentFeeConfig> ApfeePaymentFeeConfigs { get; set; } = new List<ApfeePaymentFeeConfig>();

    [InverseProperty("FkGeterminal")]
    public virtual ICollection<ApinvoiceIn> ApinvoiceIns { get; set; } = new List<ApinvoiceIn>();

    [InverseProperty("FkGeterminal")]
    public virtual ICollection<AppurchaseOrder> AppurchaseOrders { get; set; } = new List<AppurchaseOrder>();

    [InverseProperty("FkGeterminal")]
    public virtual ICollection<Arinvoice> Arinvoices { get; set; } = new List<Arinvoice>();

    [InverseProperty("FkGeterminal")]
    public virtual ICollection<Arproposal> Arproposals { get; set; } = new List<Arproposal>();

    [InverseProperty("FkGeterminal")]
    public virtual ICollection<ArsaleOrder> ArsaleOrders { get; set; } = new List<ArsaleOrder>();

    [InverseProperty("FkGeterminal")]
    public virtual ICollection<IcreceiptItem> IcreceiptItems { get; set; } = new List<IcreceiptItem>();

    [InverseProperty("FkGeterminal")]
    public virtual ICollection<Icreceipt> Icreceipts { get; set; } = new List<Icreceipt>();
}
