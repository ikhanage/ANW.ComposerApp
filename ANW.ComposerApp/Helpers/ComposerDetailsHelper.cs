using ANW.ComposerApp.Interfaces;
using ANW.ComposerApp.Models;
using System.Collections.Generic;
using System.Linq;

namespace ANW.ComposerApp.Helpers
{
    public class ComposerDetailsHelper: IComposerDetailsHelper
    {
        private readonly IComposerDataHelper _dataHeleper;
        public ComposerDetailsHelper(IComposerDataHelper dataHelper)
        {
            _dataHeleper = dataHelper;
        }

        public IEnumerable<Composer> GetComposersNames()
        {
            return _dataHeleper.GetComposerData();
        }

        public Composer GetComposer(int id)
        {
            var composerData = _dataHeleper.GetComposerData();

            return composerData.Single(x => x.Id == id);
        }
    }
}