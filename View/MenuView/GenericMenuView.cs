using ScreenSound.MenuExceptions;

namespace ScreenSound.View{
    internal class GenericMenuView{

        protected string? GenericMenusName; // Menus Name
        protected string? LinesSeparation => "===================================================";
        protected string? GenericMenusOption;
        protected int firstMenuOptionNumber;
        protected int lastMenuOptionNumber;

        public GenericMenuView(string menusName, int firstMenuOptionIdentifier, int lastMenuOptionIdentifier){
            this.GenericMenusName = menusName;
            this.firstMenuOptionNumber = firstMenuOptionIdentifier;
            this.lastMenuOptionNumber = lastMenuOptionIdentifier;
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

        protected virtual bool IsMenuOptionValid(string? menuOption){ //Validate the menu option

            if(String.IsNullOrEmpty(menuOption) || String.IsNullOrWhiteSpace(menuOption)){
                throw new NotNullMenuOptionException();
            }
            else if (!Char.IsDigit(menuOption[0])){
                throw new NotADigitMenuException();
            }
            else if ((Char.IsDigit(menuOption[0]) && int.Parse(menuOption) < this.firstMenuOptionNumber) ||
            (Char.IsDigit(menuOption[0]) && int.Parse(menuOption) > this.lastMenuOptionNumber)){

                throw new NotAValidMenuOptionException();
            }
            else{
                return true;
            }
        }

        protected virtual void AskMenusOption(){ // Ask for the menus option
            
            while(true){

                try{

                    System.Console.Write("Please, write the selected option: ");
                    string? menuOption = System.Console.ReadLine()!;

                    if(this.IsMenuOptionValid(menuOption)){
                        this.GenericMenusOption = menuOption;
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