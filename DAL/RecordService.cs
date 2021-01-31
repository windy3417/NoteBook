using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NoteBook.Modle;

namespace NoteBook.DAL
{
 public   class RecordService
    {
        /// <summary>
        /// 协同处理参照数据源
        /// </summary>
        /// <returns></returns>
        public List<NoteRecordModle> GetNoteRecordRefList()
        {
            using (var db = new NoteBookContext())

            {
                //List<NoteRecordModle> noteRecordModles = new List<NoteRecordModle>();
                //noteRecordModles = db.NoteRecords.Where(s => s.status != EnumModle.VoucherStatus.结案.ToString()).ToList();
                return db.NoteRecords.Where(s => s.status!=EnumModle.VoucherStatus.结案.ToString()).ToList();
            }
        }


        
    }
}
