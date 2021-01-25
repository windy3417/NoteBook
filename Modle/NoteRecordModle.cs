using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace NoteBook.Modle
{
    [Table("NoteRecords")]
  public  class NoteRecordModle
    {
        [Key]
        [MaxLength(20)]
        public string voucherNo { get; set; }

        [Required]
        [MaxLength(50)]
        public string itemName { get; set; }

        public DateTime makeTime { get; set; }

        [Required(ErrorMessage = "需求提出时间不能为空")]
        public DateTime requesteDate { get; set; }

        public DateTime needCompletedDate { get; set; }
        public DateTime planCompletedDate { get; set; }

        [Required]
        public string memo { get; set; }
      
        //需求描述
        [Column(TypeName ="ntext")]
        [Required]
        public string recorder { get; set; }

        //记录人或是制单人（登录软件人）
        [Column(TypeName ="char")]
        [MaxLength(5)]
        public string userID { get; set; }

        //申请人
        [Column(TypeName = "char")]
        [MaxLength(5)]
        public string requesteUserID { get; set; }

        //责任人
        [Column(TypeName = "char")]
        [MaxLength(5)]
        public string responsibleUserID { get; set; }

     
        [Required]
        
        public string status { get; set; }
    }

    [Table("Process")]
  public class ProcessModle
    {
        int id { get; set; }
        string voucherNo { get; set; }

        //处理进程
        [Column(TypeName ="ntext")]
        string opinion { get; set; }
    }
}
