using System;
namespace HospiAnim.App.Dominio
{

    public class Mascota
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Edad { get; set; }
        public string Raza { get; set; }
        public SexoMascota SexoMascota { get; set; }
        public HistoriaClinica HistoriaClinica { get; set; }
        public Propietario Propietario { get; set; }
        public System.Collections.Generic.List<SignoVital> SignosVitales { get; set; }
        public Veterinario Veterinario  {get; set; }
        
    }
}