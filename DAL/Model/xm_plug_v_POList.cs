namespace NoteBook.DAL.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class xm_plug_v_POList
    {
        [Key]
        [Column(Order = 0)]
        public DateTime 单据日期 { get; set; }

        [StringLength(30)]
        public string 采购订单号 { get; set; }

        [StringLength(20)]
        public string 供应商编码 { get; set; }

        [StringLength(98)]
        public string 供应商名称 { get; set; }

        [StringLength(8)]
        public string 业务类型 { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(60)]
        public string 存货编码 { get; set; }

        [StringLength(255)]
        public string 存货名称 { get; set; }

        [StringLength(255)]
        public string 规格型号 { get; set; }

        public decimal? 数量 { get; set; }

        public decimal? 单价 { get; set; }

        [Column(TypeName = "money")]
        public decimal? 本币价税合计 { get; set; }

        [Column(TypeName = "money")]
        public decimal? 本币无税金额 { get; set; }

        [StringLength(20)]
        public string 制单人 { get; set; }
    }
}
