using System.Runtime.InteropServices;

namespace ScreenSound.View.RegisterViews{
    internal class GenericRegisterView{
        protected string? LinesSeparation => "==================================================="; // Separation
        protected string? registerName; // have the name of the register

        public GenericRegisterView(string titleMenuName){
            this.registerName = titleMenuName;
        }

        protected void ShowRegistersName(){
            System.Console.WriteLine(this.LinesSeparation);

            System.Console.WriteLine(this.registerName);

            System.Console.WriteLine(this.LinesSeparation);
        }
        
    }
}