using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pressbox.Models
{
    public class PlayHistory : IPlayHistory
    {
        public string lastPlay { get; set; }
        public string lastResult { get; set; }
        public string tackleMade { get; set; }
    }
}
