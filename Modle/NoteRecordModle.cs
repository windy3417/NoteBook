using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace NoteBook.Modle
{
  public  class NoteRecordModle
    {
        [Key]
        public string voucheNo { get; set; }
        public DateTime makeTime { get; set; }
        public string Summary { get; set; }
        [Column(TypeName ="ntext")]
        public string recorder { get; set; }
        public string userID { get; set; }
        public int status { get; set; }
    }
}
