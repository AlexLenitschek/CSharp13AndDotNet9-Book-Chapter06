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
            // Default Implementation - Looked down upon, so avoid if possible.
            WriteLine("Default implementation of Stop.");
        }
    }
}
