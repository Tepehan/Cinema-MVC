using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
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
        public int parentId { get; set; }
        public virtual Menu parent { get; set; }
        public ICollection<Menu> children { get; set; }
    }
}