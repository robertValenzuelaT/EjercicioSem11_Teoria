using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace EjercicioSem11_Teoria.Models
{
    [Table("producto")]
    public class Producto
    {
        public int Id {get;set;}
        [Required]
        public string NomProd {get;set;}
        [Required]
        public decimal Precio {get;set;}
        [Required]
        public string UrlFoto {get;set;}
        [Required]
        public string Descripcion {get;set;}
        [Required]
        public string Comprador {get;set;}
        [Required]
        public string TelfComp {get;set;}
        [Required]
        public string Lugar {get;set;}

        public DateTime FechaReg {get; set;}

        public Categoria Categoria{get;set;}
        public int CategoriaId {get;set;}
        
        
        public Producto(){

            FechaReg = DateTime.Now;
        }
        
    }
}