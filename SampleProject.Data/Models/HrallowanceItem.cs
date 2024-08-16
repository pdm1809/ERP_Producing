using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SampleProject.Data.Models;

[Table("HRAllowanceItems")]
public partial class HrallowanceItem
{
    [Key]
    [Column("HRAllowanceItemID")]
    public int HrallowanceItemId { get; set; }

    [Column("AAStatus")]
    [StringLength(50)]
    [Unicode(false)]
    public string Aastatus { get; set; }

    [Column("FK_HRAllowanceID")]
    public int FkHrallowanceId { get; set; }

    [Column("FK_HREmployeeID")]
    public int FkHremployeeId { get; set; }

    [Column("FK_ICProductID")]
    public int FkIcproductId { get; set; }

    [Column("FK_ICMeasureUnitID")]
    public int FkIcmeasureUnitId { get; set; }

    [Required]
    [Column("HRAllowanceItemProductName")]
    [StringLength(512)]
    public string HrallowanceItemProductName { get; set; }

    [Required]
    [Column("HRAllowanceItemProductDesc")]
    [StringLength(512)]
    public string HrallowanceItemProductDesc { get; set; }

    [Column("HRAllowanceItemProductQuantity", TypeName = "decimal(18, 5)")]
    public decimal? HrallowanceItemProductQuantity { get; set; }

    [ForeignKey("FkHrallowanceId")]
    [InverseProperty("HrallowanceItemFkHrallowances")]
    public virtual Hrallowance FkHrallowance { get; set; }

    [ForeignKey("FkHremployeeId")]
    [InverseProperty("HrallowanceItemFkHremployees")]
    public virtual Hrallowance FkHremployee { get; set; }

    [ForeignKey("FkIcmeasureUnitId")]
    [InverseProperty("HrallowanceItemFkIcmeasureUnits")]
    public virtual Hrallowance FkIcmeasureUnit { get; set; }

    [ForeignKey("FkIcproductId")]
    [InverseProperty("HrallowanceItemFkIcproducts")]
    public virtual Hrallowance FkIcproduct { get; set; }
}
