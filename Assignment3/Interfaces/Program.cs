interface IAudio
{
  void PlayAudio();
}

interface IVideo
{
  void PlayVideo();
}

class NewsMedia : IAudio, IVideo
{
  public void newsBroadcast()
  {
    Console.WriteLine("Today's breaking news : ......");
  }
}

class Program
{
  static void Main(string[] args)
  {
    NewsMedia myNews = new NewsMedia();
    myNews.PlayVideo();
    myNews.PlayAudio();
  }
}
