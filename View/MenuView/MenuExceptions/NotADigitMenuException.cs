namespace ScreenSound.MenuExceptions{
    internal class NotADigitMenuException:Exception{
        public NotADigitMenuException(){
            GenericMenuException.ClearTheCurrentLine();

            System.Console.WriteLine("The menu option cannot be letter or special characters");

            GenericMenuException.PutToSleep();

            GenericMenuException.ClearTheCurrentLine();
        }
    }
}