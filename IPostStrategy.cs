using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicFacebookFeatures
{
    public interface IPostStrategy
    {
        void Post(string postContent, FacebookFacade facebookFacade);
    }
}
