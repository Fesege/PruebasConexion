using System;
using System.Collections.Generic;
using System.Data.Odbc;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace BL
{
    public class cli_direccion
    {
        public static ML.Result DireccionGetAll()
        {
            ML.Result result = new ML.Result();

            try
            {
     
                using (OdbcConnection context = new DL.Conexion().getConn)
                {
                    //guardanos la consulta en una variable 
                    var query = "SELECT * FROM cli_direccion LIMIT 5;";    

                    using (OdbcCommand cmd = new OdbcCommand())
                    {
                        cmd.CommandText = query;
                        cmd.Connection = context;
                        cmd.CommandType = CommandType.Text;
                        OdbcCommand command = new OdbcCommand(query, context);
                        cmd.Connection.Open();
                        //creamos el dataTable donde llegaran los datos

                        DataTable table = new DataTable();
                        OdbcDataAdapter adapter = new OdbcDataAdapter(cmd);
                        adapter.Fill(table);


                        if (table.Rows.Count > 0)
                        {
                            result.Objects = new List<object>();

                            foreach (DataRow row in table.Rows)
                            {
                                ML.cli_direccion direction = new ML.cli_direccion();

                                direction.cod_emp = decimal.Parse(row[0].ToString());
                                direction.cod_dir = decimal.Parse(row[1].ToString());
                                direction.dir_cli = row[2].ToString();
                                direction.col_cli = row[3].ToString();
                                direction.cp_cli = decimal.Parse(row[4].ToString());
                                direction.pob_cli = row[5].ToString();
                                direction.pro_cli = row[6].ToString();
                                direction.ent_calles = row[7].ToString();
                                direction.panel = row[8].ToString();
                                direction.volado = row[9].ToString();
                                direction.mas_gen = row[10].ToString();
                                direction.dir_cli2 = row[11].ToString();
                                direction.ent_calles2 = row[12].ToString();
                                direction.tel_cli1 = row[13].ToString();
                                direction.tel_cli2 = row[14].ToString();
                                direction.ciu_cli = row[15].ToString();
                                direction.num_int = row[16].ToString();
                                direction.num_ext = row[17].ToString();

                                result.Objects.Add(direction);
                            }

                            result.Correct = true;

                        }
                        else
                        {
                            result.Correct = false;
                            result.ErrorMessage = "Ocurrió un error al consultar";
                        }

                        cmd.Connection.Close();


                    }
                }
                    return result;
            }
            catch (Exception ex)
            {
                result.Correct = false;
                result.Ex = ex;
                result.ErrorMessage = ex.Message;
            }
            return result;
        }

    }
}
