using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SampleProject.Data.Models;

[Table("MMJobTicketItems")]
public partial class MmjobTicketItem
{
    [Key]
    [Column("MMJobTicketItemID")]
    public int MmjobTicketItemId { get; set; }

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

    [Column("FK_MMJobTicketID")]
    public int? FkMmjobTicketId { get; set; }

    [Column("FK_MMWorkShopID")]
    public int? FkMmworkShopId { get; set; }

    [Column("FK_MMLineID")]
    public int? FkMmlineId { get; set; }

    [Column("FK_HRDepartmentRoomGroupItemID")]
    public int? FkHrdepartmentRoomGroupItemId { get; set; }

    [Column("FK_MMOperationDetailPlanItemChildID")]
    public int? FkMmoperationDetailPlanItemChildId { get; set; }

    [Column("MMJobTicketItemProductDesc")]
    [StringLength(512)]
    public string MmjobTicketItemProductDesc { get; set; }

    [Column("MMJobTicketItemDesc")]
    [StringLength(512)]
    public string MmjobTicketItemDesc { get; set; }

    [Column("MMJobTicketItemPlanQty", TypeName = "decimal(18, 5)")]
    public decimal? MmjobTicketItemPlanQty { get; set; }

    [Column("MMJobTicketItemPlanReceiptQty", TypeName = "decimal(18, 5)")]
    public decimal? MmjobTicketItemPlanReceiptQty { get; set; }

    [Column("MMJobTicketItemTodoQty", TypeName = "decimal(18, 5)")]
    public decimal? MmjobTicketItemTodoQty { get; set; }

    [Column("MMJobTicketItemReceiptQty", TypeName = "decimal(18, 5)")]
    public decimal? MmjobTicketItemReceiptQty { get; set; }

    [Column("MMJobTicketItemFailQty", TypeName = "decimal(18, 5)")]
    public decimal? MmjobTicketItemFailQty { get; set; }

    [Column("MMJobTicketItemCancelQty", TypeName = "decimal(18, 5)")]
    public decimal? MmjobTicketItemCancelQty { get; set; }

    [Column("MMJobTicketItemStatus")]
    [StringLength(50)]
    public string MmjobTicketItemStatus { get; set; }

    [Column("MMJobTicketItemCapacity")]
    [StringLength(1024)]
    public string MmjobTicketItemCapacity { get; set; }

    [Column("MMJobTicketItemExecutionFromDate", TypeName = "datetime")]
    public DateTime? MmjobTicketItemExecutionFromDate { get; set; }

    [Column("MMJobTicketItemExecutionToDate", TypeName = "datetime")]
    public DateTime? MmjobTicketItemExecutionToDate { get; set; }

    [Column("MMJobTicketItemExecutionMaxDate", TypeName = "datetime")]
    public DateTime? MmjobTicketItemExecutionMaxDate { get; set; }

    [Column("MMJobTicketItemAbstractID")]
    public int? MmjobTicketItemAbstractId { get; set; }

    [ForeignKey("FkMmjobTicketId")]
    [InverseProperty("MmjobTicketItems")]
    public virtual MmjobTicket FkMmjobTicket { get; set; }

    [ForeignKey("FkMmoperationDetailPlanItemChildId")]
    [InverseProperty("MmjobTicketItems")]
    public virtual MmoperationDetailPlanItemChild FkMmoperationDetailPlanItemChild { get; set; }

    [InverseProperty("FkMmjobTicketItem")]
    public virtual ICollection<MmjobTicketItemEmployee> MmjobTicketItemEmployees { get; set; } = new List<MmjobTicketItemEmployee>();
}
