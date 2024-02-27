using ScreenSound.DAL;
using ScreenSound.Model;

namespace ScreenSound.DAL{
    internal class SongsDal:GenericDal<SongsModel>{
        public SongsDal(ScreenSoundContext context):base(context){}
    }
}