using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pressbox.Models
{
  public  class Player : IPlayer
    {
       public string DLine { get; set; }
       public string LineBacker { get; set; }
        public string Secondary { get; set; }
    }
}
