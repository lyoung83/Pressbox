using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Pressbox.Models;

namespace Pressbox.ViewModels
{
    class GameViewModel : IPlayHistory
    {
        private readonly Plays _plays;
        private readonly Defense _defense;

        public Plays Play {
            get { return _plays; }

            set { Play = value; }
        }

        public Defense Defend
        {
            get { return _defense; }
            set { Defend = value; }
        }
        
        public string lastPlay
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

        public string lastResult
        {
            get
            {
                Play.playResult();
                throw new NotImplementedException();
            }

            set
            {
                Play.playResult();
                throw new NotImplementedException();
            }
        }

        public string tackleMade
        {
            get
            {
                Defend.Player();
                throw new NotImplementedException();
            }

            set
            {
                Defend.Player();
                throw new NotImplementedException();
            }
        }
    }
}
