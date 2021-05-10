using Newtonsoft.Json;
using RedditRandom;
using RedditRandom.Models;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace RedditRandomExampleClient
{
    class Program
    {
        static async Task Main(string[] args)
        {
            var acccessToken = ""; // Reddit Accesstoken
            var useragent = ""; // Self defined Useragent
            var subreddit = ""; // Desired subreddit to fetch from

            WebAgent agent = new WebAgent(acccessToken, useragent);

            var request = agent.CreateRequest(subreddit);
            var response = await agent.GetResponseAsync(request);
            var jsonString = await response.Content.ReadAsStringAsync();

            var model = JsonConvert.DeserializeObject<List<Root>>(jsonString);

            var post = ResponseFactory.CreateResponseFromPost(model?[0].Data.Children[0].Post);

            Console.WriteLine(post.Title);
        }
    }
}
