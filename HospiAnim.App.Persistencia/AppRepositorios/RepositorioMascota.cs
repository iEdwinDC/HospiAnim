using System.Collections.Generic;
using System.Linq;
using HospiAnim.App.Dominio;

namespace HospiAnim.App.Persistencia
{

    public class RepositorioMascota : IRepositorioMascota
    {
        /// <summary>
        /// Referencia al contexto de Mascota
        /// </summary>
        private readonly AppContext _appContext;
        /// <summary>
        /// Metodo Constructor Utiiza 
        /// Inyeccion de dependencias para indicar el contexto a utilizar
        /// </summary>
        /// <param name="appContext"></param>//
        public RepositorioMascota(AppContext appContext)
        {
            _appContext = appContext;
        }


        Mascota IRepositorioMascota.AddMascota(Mascota mascota)
        {
            var mascotaAdicionado = _appContext.Mascotas.Add(mascota);
            _appContext.SaveChanges();
            return mascotaAdicionado.Entity;

        }

        void IRepositorioMascota.DeleteMascota(int idMascota)
        {
            var mascotaEncontrado = _appContext.Mascotas.FirstOrDefault(m => m.Id == idMascota);
            if (mascotaEncontrado == null)
                return;
            _appContext.Mascotas.Remove(mascotaEncontrado);
            _appContext.SaveChanges();
        }

        IEnumerable<Mascota> IRepositorioMascota.GetAllMascotas()
        {
            return _appContext.Mascotas;
        }

        Mascota IRepositorioMascota.GetMascota(int idMascota)
        {
            return _appContext.Mascotas.FirstOrDefault(m => m.Id == idMascota);
        }

        
        //Mascota IRepositorioMascota.UpdateMascota(Mascota mascota)//original del Ing. Oscar
        //Mascota IRepositorioMascota.UpdateMascota(int idMascota)
        Mascota IRepositorioMascota.UpdateMascota(Mascota mascota, int idMascota_original)//modificada por mi para que funcionara
        {
            //var mascotaEncontrado = _appContext.Mascotas.FirstOrDefault(m => m.Id == mascota.Id);//original del Ing. Oscar
            //var mascotaEncontrado = _appContext.Mascotas.FirstOrDefault(m => m.Id == idMascota);
            var mascotaEncontrado = _appContext.Mascotas.FirstOrDefault(m => m.Id == idMascota_original);//modificada por mi para que funcionara
            if (mascotaEncontrado != null)
            {
                mascotaEncontrado.Nombre = mascota.Nombre;
                mascotaEncontrado.Edad = mascota.Edad;
                mascotaEncontrado.Raza = mascota.Raza;
                mascotaEncontrado.SexoMascota = mascota.SexoMascota;
                mascotaEncontrado.HistoriaClinica = mascota.HistoriaClinica;
                mascotaEncontrado.Propietario = mascota.Propietario;
                mascotaEncontrado.SignosVitales = mascota.SignosVitales;
                
                _appContext.SaveChanges();


            }
            return mascotaEncontrado;
        }

        Veterinario IRepositorioMascota.AsignarVeterinario(int idMascota, int idVeterinario)
        {
            var mascotaEncontrado = _appContext.Mascotas.FirstOrDefault(m => m.Id == idMascota);
            if (mascotaEncontrado != null)
            {
                var veterinarioEncontrado = _appContext.Veterinarios.FirstOrDefault(v => v.Id == idVeterinario);
                if (veterinarioEncontrado != null)
                {
                    mascotaEncontrado.Veterinario = veterinarioEncontrado;
                    _appContext.SaveChanges();
                }
                return veterinarioEncontrado;
            }
            return null;

        }
    }
}