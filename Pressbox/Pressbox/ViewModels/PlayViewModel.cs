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
        private readonly IPlay _play;
        private readonly IPlayer _player;

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

        public IPlayer Player
        {
            get
            {
                return _player;
            }

            set
            {
                Player = value;
            }
        }
        public string playCall
        {
            get
            {
                return Play.playName;
                throw new NotImplementedException();
            }

            set
            {
                Play.playName = value;
                throw new NotImplementedException();
            }
        }

        public string playResult
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

        public string playType
        {
            get
            {
                return Play.playType;
                throw new NotImplementedException();
            }

            set
            {
                Play.playType = value;
                throw new NotImplementedException();
            }
        }

        public string[] tackledBy
        {
           
            get
            {
                return Player;
                throw new NotImplementedException();
            }

            set
            {
                Player = value;
                throw new NotImplementedException();
            }
        }
    }
}