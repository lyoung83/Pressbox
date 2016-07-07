using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pressbox.Models
{ // The logic to update after current play information is entered.
    
    
    public class PlayHistory : Play, IPlayHistory
    {
        public string playCalled { get; set; }
        public int resultFreq { get; set; }
        public string madeTackle { get; set; }
    }
}
