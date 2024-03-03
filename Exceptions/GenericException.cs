namespace ScreenSound.Exceptions{
    internal class GenericException{
        public static void ClearTheCurrentLine(){ // Clear the current line

            System.Console.SetCursorPosition(0,Console.CursorTop - 1);

            System.Console.WriteLine(new string(' ', Console.WindowWidth));

            System.Console.SetCursorPosition(0,Console.CursorTop - 1);
            
        }

        public static void PutToSleep(){ // Put to sleep
            Thread.Sleep(2500);
        }
    }
}