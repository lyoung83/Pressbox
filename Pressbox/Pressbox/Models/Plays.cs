using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pressbox.Models
{
  public  class Plays
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
        public void playResult()
        {
            List<string> result = new List<string>();
            result.Add("Loss");
            result.Add("No Gain");
            result.Add("Short Gain");
            result.Add("Medium Gain");
            result.Add("Long Gain");
            result.Add("Explosion");
            result.Add("TD");
        }
    }
}
