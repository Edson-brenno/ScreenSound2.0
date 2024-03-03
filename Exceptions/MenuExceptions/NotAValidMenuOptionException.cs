using ScreenSound.Exceptions;

namespace ScreenSound.MenuExceptions{
    internal class NotAValidMenuOptionException:Exception{
        public NotAValidMenuOptionException(){
            GenericException.ClearTheCurrentLine();

            System.Console.WriteLine("Not a valid option");

            GenericException.PutToSleep();

            GenericException.ClearTheCurrentLine();
        }
    }
}