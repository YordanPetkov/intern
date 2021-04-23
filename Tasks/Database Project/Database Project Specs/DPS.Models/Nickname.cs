using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DPS.Models
{
    public class Nickname
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public virtual Author Author { get; set; }
    }
}