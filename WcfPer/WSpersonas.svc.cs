using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace WcfPer
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de clase "Service1" en el código, en svc y en el archivo de configuración.
    // NOTE: para iniciar el Cliente de prueba WCF para probar este servicio, seleccione Service1.svc o Service1.svc.cs en el Explorador de soluciones e inicie la depuración.
    public class WSpersonas : IWSpersonas
    {
        //toda persona que acceda a mi web service va a poder utilizar estos metodos
        public Persona ObtenerPersona(string Identificacion)
        {
            Persona Retorno = new Persona();
            Retorno.Resultado = new Resultado();

           if (Identificacion == "0")
            {
                Retorno.nombre = "Algemiro";
                Retorno.edad = 89;
            }
            else if(Identificacion == "1")
            {
                Retorno.nombre = "daniel";
                Retorno.edad = 22;

            }
            else
            {
                Retorno.Resultado = new Resultado();
                Retorno.Resultado.Error = true;
                Retorno.Resultado.Mensaje = "no sirve ";
            }


            return Retorno;

        }
    }
}
