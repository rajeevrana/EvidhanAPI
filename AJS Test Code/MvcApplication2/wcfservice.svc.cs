using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Activation;
using System.Text;

namespace MvcApplication2
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "wcfservice" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select wcfservice.svc or wcfservice.svc.cs at the Solution Explorer and start debugging.
     [AspNetCompatibilityRequirements(RequirementsMode = AspNetCompatibilityRequirementsMode.Allowed)]
    public class wcfservice : Iwcfservice
    {
        public void DoWork()
        {
        }
    }
}
