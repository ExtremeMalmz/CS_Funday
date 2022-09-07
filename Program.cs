//Eric Malmström 
using System;

using Petspace;
using TicketSpace;
using AlbumSpace;

namespace themain
{
    class Pet
    {
        // Main Method 
        static void Main(string[] args)
        {
            Pets petss = new Pets();
            petss.set_name();
            petss.set_age();
            petss.set_isFemale();
            petss.printOut();

            Console.WriteLine("\nPress enter for the next part");
            Console.ReadLine();

            TicketSeller ticketseller = new TicketSeller();
            ticketseller.set_name();
            ticketseller.set_numOfAdults();
            ticketseller.set_numOfChildren();
            ticketseller.print_reciept();

            Console.WriteLine("\nPress enter for the next part");
            Console.ReadLine();
            
            Album album = new Album();
            album.set_albumName();
            album.set_artistName();
            album.set_numOfTracks();
            album.print_everything();
        }
    }
}