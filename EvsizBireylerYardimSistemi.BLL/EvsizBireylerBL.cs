using System;
using System.Collections.Generic;
using System.Text;
using EvsizBireylerYardimSistemi.MODEL;
using System.Data.SqlClient;
using DAL;
using System.Data;
using System.Collections;
using System.Configuration;
using System.Globalization;


namespace EvsizBireylerYardimSistemi.BLL
{
    public class EvsizBireylerBL
    {
        public bool EvsizBireyEkle(EvsizBireyler birey)
        {
            try
            {
                SqlParameter[] p =
                {
                    new SqlParameter("@tc_no",birey.Tc_No),
                    new SqlParameter("@adi",birey.Adi),
                    new SqlParameter("@yas",birey.Yas),
                    new SqlParameter("@cinsiyet",birey.Cinsiyet),
                    new SqlParameter("@bolge",birey.Bolge),
                    new SqlParameter("@dogumtarihi",birey.DogumTarihi),
                    new SqlParameter("@gelirdurumu",birey.GelirDurumu)
                };
                var hlp = new Helper();
                return hlp.ExecuteNonQuery("Insert into tblEvsizBireyler values (@tc_no, @adi, @yas, @cinsiyet, @bolge, @dogumtarihi, @gelirdurumu)", p) > 0;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public bool EvsizBireyGuncelle(EvsizBireyler birey)
        {
            try
            {
                SqlParameter[] p ={
                    new SqlParameter("@tc_no",birey.Tc_No),
                    new SqlParameter("@adi",birey.Adi),
                    new SqlParameter("@yas",birey.Yas),
                    new SqlParameter("@cinsiyet",birey.Cinsiyet),
                    new SqlParameter("@bolge",birey.Bolge),
                    new SqlParameter("@dogumtarihi",birey.DogumTarihi),
                    new SqlParameter("@gelirdurumu",birey.GelirDurumu),
                    new SqlParameter("@id",birey.id)                   
                };
                var hlp = new Helper();
                return hlp.ExecuteNonQuery("Update tblEvsizBireyler set Tc_No=@tc_no,Adi=@adi,Yas=@yas,Cinsiyet=@cinsiyet,Bolge=@bolge,DogumTarihi=@dogumtarihi,GelirDurumu=@gelirdurumu where id=@id", p) > 0;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public bool EvsizBireySil(int id)
        {
            try
            {
                SqlParameter[] p = { new SqlParameter("@id", id) };
                var hlp = new Helper();
                return hlp.ExecuteNonQuery("Delete from tblEvsizBireyler where id=@id", p) > 0;
            }
            catch (Exception)
            {

                throw;
            }
        }

        /*public void GetData()
        {
            SqlConnection cn = new SqlConnection("Data Source= .; Initial Catalog=EvsizBireylerYardımSistemiDB; user=sa; password=abc123");
            //string cstr = ConfigurationManager.ConnectionStrings["cstr"].ConnectionString;
            SqlCommand cmd = new SqlCommand("Select * from tblEvsizBireyler",cn);
            SqlDataAdapter sd = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sd.Fill(dt);

        }*/

       public DataTable GetAllData()
        {
            var hlp=new Helper();
            string sql = "Select * from tblEvsizBireyler";
            return hlp.GetData(sql);
        }

        public DataTable GetFilteredData(string kelime)
        {
            var hlp = new Helper();
            return hlp.veriAra(kelime);
        }
    }
}
