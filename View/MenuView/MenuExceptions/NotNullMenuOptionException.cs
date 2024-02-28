namespace ScreenSound.MenuExceptions{

    internal class NotNullMenuOptionException:Exception{
        public NotNullMenuOptionException(){

            GenericMenuException.ClearTheCurrentLine();

            System.Console.WriteLine("The menu option cannot be null");

            GenericMenuException.PutToSleep();

            GenericMenuException.ClearTheCurrentLine();
        }
    }
}