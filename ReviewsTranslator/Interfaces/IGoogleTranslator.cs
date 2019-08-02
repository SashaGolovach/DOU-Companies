using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ReviewsTranslator.Interfaces
{
    public interface IGoogleTranslator
    {
        bool IsNotTranslated(string text);
        Task<string> Translate(string text);
    }
}
