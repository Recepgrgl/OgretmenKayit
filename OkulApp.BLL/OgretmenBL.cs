using DAL;
using OkulApp.MODEL;
using System;
using System.Data.SqlClient;
using System.Runtime.CompilerServices;

namespace OkulApp.BLL//Bussiness Logic Layer
{
    public class OgretmenBL
    {
        public bool OgretmenEkle(Ogretmen ogretmen)
        {
            try
            {
                SqlParameter[] p = {
                                  new SqlParameter("@Ad",ogretmen.Ad),
                                  new SqlParameter("@Soyad",ogretmen.Soyad),
                                  new SqlParameter("@Tc",ogretmen.Tc)
                            };

                var hlp = new Helper();
                return hlp.ExecuteNonQuery("Insert into tblOgretmenler (Ad,Soyad,Tc) values (@Ad,@Soyad,@Tc)", p) > 0;
            }
            catch (SqlException)
            {
                throw;
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                //if (cn != null && cn.State != ConnectionState.Closed)
                //{
                //    //cn.Close();
                //    cn.Dispose();

                //    cmd.Dispose();
                //}
            }
        }


    }
}
