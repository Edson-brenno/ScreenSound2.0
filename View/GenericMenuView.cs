namespace ScreenSound.View{
    internal class GenericMenuView{

        protected string? GenericMenusName; // Menus Name
        protected string? LinesSeparation => "===================================================";
        protected string? GenericMenusOption;

        public GenericMenuView(string menusName){
            this.GenericMenusName = menusName;
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

                    if(String.IsNullOrEmpty(this.GenericMenusName) || String.IsNullOrWhiteSpace(this.GenericMenusName)){
                        System.Console.WriteLine("Canno be empity");
                    }
                    else if (!Char.IsDigit(this.GenericMenusOption[0])){
                        System.Console.WriteLine("Cannot be a letter");
                    }
                    else if ((Char.IsDigit(this.GenericMenusOption[0]) && int.Parse(this.GenericMenusOption) < firstMenuOptionNumber) ||
                    (Char.IsDigit(this.GenericMenusOption[0]) && int.Parse(this.GenericMenusOption) > lastMenuOptionNumber)){

                        System.Console.WriteLine("invalid option");
                    }
                    else{
                        break;
                    }

                }catch(Exception ex){
                    System.Console.WriteLine(ex.Message);
                }

            }
            
        }

    }
}