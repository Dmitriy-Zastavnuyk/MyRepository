using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using Tweetinvi;


namespace TwiterManager
{
    class TweetHepler
    {
        ////за допомогою бібліотеки Tweetinvi/ див. тех. документацію до бібліотеки.
        private Tweetinvi.Models.IAuthenticatedUser CurrUser ;

        

        public TweetHepler()
        {
            Auth.SetUserCredentials("bFpwNVET5XU6VZPyvQdJKt43M",
                "fdUxYH7bgVuQlcIokngefdAG1sbeVLVziynBnklxnct85PzOn8",
                "883009536742830081-Y98Re1i3jveIhM45bHe0fKYeKHmpiAb",
                "u1mHZ8lgbO1V7dzkpxE5GDjYKPd1BjppSSBaVyGJbl3Lz");
            CurrUser = User.GetAuthenticatedUser();
        }

        public void SendTweet(string t)
        {
            
            var tweet = Tweet.PublishTweet(t);
        }

        public IEnumerable<Tweetinvi.Models.ITweet> GetTweet()
        {
            
            var timeline = Timeline.GetUserTimeline(CurrUser , 1);
            
            return timeline;
        }



    }
}
