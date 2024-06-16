using DAL;
using EvsizBireylerYardimSistemi.MODEL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;

namespace EvsizBireylerYardimSistemi.BLL
{
    public class IhtiyaclarBL
    {
        public bool IhtiyacEkle(Ihtiyaclar ihtiyac)
        {
            try
            {
                SqlParameter[] p =
                {
                    new SqlParameter("@adi",ihtiyac.Adi),
                    new SqlParameter("@adet",ihtiyac.Adet),
                    new SqlParameter("@temindurum",ihtiyac.TeminDurumu)
                };
                var hlp = new Helper();
                return hlp.ExecuteNonQuery("Insert into tblihtiyaclar values (@adi, @adet, @temindurum)", p) > 0;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public bool IhtiyacGuncelle(Ihtiyaclar ihtiyac)
        {
            try
            {
                SqlParameter[] p =
                {
                    new SqlParameter("@adi",ihtiyac.Adi),
                    new SqlParameter("@adet",ihtiyac.Adet),
                    new SqlParameter("@temindurum",ihtiyac.TeminDurumu),
                    new SqlParameter("@id",ihtiyac.id)

                };
                var hlp = new Helper();
                return hlp.ExecuteNonQuery("Update tblihtiyaclar set Adi=@adi, Adet=@adet, TeminEdilmeDurumu=@temindurum where id=@id", p) > 0;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public bool IhtiyacSil(int id)
        {
            try
            {
                SqlParameter[] p = { new SqlParameter("@id", id) };
                var hlp = new Helper();
                return hlp.ExecuteNonQuery("Delete from tblihtiyaclar where id=@id", p) > 0;
            }
            catch (Exception)
            {

                throw;
            }
        }
        public DataTable GetAllData()
        {
            var hlp = new Helper();
            string sql = "Select * from tblihtiyaclar";
            return hlp.GetData(sql);
        }
    }
}
