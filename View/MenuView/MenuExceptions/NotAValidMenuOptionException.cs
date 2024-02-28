namespace ScreenSound.MenuExceptions{
    internal class NotAValidMenuOptionException{
        public NotAValidMenuOptionException(){
            GenericMenuException.ClearTheCurrentLine();

            System.Console.WriteLine("Not a valid option");

            GenericMenuException.PutToSleep();

            GenericMenuException.ClearTheCurrentLine();
        }
    }
}