using DAL;
using EvsizBireylerYardimSistemi.MODEL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;

namespace EvsizBireylerYardimSistemi.BLL
{
    public class BagislarBL
    {
        public bool BagisEkle(Bagislar bagis)
        {
            try
            {
                SqlParameter[] p =
                {
                    new SqlParameter("@ihtiyacid",bagis.ihtiyacId),
                    new SqlParameter("@bagisciadi",bagis.bagisciAdi),
                    new SqlParameter("@bagisadet",bagis.bagisciAdet)
                };
                var hlp = new Helper();
                return hlp.ExecuteNonQuery("Insert into tblBagislar values (@ihtiyacid, @bagisciadi, @bagisadet)", p) > 0;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public bool updateIhtiyaclar(Bagislar bagis)
        {
            try
            {
                SqlParameter[] p =
                {
                    new SqlParameter("@ihtiyacid",bagis.ihtiyacId),
                    new SqlParameter("@bagisadet",bagis.bagisciAdet)
                };
                var hlp = new Helper();
                return hlp.ExecuteNonQuery("UPDATE tblihtiyaclar set Adet = Adet - @bagisadet WHERE id=@ihtiyacid", p) > 0;
            }
            catch (Exception)
            {

                throw;
            }
        }

        /*public bool updateTeminDurum(Bagislar bagis)
        {
            try
            {
                SqlParameter[] p =
                {
                    new SqlParameter("@ihtiyacid",bagis.ihtiyacId)
                };
                var hlp = new Helper();
                return hlp.ExecuteNonQuery("UPDATE tblihtiyaclar set TeminEdilmeDurumu = 'Edildi' WHERE id=@ihtiyacid AND Adet <= 0 ", p) > 0;
            }
            catch (Exception)
            {

                throw;
            }
        }*/

        public bool updateTeminDurum(int ihtiyacid)
        {
            
            try
            {
                SqlParameter[] p =
                {
                    new SqlParameter("@ihtiyacid",ihtiyacid)
                };
                var hlp = new Helper();
                return hlp.ExecuteNonQuery("UPDATE tblihtiyaclar set TeminEdilmeDurumu = 'Edildi' WHERE id=@ihtiyacid AND Adet <= 0 ", p) > 0;
            }
            catch (Exception)
            {

                throw;
            }
        }
        public DataTable GetAllData()
        {
            var hlp = new Helper();
            string sql = "Select b.IhtiyacId, i.Adi, b.BagisciAdi, b.BagisAdet from tblBagislar b Left Join tblihtiyaclar i on b.IhtiyacId=i.id";
            return hlp.GetData(sql);
        }

       public DataTable LoadIhtiyaclar() 
        {
            var hlp=new Helper();
            string sql = "Select id,Adi,Adet,TeminEdilmeDurumu from tblihtiyaclar WHERE TeminEdilmeDurumu='Edilmedi'";
            return hlp.GetData(sql);
        }
    }
}
