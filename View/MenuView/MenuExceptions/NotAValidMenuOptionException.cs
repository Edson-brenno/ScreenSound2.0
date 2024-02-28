namespace ScreenSound.MenuExceptions{
    internal class NotAValidMenuOptionException:Exception{
        public NotAValidMenuOptionException(){
            GenericMenuException.ClearTheCurrentLine();

            System.Console.WriteLine("Not a valid option");

            GenericMenuException.PutToSleep();

            GenericMenuException.ClearTheCurrentLine();
        }
    }
}