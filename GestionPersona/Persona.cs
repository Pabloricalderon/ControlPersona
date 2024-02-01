using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionPersona
{
     class Persona
    {
        //Campos privados
        //para cumplir el encapsulado
        String dpi;
        String nombre;
        String apellido;
        DateTime fechaNacimiento;
        

        //Encapsulado
        public String Dpi { get => dpi;   set => dpi = value; }
        public String Nombre { get => nombre; set => nombre = value; }
        public String Apellido { get => apellido; set => apellido = value; }
        public DateTime FechaNacimiento { get => fechaNacimiento; set => fechaNacimiento = value; }
      

        //Metodos: Acciones que se realizan 

        public Persona()
            {
            dpi = "";
            nombre = "";
            apellido = "";

            fechaNacimiento = DateTime.Now;
        }

        public void primeraMayuscula()
        {

            if (nombre.Length > 0) { 

                 StringBuilder nombreMayuscula = new StringBuilder(nombre);
                nombreMayuscula[0] = Char.ToUpper(nombreMayuscula[0]);
                 nombre = nombreMayuscula.ToString();

             }

            if (apellido.Length > 0)
            {

                StringBuilder apellidoMayuscula = new StringBuilder(apellido);
                apellidoMayuscula[0] = Char.ToUpper(apellidoMayuscula[0]);
                apellido = apellidoMayuscula.ToString();

            }
        }

        public int edad()
        {
            int edad = DateTime.Now.Year - fechaNacimiento.Year;
            if(DateTime.Now.Month < fechaNacimiento.Month)
            {
                edad--;
            }
            else if (DateTime.Now.Month == fechaNacimiento.Month)
            {
                if(DateTime.Now.Day < fechaNacimiento.Day)
                {
                    edad--;
                }
            }
           
            return edad;
        }

        public void normalizaNombre()
        {
            int tamanio = nombre.Length - 1;

            if (char.IsWhiteSpace(nombre[0]))
            {
                
                    StringBuilder nombreLetra = new StringBuilder(nombre);
                    nombreLetra.Remove(0,1);
                    nombre = nombreLetra.ToString();
               
            }
            else if (char.IsWhiteSpace(nombre[tamanio]))
            {
                StringBuilder nombreLetra = new StringBuilder(nombre);
                nombreLetra.Remove(tamanio,1);
                nombre = nombreLetra.ToString();
            }
            for (int i = 0; i < nombre.Length; i++)
            {
                if(!(char.IsLetter(nombre[i])))
                {
                    StringBuilder nombreLetra = new StringBuilder(nombre);
                    nombreLetra.Remove(i,1);
                    nombre = nombreLetra.ToString();
                }
                
            }

            
        }
        public void normalizaApellido()
        {
            int tamanio = apellido.Length - 1;

            if (char.IsWhiteSpace(apellido[0]))
            {

                StringBuilder apellidoLetra = new StringBuilder(apellido);
                apellidoLetra.Remove(0, 1);
                apellido = apellidoLetra.ToString();

            }
            else if (char.IsWhiteSpace(apellido[tamanio]))
            {
                StringBuilder apellidoLetra = new StringBuilder(apellido);
                apellidoLetra.Remove(tamanio, 1);
                apellido = apellidoLetra.ToString();
            }
            for (int i = 0; i < apellido.Length; i++)
            {
                if (!(char.IsLetter(apellido[i])))
                {
                    StringBuilder apellidoLetra = new StringBuilder(apellido);
                    apellidoLetra.Remove(i, 1);
                    apellido = apellidoLetra.ToString();
                }

            }
        }
           


    }
}
