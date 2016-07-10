using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pressbox.Models
{
    class Plays
    {
        public int playId { get; set; }
        public string playName { get; set; }
        public void playType ()
        {
            List < string > play = new List<string>();
            play.Add("Run");
            play.Add("Pass");
            play.Add("Counter");
        }
    }
}
