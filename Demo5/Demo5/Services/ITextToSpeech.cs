using System;
using System.Collections.Generic;
using System.Text;

namespace Demo5.Services
{
    public interface ITextToSpeech
    {
        void Speak(string text);
    }
}
