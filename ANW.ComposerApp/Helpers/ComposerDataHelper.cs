using ANW.ComposerApp.Interfaces;
using ANW.ComposerApp.Models;
using System.Collections.Generic;

namespace ANW.ComposerApp.Helpers
{
    public class ComposerDataHelper : IComposerDataHelper
    {
        public IEnumerable<Composer> GetComposerData()
        {
            /**************************************************
            *For the sake of the test I am interfacing the 
            *static list off into a helper to simulate accessing
            *an external data source such as a database or
            *web service.
            *
            *In reality I could just have used the ComposerRepo
            *class as a model and done everything off that but
            *that probably wouldn't have given you any useful
            *hints about how I actually code.             
            ****************************************************/
            return ComposerRepo.Composers;
        }
    }
}