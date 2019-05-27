using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;


namespace ConsoleApp1
{

    class Class2
    {
        SqlConnection con = new SqlConnection("Data Source = LAPTOP-P493QLMI\\SQLEXPRESS;Initial Catalog = Practica; Integrated Security = True; User ID = sa; Password=admin123");

        //procedimiento que abre la conexion sqlsever
        public void conectar()
        {
            try
            {
                con.Open();

            }
            catch (Exception ex)
            {


                Console.Write(ex.Message);
            }
        }

        //procedimiento que cierra la conexion sqlserver
        public void desconectar()
        {
            con.Close();
        }

        //funcion que devuelve la conexion sqlserver
        public SqlConnection conex()
        {
            return con;
        }

        public bool insert(string nombre, string apellido)
        {
            con.Open();
            SqlCommand insert = new SqlCommand(string.Format("insert into Personal values('{0}', '{1}')", nombre, apellido), con);
            if (insert.ExecuteNonQuery() > 0)
            {
                con.Close();
                return true;
            }
            else
            {
                con.Close();
                return false;
            }

        }




        public bool update(int ID, string nombre, string apellido)
        {
            con.Open();

            SqlCommand update = new SqlCommand(string.Format("UPDATE personal set nombre='{1}', apellido='{2}' from personal where ID={0}", ID, nombre, apellido), con);


            if (update.ExecuteNonQuery() > 0)
            {
                con.Close();
                return true;
            }
            else
            {
                con.Close();
                return false;
            }


        }

        public bool Delete(int ID)
        {
            con.Open();

            SqlCommand update = new SqlCommand(string.Format("delete from personal where ID={0}", ID), con);


            if (update.ExecuteNonQuery() > 0)
            {
                con.Close();
                return true;
            }
            else
            {
                con.Close();
                return false;
            }
        }

        public DataTable select()
        {
            con.Open();

            SqlCommand command = new SqlCommand("select * from Personal", con);

            SqlDataAdapter ad = new SqlDataAdapter(command);
            DataSet ds = new DataSet();
            ad.Fill(ds, "tabla");
            con.Close();
            return ds.Tables["tabla"];
        }

        public DataTable select(int Id)
        {
            con.Open();

            SqlCommand command = new SqlCommand(string.Format("select * from Personal where ID={0}", Id), con);

            SqlDataAdapter ad = new SqlDataAdapter(command);
            DataSet ds = new DataSet();
            ad.Fill(ds, "tabla");
            con.Close();
            return ds.Tables["tabla"];
        }

        public DataTable select(string campo, string valor)
        {
            con.Open();

            SqlCommand command = new SqlCommand(string.Format("select * from Personal where {0}= '{1}'", campo, valor), con);

            SqlDataAdapter ad = new SqlDataAdapter(command);
            DataSet ds = new DataSet();
            ad.Fill(ds, "tabla");
            con.Close();
            return ds.Tables["tabla"];
        }

        public bool select1(string nombre, string contraseña)
        {
            con.Open();

            SqlCommand command = new SqlCommand(string.Format("select * from Usuario where nombre= '{0}' and contraseña='{1}'", nombre, contraseña), con);

            SqlDataAdapter ad = new SqlDataAdapter(command);
            DataSet ds = new DataSet();
            ad.Fill(ds, "tabla");
            con.Close();

            DataTable dt = ds.Tables["tabla"];
            if (dt.Rows.Count>0)
            {
                return true;
            }
            else
            {
                return false;
            }
            



        }

    }
}
