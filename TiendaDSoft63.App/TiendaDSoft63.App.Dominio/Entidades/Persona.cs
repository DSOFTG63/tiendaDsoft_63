using System;

namespace TiendaDSoft63.App.Dominio{
    
    //Modela una persona en el sistema
    public class Persona{

        //Identificador único de cada persona
        public string DocumentoIdentidad {get; set;}
        //Nombre completo de Persona
        public string Nombre {get; set;}
        //Dirección de residencia de Persona        
        public string Email {get; set;}
        //Genero de Persona
        public Genero Genero {get; set;}
        //Teléfono de Persona
        public int Telefono {get; set;}        
    }
    
}