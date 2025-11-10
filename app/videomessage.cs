public class VideoMessage : MessageBase
{
    public string FilePath { get; set; }
    public string Format { get; set; }
    public int Duration { get; set; }

    public VideoMessage(string message)
        : base(message)
    {
        FilePath = "video.mp4";
        Format = "mp4";
        Duration = 30;
    }
}
