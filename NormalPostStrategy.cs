using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicFacebookFeatures
{
    public class NormalPostStrategy : IPostStrategy
    {

        public void Post(string postContent, FacebookFacade facebookFacade)
        {

            facebookFacade.PostStatus(postContent);
        }

    }
}
