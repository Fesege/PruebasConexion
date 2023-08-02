using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Runtime.Remoting.Messaging;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Data.Odbc;


namespace DL
{
    public class Conexion
    {
        OdbcConnection conn = new OdbcConnection("Dsn=genrep;uid=desa");


        public OdbcConnection getConn
        {
            get { return conn; }
        }

        public static readonly string instancia = _instancia;

        private static string _instancia
        {

            get { return "informix"; }

        }

    }
}
