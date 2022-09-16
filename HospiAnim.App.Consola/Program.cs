using System;
using HospiAnim.App.Dominio;
using HospiAnim.App.Persistencia;

namespace HospiAnim.App.Consola
{
    class Program
    {
        
        private static IRepositorioMascota _repoMascota = new RepositorioMascota(new Persistencia.AppContext());
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World EF!");
            //AddMascota();
            //BuscarMascota();
            //Console.WriteLine("Buscando primera mascota...");
            //BuscarMascota(1);
            //Console.WriteLine("Buscando segunda mascota...");
            //BuscarMascota(3);
            //Console.WriteLine("Borrando tercera mascota...");
            //DeleteMascota();
            //Mascota mascota_original = BuscarMascota(1);
            //Mascota mascota_actualizado = UpdateMascota(mascota_original); //estoy poniendo la info de Nicolay Perez de id1 en id2
            //Mascota mascota_actualizado = UpdateMascota(AddMascota()); //estoy poniendo la info de Nicolay Perez de id1 en id2
            //UpdateMascota(5); //estoy actualizando Nicolay5 Perez5 de la id5 que tenía Nicolay3 Perez3
            //GetAllMascotas();            
            //Console.WriteLine("Buscando mascota actualizado...");
            //BuscarMascota(3);


            //AsignarVeterinario();
        }

        private static void AddMascota()
        //private static Mascota AddMascota()
        {
            var mascota = new Mascota
            {
                
                Nombre = "Dobby",
                Edad = "3",                
                Raza = "Golden",
                SexoMascota = SexoMascota.Macho,

            };
            _repoMascota.AddMascota(mascota);
            //return mascota;
          
        }
      

        
        
        private static void BuscarMascota(int idMascota)
        {
            var mascota = _repoMascota.GetMascota(idMascota);
            //Console.WriteLine(mascota.Nombre+" "+mascota.Edad);
            string datos_mascota = "\\nNombre:"+ mascota.Nombre +"\\nEdad:"+ mascota.Edad +"\\nRaza:"+ mascota.Raza+ "\\nSexo:"+ mascota.SexoMascota;
            Console.WriteLine(datos_mascota);          
         //SIN RETORNO       
        }

        

        /*
        private static Mascota BuscarMascota(int idMascota)
        {
            var mascota = _repoMascota.GetMascota(idMascota);
            //Console.WriteLine(mascota.Nombre+" "+mascota.Apellidos);
            string datos_mascota = "\nNombre:"+mascota.Nombre+"\nApellidos:"+mascota.Apellidos+"\nNumero de Telefono:"+mascota.NumeroTelefono+"\nGenero:"+mascota.Genero+"\nDireccion:"+mascota.Direccion+"\nUbicacion (Longitud;Latitud):("+mascota.Longitud+";"+mascota.Latitud+")"+"\nCiudad:"+mascota.Ciudad+"\nFecha de Nacimiento:"+mascota.FechaNacimiento;
            Console.WriteLine(datos_mascota);          
            return mascota;//CON RETORNO  
        }
        */

      

        private static void DeleteMascota(int idMascota)
        {            
            _repoMascota.DeleteMascota(idMascota);
            Console.WriteLine("Mascota borrado!");           
                
        }
        
       
        //private static Mascota UpdateMascota(int idMascota)
        private static void UpdateMascota(int idMascota_original)
        {            
            //var mascota_actualizado = _repoMascota.UpdateMascota(mascota);
            var mascota_actualizado = new Mascota
            {
                
                Nombre = "Dobby",
                Edad = "1",                
                Raza = "Golden",
                SexoMascota = SexoMascota.Macho,
            };
            _repoMascota.UpdateMascota(mascota_actualizado, idMascota_original);
            //var mascota = _repoMascota.UpdateMascota(idMascota);

            Console.WriteLine("Mascota actualizado!");
            //return mascota_actualizado;           
                
        }
          //¡HASTA AQUÍ ME FUNCIONA! (FIN SEMANA 3)
      
        private static void GetAllMascotas()
        {
          var mascotas = _repoMascota.GetAllMascotas();          
          //for (int i=0;i<5;i++){
          //mascota: Mascotas){
          //    Console.WriteLine(mascotas[i].Nombre+" "+mascotas[i].Apellidos);         
          Console.WriteLine(mascotas);   //PENDIENTE COMO HACER PARA MOSTRARLOS COMO UNA LISTA      
          //}        
            
         //SIN RETORNO  
          
        }

        
            
            

        /*ESTO VA PARA LAS SIGUIENTES SEMANAS
        private static void AsignarVeterinario()
        {
            var veterinario = _repoMascota.AsignarVeterinario(1,2);
            Console.WriteLine(veterinario.Nombre+" "+veterinario.Apellidos);
        }
        */
    }
}
