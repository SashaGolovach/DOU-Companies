using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ReviewsTranslator.Interfaces
{
    public interface IGoogleTranslator
    {
        Task<string> Translate(string text);
        Task<string> Analyse(string text);
    }
}
