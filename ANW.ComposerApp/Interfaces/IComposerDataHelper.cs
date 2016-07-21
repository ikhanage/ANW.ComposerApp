using ANW.ComposerApp.Models;
using System.Collections.Generic;

namespace ANW.ComposerApp.Interfaces
{
    public interface IComposerDataHelper
    {
        IEnumerable<Composer> GetComposerData();
    }
}
