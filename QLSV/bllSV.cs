using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLSV
{
    internal class bllSV
    {
        SVDal daLSV;
        public bllSV()
        {
            daLSV = new SVDal();
        }
        public DataTable getAllSinhVien()
        {
            return daLSV.getAllSinhVien();
        }
        public bool InsertSinhVien(TTSV sv)
        {
            return daLSV.InsertSinhVien(sv);
        }
        public bool UpdateSinhVien(TTSV sv)
        {
            return daLSV.UpdateSinhVien(sv);
        }
        public bool DeleteSV(TTSV sv)
        {
            return daLSV.DeleteSV(sv);
        }
    }
}
