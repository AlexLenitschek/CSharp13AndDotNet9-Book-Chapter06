using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PacktLibrary
{
    internal interface IPlayable
    {
        void Play();
        void Pause();
        void Stop()
        {
            // Default Implementation
            WriteLine("Default implementation of Stop.");
        }
    }
}
