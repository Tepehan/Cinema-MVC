using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.Concrete
{
    public class Menu
    {
        [Key]
        public int menuId { get; set; }
        public string menuName { get; set; }
        [ForeignKey("parent")]
        
        public int? parentId { get; set; }
        public virtual Menu parent { get; set;}
        [InverseProperty("parent")]
        public bool durum { get; set; }

        public ICollection<Menu> children { get; set; }
    }
}
