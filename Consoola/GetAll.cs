using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Consoola
{

    public class GetAll
    {
        public static void DirectionGetAll()
        {

            ML.Result result = BL.cli_direccion.DireccionGetAll();

            if (result.Correct)
            {

                foreach (ML.cli_direccion direction in result.Objects)
                {
                    Console.WriteLine("\t codEmp: " + direction.cod_emp);
                    Console.WriteLine("\t coddir: " + direction.cod_dir);
                    Console.WriteLine("\t dir_cli: " + direction.dir_cli);
                    Console.WriteLine("\t col_cli: " + direction.col_cli);
                    Console.WriteLine("\t cp_cli: " + direction.cp_cli);
                    Console.WriteLine("\t pob_cli: " + direction.pob_cli);
                    Console.WriteLine("\t ent_calles: " + direction.ent_calles);
                    Console.WriteLine("\t panel: " + direction.panel);
                    Console.WriteLine("\t volado: " + direction.volado);
                    Console.WriteLine("\t mas_gen: " + direction.mas_gen);
                    Console.WriteLine("\t dir_cli: " + direction.dir_cli2);
                    Console.WriteLine("\t ent_calles2: " + direction.ent_calles2);
                    Console.WriteLine("\t dir_cli: " + direction.dir_cli2);

                }
            }
            else
            {
                Console.WriteLine("No se pudo traer la información del usaurios: " + result.ErrorMessage);


            }
        }

    }

}
