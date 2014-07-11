using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;


namespace WebServices_GLT
{
    /// <summary>
    /// Descripción breve de EmulacionRSA
    /// </summary>
    [WebService(Namespace = "http://s16988306.onlineus.com:8050/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // Para permitir que se llame a este servicio web desde un script, usando ASP.NET AJAX, quite la marca de comentario de la línea siguiente. 
    // [System.Web.Script.Services.ScriptService]
    public class EmulacionRSA : System.Web.Services.WebService
    {

        [WebMethod]
        public Boolean autenticarRSA(int passCode, String usuario)
        {
            RSA_GLT rsa = new RSA_GLT();
            Boolean resultado=rsa.TokenExist(usuario,passCode);
            return resultado;
        }
    }
}
