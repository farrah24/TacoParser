namespace LoggingKata
{
    public interface ITrackable
    {
        string GetName();
        void SetName(string value);

        Point Location { get; set; }
    }
}