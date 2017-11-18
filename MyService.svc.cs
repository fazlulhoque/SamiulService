using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace SamiulService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "MyService" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select MyService.svc or MyService.svc.cs at the Solution Explorer and start debugging.
    public class MyService : IMyService
    {
        #region IRestService Members

        public string XMLData(string id)
        {
            return "Your requested product" + id;
        }


        public string JSONData(string id)
        {
            return "Your requested product" + id;
        }

        #endregion
    }
}
