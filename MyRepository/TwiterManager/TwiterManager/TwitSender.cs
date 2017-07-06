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
    class TwitSender
    {
         ////за допомогою бібліотеки Tweetinvi/ див. тех. документацію до бібліотеки.

        public void SendTwit(string t )
        {
            Auth.SetUserCredentials("bFpwNVET5XU6VZPyvQdJKt43M",
                "fdUxYH7bgVuQlcIokngefdAG1sbeVLVziynBnklxnct85PzOn8",
                "883009536742830081-Y98Re1i3jveIhM45bHe0fKYeKHmpiAb",
                "u1mHZ8lgbO1V7dzkpxE5GDjYKPd1BjppSSBaVyGJbl3Lz");
            var user = User.GetAuthenticatedUser();
            var tweet = Tweet.PublishTweet(t);
            
        }




    }
}
