using ScreenSound.DAL;
using ScreenSound.Model;

namespace ScreenSound.DAL{
    internal class AlbumsDal:GenericDal<AlbumsModel>{
        public AlbumsDal(ScreenSoundContext context):base(context){}
    }
}