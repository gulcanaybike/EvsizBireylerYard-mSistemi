using DAL;
using EvsizBireylerYardimSistemi.MODEL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace EvsizBireylerYardimSistemi.BLL
{
    public class YardimYerleriBL
    {
        public DataTable GetAllData()
        {
            try
            {
                var hlp = new Helper();
                string sql = "SELECT id, yerAdi, caddeAdi, sehirAdi, ulkeAdi FROM tblYardimYerleri";
                return hlp.GetData(sql);
            }
            catch (Exception)
            {

                throw;
            }
            
        }
        public bool YardimYeriEkle(YardimYerleri yardimyerleri)
        {
            try
            {
                SqlParameter[] p = 
                {
                    new SqlParameter("@yeradi",yardimyerleri.yerAdi),
                    new SqlParameter("@caddeadi",yardimyerleri.caddeAdi),
                    new SqlParameter("@sehiradi",yardimyerleri.sehirAdi),
                    new SqlParameter("@ulkeadi",yardimyerleri.ulkeAdi),
                };
                var hlp = new Helper();
                return hlp.ExecuteNonQuery("Insert into tblYardimYerleri values (@yeradi, @caddeadi, @sehiradi, @ulkeadi)", p) > 0;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public bool YardimYeriGuncelle(YardimYerleri yardimyerleri)
        {
            try
            {
                SqlParameter[] p =
                {
                    new SqlParameter("@yeradi",yardimyerleri.yerAdi),
                    new SqlParameter("@caddeadi",yardimyerleri.caddeAdi),
                    new SqlParameter("@sehiradi",yardimyerleri.sehirAdi),
                    new SqlParameter("@ulkeadi",yardimyerleri.ulkeAdi),
                     new SqlParameter("@id",yardimyerleri.id)
                };
                var hlp = new Helper();
                return hlp.ExecuteNonQuery("Update tblYardimYerleri set yerAdi=@yeradi, caddeAdi=@caddeadi, sehirAdi=@sehiradi, ulkeAdi=@ulkeadi where id=@id",p)>0;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public bool YardimYeriSil(int id)
        {
            try
            {
                SqlParameter[] p = { new SqlParameter("@id", id) };
                var hlp = new Helper();
                return hlp.ExecuteNonQuery("Delete from tblYardimYerleri where id=@id", p) > 0;
            }
            catch (Exception)
            {

                throw;
            }
        }

    }
}
