namespace ScreenSound.DAL{

    //Class where You'll find the comons methods between dal classes
    internal class GenericDal <T> where T : class{

        protected readonly ScreenSoundContext context;

        public GenericDal(ScreenSoundContext screenSoundContext):base(){
            this.context = screenSoundContext;
        }

    }
}