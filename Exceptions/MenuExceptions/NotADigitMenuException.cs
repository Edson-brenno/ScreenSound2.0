using ScreenSound.Exceptions;

namespace ScreenSound.MenuExceptions{
    internal class NotADigitMenuException:Exception{
        public NotADigitMenuException(){
            GenericException.ClearTheCurrentLine();

            System.Console.WriteLine("The menu option cannot be letter or special characters");

            GenericException.PutToSleep();

            GenericException.ClearTheCurrentLine();
        }
    }
}