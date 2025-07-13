namespace MusicLibrary
{
    public class Track
    {
        //You have to implement a class Track with the following properties:
        //Title - string
        //Artist - string
        //Duration – int (in seconds)
        //Genre - string
        public string Title { get; set; }
        public string Artist { get; set; }
        public int Duration { get; set; }
        public string Genre { get; set; }

        //The class constructor should receive title, artist, duration and genre.
        public Track(string title, string artist, int duration, string genre)
        {
            Title = title;
            Artist = artist;
            Duration = duration;
            Genre = genre;
        }

        //Override the ToString() method in the following format:
        //"Track: '{Title}' by {Artist} - {Duration}s [{Genre}]"
        public override string ToString()
        {
            return $"Track: '{Title}' by {Artist} - {Duration}s [{Genre}]";
        }
    }
}
