using System.IO.Compression;

namespace ScreenSound.DAL{

    //Class where You'll find the comons methods between dal classes
    internal class GenericDal <T> where T : class{

        protected readonly ScreenSoundContext context;

        public GenericDal(ScreenSoundContext screenSoundContext):base(){
            this.context = screenSoundContext;
        }

        //Method to insert the data
        public void Insert(T tObject){
            
            this.context.Set<T>().Add(tObject);
            this.context.SaveChanges();
        }

        //Method to Update the data
        public void Update(T tObject){
            this.context.Set<T>().Update(tObject);
            this.context.SaveChanges();
        }

        //Method to delete the data
        public void Delete(T tObject){
            this.context.Set<T>().Remove(tObject);
            this.context.SaveChanges();
        }

    }
}