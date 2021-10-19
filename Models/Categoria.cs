using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;

namespace EjercicioSem11_Teoria.Models
{
    [Table("categoria")]
    public class Categoria
    {
        public int Id {get;set;}
        public string DescCat {get;set;}
        public ICollection<Producto> Productos {get;set;}
    }
}