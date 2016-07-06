
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pressbox.Models
{ // Current play information to update history is recorded PlayHistory model.


    class CurrentPlay : ICurrentPlay
    {
        public string playCall { get; set; }
        public string tackledBy { get; set; }
        public string playResult { get; set; }
        public string playType { get;  set; }
    }
}
