using System;
using System.Collections.Generic;
using SQLite;

//connessione al db 
SQLiteConnection cn1 = new SQLiteConnection("chinook.db");
var tblArtists = cn1.Query<ArrayTypeMismatchException>("select * from artists");
Console.WriteLine($"In questa tabella ci sono {tblArtists.Count} record!");

public class Artist
{

    public int ArtistId{get;set;}

    public string Name{get;set;}
}

namespace SQLQuery
{

    public static class Query {
        
        public static List<Record> tutti_gli_album() 
        {
            SQLiteConnection cn1 = new SQLiteConnection("chinook.db");
            List<Record> retVal = cn1.Query<Record>( "select * from albums" ); 

            return retVal;                        
        }

        public static List<Record> album_and_artist_in_order_of_album() 
        {
            SQLiteConnection cn1 = new SQLiteConnection("chinook.db");
            return null;                        
        }
        public static List<Record> album_and_artist_in_order_of_artist() 
        {
            SQLiteConnection cn1 = new SQLiteConnection("chinook.db");
            return null;                        
        }
        public static List<Record> album_and_number_of_tracks() 
        {
            SQLiteConnection cn1 = new SQLiteConnection("chinook.db");
            List<Record> retVal = cn1.Query<Record>( "select * from albums" ); 
            int x = retVal.Count;
            return null;                        
        }
        public static List<Record> artist_and_album() 
        {
            SQLiteConnection cn1 = new SQLiteConnection("chinook.db");
            return null;                        
        }
    }

    public class Record
    {
        public int AlbumId {get;set;} 
        public string Title {get;set;} 
        public int ArtistId {get;set;} 
        public string Name {get;set;} 
        public string NTracks {get;set;} 
        public string NAlbums {get;set;} 
    }
}