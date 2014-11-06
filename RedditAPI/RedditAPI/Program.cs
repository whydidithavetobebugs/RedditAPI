using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RedditSharp;

namespace RedditAPI
{
    class Program
    {
        static void Main(string[] args)
        {
            var reddit = new Reddit();
            var user = reddit.LogIn("Paramnesia1", "taurine1");
            var subreddit = reddit.GetSubreddit("/r/formula1");
            Console.Write(subreddit.Description);
            Console.Read();

        }
    }
}
