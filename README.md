# Reddit Random (Package)
![Workflow Build](https://img.shields.io/github/workflow/status/Schufeli/reddit-random/.NET?label=.NET%20build)
![CodeFactor Grade](https://img.shields.io/codefactor/grade/github/schufeli/reddit-random/main?label=CodeFactor%20Grade)
![NuGet Version](https://img.shields.io/nuget/v/RedditRandom?label=NuGet)
![License](https://img.shields.io/github/license/schufeli/reddit-random?label=License)

Reddit Random is a NuGet Package to fetch a random Post from any requested Subreddit. Written in C# and built on .net5.0.

## 📦 Installation

The installation is rather simple because it is listed on NuGet.org. You can use the NuGet Package manager in Visual Studio or download it via the CLI.

```
PM> Install-Package RedditRandom
```

## 🚀 How to use
__Please note, for the Service to function properly you will need to provide a valid Reddit Access token with at least the read scope.__

If you need to know how to get a Reddit Access token please consult this [Guide](https://github.com/reddit-archive/reddit/wiki/OAuth2) 

**Important Information (please read)!!**

Because the used Reddit API Endpoint doesn't send any Ratelimiting information back. There is currently no possible resource-saving way to handle the Rate limits. So you will need to do this on your own in your application. The easiest way would be to just allow a request every second or implementing some kind of delay (60 Request per minute allowed by Reddit). It will be added as soon as there is a solution or workaround.

### Request a Post
To fetch a Post you can use this example code or check out the Example Client Project in this Repository.

```csharp
var acccessToken = ""; // Reddit Accesstoken
var useragent = ""; // Self defined Useragent
var subreddit = ""; // Desired subreddit to fetch from

WebAgent agent = new WebAgent(acccessToken, useragent);

var request = agent.CreateRequest(subreddit);
var response = await agent.GetResponseAsync(request);
var jsonString = await response.Content.ReadAsStringAsync();

var model = JsonConvert.DeserializeObject<List<Root>>(jsonString);

var post = ResponseFactory.CreateResponseFromPost(model?[0].Data.Children[0].Post);
```

To see a full implementation visit this [Project](https://github.com/Schufeli/reddit-random-service)
