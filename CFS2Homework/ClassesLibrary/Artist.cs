using System;
using System.Collections.Generic;
using System.Text;

namespace ClassesLibrary
{
    public class Artist
    {
        private Song[] _tracks;
        private string _title;
        private string _genre;

        public Song[] Tracks { get; set; }
        public string Title { get; set; }
        public string Genre { get; set; }

        public Artist(Song[] tracks, string title, string genre)
        {
            Tracks = tracks;
            Title = title;
            Genre = genre;
        }

        public Artist() { }

        public override string ToString()
        {
            string songsArray = "";

            foreach (Song song in Tracks)
            {
                songsArray += song + "\n";
                Console.WriteLine(song);
            }
            return string.Format("\nTracks: {0}\nTitle: {1}\nGenre: {2}",
                songsArray,
                Title,
                Genre);
        }
    }//end class
}//end Namespace
