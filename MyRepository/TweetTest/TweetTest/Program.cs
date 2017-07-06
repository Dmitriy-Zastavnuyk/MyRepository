using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tweetinvi;

namespace TweetTest
{
    class Program
    {
        static void Main(string[] args)
        {
            Auth.SetUserCredentials("LLZ1Xc20IS1sIqYwUkLzRB7b1", "kfO9cz0WSRhjLwQS5Y80Hzbu4wnsDEHAthVMsWPymgQtj3vtYz",
                "883009536742830081-yYwmdpnBD3XoAV9sxcr640mmOG6w2Db", "wCelN0qCr5EGX7uMrPE77mUvCloCCFaXsuGXzvmfHKGgj");
            var user = User.GetAuthenticatedUser();
            Debug.WriteLine(user.ScreenName);

            Console.WriteLine(user);
            Console.ReadKey();

            var tweet = Tweet.PublishTweet("test1");
            var tweet1 = Tweet.PublishTweet("test2");
            var tweet2 = Tweet.PublishTweet("test3");
            var tweet3 = Tweet.PublishTweet("test4");
            var tweet4 = Tweet.PublishTweet("test5");
            var tweet5 = Tweet.PublishTweet("test6");

            var tweettimeline = Timeline.GetUserTimeline(user);

            foreach (var t in tweettimeline)
            {
                Console.WriteLine(t);
            }




        }
    }
}
