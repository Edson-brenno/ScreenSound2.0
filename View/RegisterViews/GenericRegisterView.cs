using System.Runtime.InteropServices;

namespace ScreenSound.View.RegisterViews{
    internal class GenericRegisterView{
        protected string? LinesSeparation => "==================================================="; // Separation
        protected string? registerName; // have the name of the register

        public GenericRegisterView(string titleMenuName){
            this.registerName = titleMenuName;
        }

        protected void ShowRegistersName(){ // Print Apresentation of Register Name
            System.Console.WriteLine(this.LinesSeparation);

            System.Console.WriteLine(this.registerName);

            System.Console.WriteLine(this.LinesSeparation);
        }

        protected virtual void ClearTheCurrentLine(){ // Clear the current line

            System.Console.SetCursorPosition(0,Console.CursorTop - 1);

            System.Console.WriteLine(new string(' ', Console.WindowWidth));

            System.Console.SetCursorPosition(0,Console.CursorTop - 1);
        }
        
    }
}