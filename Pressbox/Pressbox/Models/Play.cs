using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pressbox.Models
{
   public abstract class Play : IPlay
    {
        public string playName { get; set; }
        public string playType { get; set; }
        public int playNum { get; set; }
    }
}
