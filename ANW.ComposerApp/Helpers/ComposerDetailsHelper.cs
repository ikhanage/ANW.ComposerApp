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

        public IDictionary<int, string> GetComposersNames()
        {
            var composers = _dataHeleper.GetComposerData();
            
            return composers.ToDictionary(x => x.Id, x => string.Format("{0} {1}", x.FirstName, x.LastName));
        }

        public Composer GetComposer(int id)
        {
            var composerData = _dataHeleper.GetComposerData();

            return composerData.Single(x => x.Id == id);
        }
    }
}