using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaEnapsulamiento {
    class Program {
        static void Main(string[] args) {
            // Instancia de contacto
            Contacto contactoUno = new Contacto();

            contactoUno.Nombre = "José García";
            contactoUno.Direccion = "Veracruz S/N";
            contactoUno.CorreoElectronico = "josegarcia@correo.com";
            contactoUno.TelefonoCasa = "1234567890";
            contactoUno.TelefonoCelular = "654321";

            Console.WriteLine("Nombre: " + contactoUno.Nombre);
            Console.WriteLine("Direccion: " + contactoUno.Direccion);
            Console.WriteLine("CorreoElectronico: " + contactoUno.CorreoElectronico);
            Console.WriteLine("Telefono Casa: " + contactoUno.TelefonoCasa);
            Console.WriteLine("Telefono Celular: " + contactoUno.TelefonoCelular);
            Console.ReadKey();
        }
    }
}
