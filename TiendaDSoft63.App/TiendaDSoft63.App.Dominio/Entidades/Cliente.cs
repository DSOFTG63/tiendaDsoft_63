using System;

namespace TiendaDSoft63.App.Dominio{

    //Modela el Cliente que está registrado en el sistema
    public class Cliente: Persona{
        //Identificador único de Cliente
        public string IdCliente {get; set;}
        //Relación entre Cliente y Tienda
        public Tienda Tiendas {get; set;}
        //Relación entre Cliente y Producto
        public Producto Productos {get; set;}        
    }
    
}