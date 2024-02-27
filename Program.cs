using System.Reflection.Metadata.Ecma335;
using screenSound.DAL;
using ScreenSound.DAL;
using ScreenSound.Model;

namespace ScreenSound{
    public class ScreenSound{
        public static void Main(String[] args){
            ScreenSoundContext context = new ScreenSoundContext();

            BandsDal bandsDal = new BandsDal(context);

            BandsModel band = new BandsModel(){Name="AC-DC"};

            bandsDal.Insert(band);
        } 
    }
}
