using System;
using System.Collections.Generic;
using System.Text;

namespace MusicPlayer.Model
{
    public class MainModel
    {
        public string Name { get; set; }
        public override string ToString()
        {
            return Name;
        }
    }
}
