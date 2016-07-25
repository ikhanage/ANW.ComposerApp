using ANW.ComposerApp.Models;
using System.Collections.Generic;

namespace ANW.ComposerApp.Interfaces
{
    public interface IComposerDetailsHelper
    {
        IDictionary<int, string> GetComposersNames();
        Composer GetComposer(int id);
    }
}
