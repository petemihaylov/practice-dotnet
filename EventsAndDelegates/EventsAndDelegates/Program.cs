using System;

namespace EventsAndDelegates
{
    class Program
    {
        static void Main(string[] args)
        {
            Video video = new Video { Title = "Video 1"};
            var videoEncoder = new VideoEncoder(); // publisher
            var mail = new MailService(); // subscriber
            var text = new TextService(); // subscriber

            videoEncoder.VideoEncoded += mail.OnVideoEncoded;
            videoEncoder.VideoEncoded += text.OnVideoEncoded;
            

            videoEncoder.Encode(video);

        }

    }
}
