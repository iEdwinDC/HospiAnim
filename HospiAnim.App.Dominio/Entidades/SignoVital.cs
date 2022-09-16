using System;
namespace HospiAnim.App.Dominio
{

    public class SignoVital
    {
        public int id { get; set; }
        public float Valor {get;set;}
        public TipoSigno Signo { get; set; }
    }
}