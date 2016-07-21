using ANW.ComposerApp.Models;
using System.Collections.Generic;

namespace ANW.ComposerApp.Interfaces
{
    public interface IComposerDetailsHelper
    {
        IEnumerable<Composer> GetComposersNames();
        Composer GetComposer(int id);
    }
}
