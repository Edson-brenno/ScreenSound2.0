using ScreenSound.DAL;
using ScreenSound.Model;

namespace screenSound.DAL{
    internal class BandsDal:GenericDal<BandsModel>{
        public BandsDal(ScreenSoundContext context):base(context){}
    }
}