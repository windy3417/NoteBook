using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NoteBook.Modle;

namespace NoteBook.DAL
{
 public   class RecordService
    {
        public List<NoteRecordModle> GetNoteRecordList()
        {
            using (var db = new NoteBookContext())

            {
                return db.NoteRecords.Where(s => s.status!=EnumModle.VoucherStatus.结案.ToString()).ToList();
            }
        }
    }
}
