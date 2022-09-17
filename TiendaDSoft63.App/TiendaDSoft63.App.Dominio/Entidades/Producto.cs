using System;

namespace TiendaDSoft63.App.Dominio{

    //Modela el producto en el sistema
    public class Producto{

        //Identificador único de Producto en el sistema
        public string IdProducto {get;set;}
        //Valor del producto en la tienda
        public int Precio {get;set;}
        //Tipo del Producto 
        public Tipo Tipo {get;set;} //Moda, Caminar y Deporte
    }
}