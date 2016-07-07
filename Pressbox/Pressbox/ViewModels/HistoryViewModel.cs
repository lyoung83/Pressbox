using Pressbox.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pressbox.ViewModels   
{
   public class HistoryViewModel:IPlayHistory
    {
        private readonly IPlay _play;

        public IPlay Play
        {
            get
            {
                return _play;
            }
            set
            {
                Play = value;
            }
        }

        public int madeTackle
        {
            get
            {
                throw new NotImplementedException();
            }

            set
            {
                throw new NotImplementedException();
            }
        }

      
        

       
        

        public string playCalled
        {
            get
            {
                return Play.playName;
                throw new NotImplementedException();
            }

            set
            {
                playCalled = value;
                throw new NotImplementedException();
            }
        }


        public int resultFreq
        {
            get
            {
                throw new NotImplementedException();
            }

            set
            {
                throw new NotImplementedException();
            }
        }
    }
}