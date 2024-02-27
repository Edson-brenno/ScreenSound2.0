using System.Reflection.Metadata.Ecma335;
using screenSound.DAL;
using ScreenSound.DAL;
using ScreenSound.Model;

namespace ScreenSound{
    public class ScreenSound{
        public static void Main(String[] args){
            ScreenSoundContext context = new ScreenSoundContext();

            //testing insert, update,delete and getby
            
            BandsDal bandsDal = new BandsDal(context);
            AlbumsDal albumsDal = new AlbumsDal(context);
            
            BandsModel? band = bandsDal.GetBy(a => a.Id == 1);
            AlbumsModel album = new AlbumsModel(){Id=4, Name="Black in Black 2", Band=band};

            //bandsDal.Insert(band);
            albumsDal.Update(album);
        } 
    }
}
