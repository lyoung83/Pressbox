using Pressbox.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pressbox.ViewModels   
{
    class HistoryViewModel : IPlayHistory
    {
        CurrentPlay c = new CurrentPlay();
        public string madeTackle
        { 
            get
            {
               return c.tackledBy += 1;
                


                throw new NotImplementedException();
            }

            set
            {
                c.tackledBy = value;
                throw new NotImplementedException();
            }
        }

        public string playCalled
        {
            get
            {

               return  c.playCall;
                throw new NotImplementedException();
            }

            set
            {
                c.playCall = value;
                throw new NotImplementedException();
            }
        }

        public string resultFreq
        {
            get
            {
                return c.tackledBy += 1;
                throw new NotImplementedException();
            }

            set
            {
                c.tackledBy = value;
                throw new NotImplementedException();
            }
        }
    }

}