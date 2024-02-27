using ScreenSound.DAL;
using ScreenSound.Model;

namespace screenSound.DAL{
    internal class BandDal:GenericDal<BandsModel>{
        public BandDal(ScreenSoundContext context):base(context){}
    }
}