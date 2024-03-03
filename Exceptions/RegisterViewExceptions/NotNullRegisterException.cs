using ScreenSound.Exceptions;

namespace ScreenSound.RegisterExceptions{
    public class NotNullRegisterException:Exception{
        public NotNullRegisterException(){
            GenericException.ClearTheCurrentLine();

            System.Console.WriteLine("The new register cannot be null");

            GenericException.PutToSleep();

            GenericException.ClearTheCurrentLine();
        }
    }
}