using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SampleProject.Data.Models;

[Table("MMExchangeRateConfigs")]
public partial class MmexchangeRateConfig
{
    [Key]
    [Column("MMExchangeRateConfigID")]
    public int MmexchangeRateConfigId { get; set; }

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

    [Column("FK_ICProductGroupID")]
    public int FkIcproductGroupId { get; set; }

    [Column("FK_ICDepartmentID")]
    public int FkIcdepartmentId { get; set; }

    [Column("FK_ICProductAttributeID")]
    public int FkIcproductAttributeId { get; set; }

    [Column("MMExchangeRateConfigLumberTypeCombo")]
    [StringLength(50)]
    public string MmexchangeRateConfigLumberTypeCombo { get; set; }

    [Column("MMExchangeRateConfigThickOperationTypeCombo")]
    [StringLength(50)]
    public string MmexchangeRateConfigThickOperationTypeCombo { get; set; }

    [Column("MMExchangeRateConfigBlockOperationTypeCombo")]
    [StringLength(50)]
    public string MmexchangeRateConfigBlockOperationTypeCombo { get; set; }

    [Column("MMExchangeRateConfigThickValue", TypeName = "decimal(18, 5)")]
    public decimal? MmexchangeRateConfigThickValue { get; set; }

    [Column("MMExchangeRateConfigBlockValue", TypeName = "decimal(18, 5)")]
    public decimal? MmexchangeRateConfigBlockValue { get; set; }

    [Column("MMExchangeRateConfigRemarkValue")]
    [StringLength(512)]
    public string MmexchangeRateConfigRemarkValue { get; set; }

    [Column("MMExchangeRateConfigWidthOperationTypeCombo")]
    [StringLength(50)]
    public string MmexchangeRateConfigWidthOperationTypeCombo { get; set; }

    [Column("MMExchangeRateConfigWidthValue", TypeName = "decimal(18, 5)")]
    public decimal? MmexchangeRateConfigWidthValue { get; set; }

    [Column("MMExchangeRateConfigLengthOperationTypeCombo")]
    [StringLength(50)]
    public string MmexchangeRateConfigLengthOperationTypeCombo { get; set; }

    [Column("MMExchangeRateConfigLengthValue", TypeName = "decimal(18, 5)")]
    public decimal? MmexchangeRateConfigLengthValue { get; set; }

    [Column("MMExchangeRateConfigThickMinValue", TypeName = "decimal(18, 5)")]
    public decimal? MmexchangeRateConfigThickMinValue { get; set; }

    [Column("MMExchangeRateConfigThickMaxValue", TypeName = "decimal(18, 5)")]
    public decimal? MmexchangeRateConfigThickMaxValue { get; set; }

    [Column("FK_ICProductAttributeSpecialityID")]
    public int? FkIcproductAttributeSpecialityId { get; set; }

    [Column("MMExchangeRateConfigThickExchange", TypeName = "decimal(18, 5)")]
    public decimal? MmexchangeRateConfigThickExchange { get; set; }

    [Column("MMExchangeRateConfigWidthBonus", TypeName = "decimal(18, 5)")]
    public decimal? MmexchangeRateConfigWidthBonus { get; set; }

    [Column("MMExchangeRateConfigLengthBonus", TypeName = "decimal(18, 5)")]
    public decimal? MmexchangeRateConfigLengthBonus { get; set; }

    [ForeignKey("FkIcdepartmentId")]
    [InverseProperty("MmexchangeRateConfigs")]
    public virtual Icdepartment FkIcdepartment { get; set; }

    [ForeignKey("FkIcproductAttributeId")]
    [InverseProperty("MmexchangeRateConfigs")]
    public virtual IcproductAttribute FkIcproductAttribute { get; set; }

    [ForeignKey("FkIcproductGroupId")]
    [InverseProperty("MmexchangeRateConfigs")]
    public virtual IcproductGroup FkIcproductGroup { get; set; }
}
