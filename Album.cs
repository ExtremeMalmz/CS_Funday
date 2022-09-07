//Eric Malmström 
using System;
using System.IO;
using System.Text;

namespace AlbumSpace
{
    class Album
    {
        // Album name, artist name, and number of tracks
        private string albumName;
        private string artistName;
        private int numOfTracks;

        public Album()
        //constructor
        {
            Console.WriteLine("\nStarting the Album Program!\n");
            this.albumName = "";
            this.artistName = "";
            this.numOfTracks = 0;
        }

        public void set_albumName()
        //sets album name to string
        {
            Console.WriteLine("What is the name of your favourite music album?");
            this.albumName = Console.ReadLine();
        }

        public void set_artistName()
        //sets artist name to string
        {
            Console.WriteLine("What is the name of the Artist or Band for " + this.albumName + "?");
            this.artistName = Console.ReadLine();
        }

        public void set_numOfTracks()
        //sets number of tracks to an int
        {
            Console.WriteLine("How many tracks does " + this.albumName + " have?");
            this.numOfTracks = Convert.ToInt32(Console.ReadLine());
        }

        public void print_everything()
        //prints out all the private variables in a formatted way
        {
            Console.WriteLine("\nAlbum name:" + this.albumName);
            Console.WriteLine("Artist/Band: " + this.artistName);
            Console.WriteLine("Number of tracks: " + this.numOfTracks);
            Console.WriteLine("Enjoy listening!");
        }
    }
}