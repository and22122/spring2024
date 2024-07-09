using System;

class Program
{
    static void Main(string[] args)
    {
        List<Video> videos = new List<Video>();
        videos.Add(new Video("Channel Pilot", "YouTubeWarlord0123", 300));
        videos.Add(new Video("Let's Get Down To Business", "YouTubeWarlord0123", 150));
        videos.Add(new Video("Q&A #1", "YouTubeWarlord0123", 1800));
        videos.Add(new Video("Never Gonna Give You Up", "Rick Astley Topic", 213));

        videos[0]._comments.Add(new Comment("YouTube101", "Frist comment /edit: first, not frist"));
        videos[0]._comments.Add(new Comment("MLPFan227", "What an awesome video! Can't wait!"));
        videos[0]._comments.Add(new Comment("B1gg3stTr0113v3r", "Trolololololololol"));

        videos[1]._comments.Add(new Comment("Y0M@m@394", "I came here looking for the Disney song"));
        videos[1]._comments.Add(new Comment("YouTube101", "First no wait"));
        videos[1]._comments.Add(new Comment("MLPFan227", "Another awesome vido!"));
        videos[1]._comments.Add(new Comment("B1gg3stTr0113v3r", "Trololrlololol"));
        
        videos[2]._comments.Add(new Comment("YouTubeWarlord0123", "Pinned by YouTubeWarlord0123: It's finally here: my first Q&A sesion"));
        videos[2]._comments.Add(new Comment("B1gg3stTr0113v3r", "Trololololololl"));
        videos[2]._comments.Add(new Comment("MLPFan227", "What's next?"));
        videos[2]._comments.Add(new Comment("FurryFriend314", "Can someone please do something about B1gg3stTr0113v3r?"));
        videos[2]._comments.Add(new Comment("RAFan01946", "Guys heres a link to the BEST VIDEO EVER https://www.youtube.com/watch?v=dQw4w9WgXcQ"));

        videos[3]._comments.Add(new Comment("RAFan01046", "This is seriously the best video ever"));
        videos[3]._comments.Add(new Comment("R2nd0mN00b346", "Please someone delete this off the face of the earth"));
        videos[3]._comments.Add(new Comment("B1gg3stTr0113v3r", "This vidweo sucks shar it with all hyor friends"));

        videos[2]._comments[2] = new Comment("Admin", "This comment was deleted.");

        foreach (Video v in videos)
        {
            Console.WriteLine($"{v._title}\nPosted by {v._user}\n{v._duration} seconds long\n\n{v.countComments} comments:");

            foreach (Comment c in v._comments)
            {
                Console.WriteLine($"{c._poster}:\t{c._message}");
            }
        }
    }
}