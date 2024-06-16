
using EvsizBireylerYardimSistemi.MODEL;
using System;
using System.Data.SqlClient;
using DAL;
using System.Data;

namespace EvsizBireylerYardimSistemi.BLL
{
    public class KullaniciBL
    {
        //public bool KullaniciBul(string Tc_No, string Sifre)
        //{
        //    try
        //    {
        //        bool giris = false;
        //        SqlParameter[] p = {
        //        new SqlParameter("@tc_no", Tc_No),
        //        new SqlParameter("@sifre",Sifre)
        //        };
        //        Helper hlp = Helper.Instance;
        //        using (var dr = hlp.ExecuteReader("Select id,tc_no,ad,soyad,sifre from tblOgrenciler where tc_no=@tc_no and sifre=@sifre", p))
        //        {
        //            Kullanici kull = null;
        //            if (dr.Read())
        //            {

        //                kull = new Kullanici
        //                {
        //                    id = Convert.ToInt32(dr["id"]),
        //                    Tc_No = dr["tc_no"].ToString(),
        //                    Ad = dr["ad"].ToString(),
        //                    Soyad = dr["soyad"].ToString(),
        //                    Sifre = dr["sifre"].ToString()
        //                };
        //                giris = true;
        //            }

        //            dr.Close();
        //            hlp.Dispose();
        //            return giris;
        //        }
        //    }
        //    catch (Exception)
        //    {
        //        throw;
        //    }
        //}

        public bool KullaniciGirisi(string Tc_No, string Sifre, int isAdmin, out Kullanici kullanici)
        {
            try
            {
                kullanici = null;
                //bool giris = false;
                SqlParameter[] p = {
                new SqlParameter("@tc_no", Tc_No),
                new SqlParameter("@sifre",Sifre),
                new SqlParameter("@isAdmin", isAdmin)
                };
                var hlp = new Helper();
                using (var dr = hlp.ExecuteReader("Select id,tc_no,ad,soyad,sifre from tblKullanici where tc_no=@tc_no and sifre=@sifre AND isAdmin=@isAdmin", p))
                {

                    if (dr.Read())
                    {

                        kullanici = new Kullanici
                        {
                            id = Convert.ToInt32(dr["id"]),
                            Tc_No = dr["tc_no"].ToString(),
                            Ad = dr["ad"].ToString(),
                            Soyad = dr["soyad"].ToString(),
                            Sifre = dr["sifre"].ToString()
                        };
                        return true;
                        //giris = true;
                    }
                }
                return false;
            }
            catch
            {
                throw;
            }
        }

        public bool KullaniciEkle(Kullanici kull)
        {
            try
            {
                SqlParameter[] p =
                {
                    new SqlParameter("@tc_no",kull.Tc_No),
                    new SqlParameter("@ad",kull.Ad),
                    new SqlParameter("@soyad",kull.Soyad),
                    new SqlParameter("@sifre",kull.Sifre)
                };
                var hlp = new Helper();
                return hlp.ExecuteNonQuery("Insert into tblKullanici (tc_no, ad, soyad, sifre) values (@tc_no, @ad, @soyad, @sifre)", p) > 0;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public DataTable GetAllData()
        {
            var hlp = new Helper();
            string sql = "Select tc_no, ad, soyad from tblKullanici";
            return hlp.GetData(sql);
        }
    }
}
