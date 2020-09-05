using System;
using System.Collections.Generic;
using System.Text;

namespace ClassesLibrary
{
    public class Song
    {

        private string _artist;
        private string _title;
        private int _lengthInSeconds;

        public string Artist { get; set; }
        public string Title { get; set; }
        public int LengthInSeconds { get; set; }

        public Song(string artist, string title, int lengthInSeconds)
        {
            Artist = artist;
            Title = title;
            LengthInSeconds = lengthInSeconds;
        }

        public Song() { }

        public override string ToString()
        {
            return string.Format("\nArtist: {0}\nTitle: {1}\nLength in seconds: {2}",
                Artist,
                Title,
                LengthInSeconds);
        }


    }//end class
}//end namespace
