using System;
using System.Collections.Generic;
using System.Linq;
using HospiAnim.App.Dominio;

namespace HospiAnim.App.Persistencia
{
   public interface IRepositorioMascota
   {
        IEnumerable<Mascota> GetAllMascotas();
        Mascota AddMascota(Mascota mascota);
        Mascota UpdateMascota(Mascota mascota, int idMascota_original);
        void DeleteMascota(int idMascota);
        Mascota GetMascota(int idMascota);
        Veterinario AsignarVeterinario(int idMascota, int idVeterinario);

   }

}