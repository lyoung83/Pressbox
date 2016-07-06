using Pressbox.Models;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Pressbox.ViewModels
{


    class PlayViewModel : ICurrentPlay
    {
      
        public string playCall
        { 

            get
            {
                return playCall;
                throw new NotImplementedException();
            }

            set
            {
                playCall = value;                                            
                throw new NotImplementedException();
            }
        }

        public string playResult
        {
            get
            {
                return playResult;
                throw new NotImplementedException();
            }

            set
            {
                playResult = value;
                throw new NotImplementedException();
            }
        }

        public string tackledBy
        {


            get
            {
                return tackledBy;
                throw new NotImplementedException();
            }

            set
            {
                tackledBy = value;
                throw new NotImplementedException();
            }
        }
    }
}
