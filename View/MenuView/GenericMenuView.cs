using ScreenSound.MenuExceptions;

namespace ScreenSound.View{
    internal class GenericMenuView{

        protected string? GenericMenusName; // Menus Name
        protected string? LinesSeparation => "===================================================";
        protected string? GenericMenusOption;

        public GenericMenuView(string menusName){
            this.GenericMenusName = menusName;
        }

        protected virtual void ClearTheCurrentLine(){

            System.Console.SetCursorPosition(0,Console.CursorTop - 1);

            System.Console.WriteLine(new string(' ', Console.WindowWidth));

            System.Console.SetCursorPosition(0,Console.CursorTop - 1);
        }
        protected virtual void ShowMenusName(){ // Show the menus name
            System.Console.WriteLine(this.LinesSeparation);
            System.Console.WriteLine($"{this.GenericMenusName}");
            System.Console.WriteLine(this.LinesSeparation);
        }

        protected virtual void ShowMenusLineSeparation(){ //Show the separation
            System.Console.WriteLine(this.LinesSeparation);
        }

        protected virtual void AskMenusOption(int firstMenuOptionNumber, int lastMenuOptionNumber){ // Ask for the menus option
            
            while(true){

                try{

                    System.Console.Write("Please, write the selected option: ");
                    this.GenericMenusOption = System.Console.ReadLine()!;

                    if(String.IsNullOrEmpty(this.GenericMenusOption) || String.IsNullOrWhiteSpace(this.GenericMenusOption)){
                        throw new NotNullMenuOptionException();
                    }
                    else if (!Char.IsDigit(this.GenericMenusOption[0])){
                        throw new NotADigitMenuException();
                    }
                    else if ((Char.IsDigit(this.GenericMenusOption[0]) && int.Parse(this.GenericMenusOption) < firstMenuOptionNumber) ||
                    (Char.IsDigit(this.GenericMenusOption[0]) && int.Parse(this.GenericMenusOption) > lastMenuOptionNumber)){

                        throw new NotAValidMenuOptionException();
                    }
                    else{
                        break;
                    }

                }catch(Exception ex){
                    System.Console.WriteLine(ex.InnerException);

                    this.ClearTheCurrentLine();
                    
                }

            }
            
        }


    }
}