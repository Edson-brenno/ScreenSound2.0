using System.ComponentModel;
using System.Runtime.InteropServices;

namespace ScreenSound.View.RegisterViews{
    internal class GenericRegisterView{
        protected string? LinesSeparation => "==================================================="; // Separation
        protected string? registerName; // have the name of the register

        protected string? typedRegister; // Have the what the user wants to add

        public GenericRegisterView(string titleMenuName){
            this.registerName = titleMenuName;
        }

        protected void ShowRegistersName(){ // Print Apresentation of Register Name
            System.Console.Clear();

            System.Console.WriteLine(this.LinesSeparation);

            System.Console.WriteLine(this.registerName);

            System.Console.WriteLine(this.LinesSeparation);
        }

        protected virtual void ClearTheCurrentLine(){ // Clear the current line

            System.Console.SetCursorPosition(0,Console.CursorTop - 1);

            System.Console.WriteLine(new string(' ', Console.WindowWidth));

            System.Console.SetCursorPosition(0,Console.CursorTop - 1);
        }

        protected virtual bool isNewRegisterValid(string? newRegister){ 
            if(String.IsNullOrEmpty(newRegister) || String.IsNullOrWhiteSpace(newRegister)){
                throw new Exception();
            }
            else{
                return true;
            }
        }

        protected virtual void AskNewRegister(string? question){ //Ask for a new register

            while(true){
                try{
                    System.Console.Write(question);
                    string? answer = System.Console.ReadLine();
                    
                    if(this.isNewRegisterValid(answer)){
                        this.typedRegister = answer;
                        break;
                    }
                }catch(Exception ex){
                    System.Console.WriteLine(ex.InnerException);
                } 
            }
            
        }
        
    }
}