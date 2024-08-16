using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SampleProject.Data.Models;

[Table("MMJobTickets")]
public partial class MmjobTicket
{
    [Key]
    [Column("MMJobTicketID")]
    public int MmjobTicketId { get; set; }

    [Column("AACreatedDate", TypeName = "datetime")]
    public DateTime? AacreatedDate { get; set; }

    [Column("AACreatedUser")]
    [StringLength(50)]
    public string AacreatedUser { get; set; }

    [Column("AAUpdatedDate", TypeName = "datetime")]
    public DateTime? AaupdatedDate { get; set; }

    [Column("AAUpdatedUser")]
    [StringLength(50)]
    public string AaupdatedUser { get; set; }

    [Column("AAStatus")]
    [StringLength(10)]
    public string Aastatus { get; set; }

    [Column("FK_MMOperationID")]
    public int? FkMmoperationId { get; set; }

    [Column("FK_MMWorkShopID")]
    public int? FkMmworkShopId { get; set; }

    [Column("FK_MMLineID")]
    public int? FkMmlineId { get; set; }

    [Column("FK_HRDepartmentRoomGroupItemID")]
    public int? FkHrdepartmentRoomGroupItemId { get; set; }

    [Column("FK_HREmployeeID")]
    public int? FkHremployeeId { get; set; }

    [Column("FK_BRBranchID")]
    public int? FkBrbranchId { get; set; }

    [Column("MMJobTicketNo")]
    [StringLength(50)]
    public string MmjobTicketNo { get; set; }

    [Column("MMJobTicketName")]
    [StringLength(50)]
    public string MmjobTicketName { get; set; }

    [Column("MMJobTicketDesc")]
    [StringLength(512)]
    public string MmjobTicketDesc { get; set; }

    [Column("MMJobTicketStatus")]
    [StringLength(50)]
    public string MmjobTicketStatus { get; set; }

    [Column("MMJobTicketDate", TypeName = "datetime")]
    public DateTime? MmjobTicketDate { get; set; }

    [Column("MMJobTicketFromDate", TypeName = "datetime")]
    public DateTime? MmjobTicketFromDate { get; set; }

    [Column("MMJobTicketToDate", TypeName = "datetime")]
    public DateTime? MmjobTicketToDate { get; set; }

    [ForeignKey("FkBrbranchId")]
    [InverseProperty("MmjobTickets")]
    public virtual Brbranch FkBrbranch { get; set; }

    [ForeignKey("FkHrdepartmentRoomGroupItemId")]
    [InverseProperty("MmjobTickets")]
    public virtual HrdepartmentRoomGroupItem FkHrdepartmentRoomGroupItem { get; set; }

    [ForeignKey("FkHremployeeId")]
    [InverseProperty("MmjobTickets")]
    public virtual Hremployee FkHremployee { get; set; }

    [ForeignKey("FkMmlineId")]
    [InverseProperty("MmjobTickets")]
    public virtual Mmline FkMmline { get; set; }

    [ForeignKey("FkMmoperationId")]
    [InverseProperty("MmjobTickets")]
    public virtual Mmoperation FkMmoperation { get; set; }

    [ForeignKey("FkMmworkShopId")]
    [InverseProperty("MmjobTickets")]
    public virtual MmworkShop FkMmworkShop { get; set; }

    [InverseProperty("FkMmjobTicket")]
    public virtual ICollection<MmjobTicketItem> MmjobTicketItems { get; set; } = new List<MmjobTicketItem>();
}
