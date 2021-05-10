# Reddit Random (Package)

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
To fetch a Post you can use this example code or check out the Example Client Project in this Repository
