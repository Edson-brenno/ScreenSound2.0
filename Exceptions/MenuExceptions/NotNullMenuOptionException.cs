using ScreenSound.Exceptions;

namespace ScreenSound.MenuExceptions{

    internal class NotNullMenuOptionException:Exception{
        public NotNullMenuOptionException(){

            GenericException.ClearTheCurrentLine();

            System.Console.WriteLine("The menu option cannot be null");

            GenericException.PutToSleep();

            GenericException.ClearTheCurrentLine();
        }
    }
}