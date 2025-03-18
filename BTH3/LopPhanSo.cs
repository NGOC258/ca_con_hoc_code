using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PheptinhTrenPS
{
    internal class LopPhanSo
    {
        int tuso, mauso;
        public LopPhanSo()
        {
             tuso = 0;
             mauso = 1;
        }  
        public LopPhanSo(int t, int m)
        {
            tuso = t;
            mauso = m==0 ? 1 : m;

        }
        public int Tuso
        {
           get { return tuso; }
            set { tuso =value; }
                
         }

        public int Mauso
        {
            get { return mauso; }
            set { mauso = value; }

        }

        private void toiGian()
        {
            int UC = Class1.UCLN(tuso, mauso);
            if (UC > 0)
            {
                tuso /= UC;
                mauso /= UC;
            }
        }
        public LopPhanSo Cong(LopPhanSo p)
        {
            LopPhanSo kq= new LopPhanSo();
            kq.tuso = tuso * p.mauso + mauso * p.tuso;
            kq.mauso= mauso* p.mauso;
            kq.toiGian();
            return kq;
        }
        public LopPhanSo Tru(LopPhanSo p)
        {
            LopPhanSo kq = new LopPhanSo();
            kq.tuso = tuso * p.mauso - mauso * p.tuso;
            kq.mauso = mauso * p.mauso;
            kq.toiGian();
            return kq;
        }
        public LopPhanSo Nhan(LopPhanSo p)
        {
            LopPhanSo kq = new LopPhanSo();
            kq.tuso = tuso  * p.tuso;
            kq.mauso = mauso * p.mauso;
            kq.toiGian();
            return kq;
        }
        public LopPhanSo Chia(LopPhanSo p)
        {
            LopPhanSo kq = new LopPhanSo();
            kq.tuso = tuso * p.mauso ;
            kq.mauso = mauso * p.tuso;
            kq.toiGian();
            return kq;
        }

    }
}
