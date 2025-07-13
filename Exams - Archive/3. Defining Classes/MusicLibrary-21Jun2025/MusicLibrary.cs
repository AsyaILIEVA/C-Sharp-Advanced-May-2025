using Microsoft.VisualBasic;
using MusicLibrary;
using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Reflection.PortableExecutable;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Xml.Linq;

namespace MusicLibrary
{
    public class MusicLibrary
    {
        //Next, you have to implement a class MusicLibrary that stores tracks(a List that stores the entity Track).
        //All entities inside the repository have the same properties.The MusicLibrary class should have the following properties:
        //Name - string
        //Capacity – int (maximum number of tracks that can be stored)
        //Tracks – List<Track>

        //List<Track> tracks;
        public string Name { get; set; }
        public int Capacity { get; set; }
        public List<Track> Tracks { get; set; }

        //The class constructor should receive name and capacity, also it should initialize a new instance of Tracks.
        public MusicLibrary(string name, int capacity)
        {
            this.Name = name;
            this.Capacity = capacity;
            Tracks = new List<Track>();
        }

        //   Method AddTrack(Track track)
        //oAdds a track to the library if the total number of tracks does not exceed the Capacity
        //oDo not allow tracks with the same Title and Artist
        //If a duplicate is found or the capacity has been reached, skip the addition
        public void AddTrack(Track track)
        {
            if (Tracks.Count < Capacity
                && Tracks.All(t => t.Title != track.Title)
                && Tracks.All(t => t.Artist != track.Artist))
            {
                Tracks.Add(track);
            }
        }
        //     Method RemoveTrack(string title, string artist)
        //oRemoves a track based on its Title and Artist
        //Returns true if the track was successfully removed, otherwise false
        public bool RemoveTrack(string title, string artist)
        {
            if (Tracks.Any(t => t.Title == title))
            {
                Track removedTrack = Tracks.Where(t => t.Title == title).First();
                Tracks.Remove(removedTrack);
                return true;
            }
            else if (Tracks.Any(t => t.Artist == artist))
            {
                Track removedTrack = Tracks.Where(t => t.Artist == artist).First();
                Tracks.Remove(removedTrack);
                return true;
            }
            return false;
        }

        //      Method GetLongestTrack()
        //oReturns the Track with the longest Duration
        //You can assume that there will always be exactly one track corresponding that condition
        public Track GetLongestTrack()
        {
            Track longestTrack = Tracks.OrderByDescending(t => t.Duration).First();
            return longestTrack;
        }

//        Method GetTrackDetails(string title, string artist)
//oReturns the string representation information of the specific track, using the ToString() method
//oIf not found, return a string message: "Track not found!"
public string GetTrackDetails(string title, string artist)
        {
            // Search for the track that matches title and artist (case-insensitive)
            var track = Tracks.FirstOrDefault(t => t.Title == title && t.Artist == artist);
            
            if (track != null)
            {
                return track.ToString();
            }
            return "Track not found!";
        }
        

        //        Method GetTracksCount()
        //oReturns the total number of added tracks
        public int GetTracksCount() => Tracks.Count;

        //        Method GetTracksByGenre(string genre)
        //oReturns a List<Track> of all tracks matching the given genre
        //oThe returned files in the list should be ordered by Duration - ascending order
        //oYou can assume no two tracks will have the same Duration
        //oIf no matching tracks exist, return an empty list      


        public List<Track> GetTracksByGenre(string genre)
        {
            return Tracks
                .Where(t => t.Genre == genre)
                .OrderBy(t => t.Duration)
                .ToList();
        }


        //    Method LibraryReport()
        //oOrderes all tracks by their Duration – descending order
        //oReturns a formatted string with all tracks details
        //oEach record should appear on a new line
        //oThe report will be expected in the following format:

        //"Music Library: {Name}
        //Tracks capacity: {Capacity}
        //Number of tracks added: {Tracks.Count}

        //Tracks:
        //-{ track1.ToString()}
        //-{ track2.ToString()}
        //…
        //-{ trackn.ToString()}
        public string LibraryReport()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Music Library: {Name}");
            sb.AppendLine($"Tracks capacity: {Capacity}");
            sb.AppendLine($"Number of tracks added: {Tracks.Count}");
            sb.AppendLine("Tracks:");

            foreach (var track in Tracks.OrderByDescending(t => t.Duration))
            {
                sb.AppendLine($"-{track.ToString()}");
            }

            return sb.ToString().TrimEnd();
        }
    }
        
}
