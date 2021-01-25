using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NoteBook.EventArguments
{
   public class CoordinationEventArgs :EventArgs
    {
        
        public string voucherNo { get; set; }

     
        public string itemName { get; set; }

       
        public DateTime requesteDate { get; set; }

        public DateTime needCompletedDate { get; set; }

        public DateTime planCompletedDate { get; set; }

       
        public string memo { get; set; }

        
        public string recorder { get; set; }

       
        public string userID { get; set; }
        
        public string requesteUserID { get; set; }
       
        public string responsibleUserID { get; set; }

                
    }
}
