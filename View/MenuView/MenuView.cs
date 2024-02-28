using ScreenSound.Interfaces.MenuInterface;
using ScreenSound.MenuExceptions;

namespace ScreenSound.View{
    internal class MenuView: GenericMenuView,IMenu{ //class where contains all the main menu options
        
        public MenuView():base(@"𝕊𝕔𝕣𝕖𝕖𝕟𝕊𝕠𝕦𝕟𝕕 𝕄𝕖𝕟𝕦",1,7){
        }

        void IMenu.ShowTheChoosedMenuOption()
        {
            throw new NotImplementedException();
        }

        
        protected void ShowTheChoosedMenuOption(){
            try{

                switch(int.Parse(base.GenericMenusOption ?? throw new NotNullMenuOptionException())){
                    case 1:
                        System.Console.WriteLine("new band");
                        break;
                    case 2:
                        System.Console.WriteLine("new album");
                        break;
                    case 3:
                        System.Console.WriteLine("new song");
                        break;
                    case 4:
                        System.Console.WriteLine("see band");
                        break;
                    case 5:
                        System.Console.WriteLine("see album");
                        break;
                    case 6:
                        System.Console.WriteLine("see song");
                        break;
                    case 7:
                        Environment.Exit(0);
                        break;
                    default:
                        throw new NotAValidMenuOptionException();
                }

            }catch(Exception ex){
                System.Console.WriteLine(ex.Message);
            }
            
        }

        
        private void ShowAllTheMenuOptions(){
            System.Console.WriteLine("[1] Add a new Band");
            System.Console.WriteLine("[2] Add a new Album");
            System.Console.WriteLine("[3] Add a new Song");
            System.Console.WriteLine("[4] See the Bands");
            System.Console.WriteLine("[5] See the Albums");
            System.Console.WriteLine("[6] See the Songs");
            System.Console.WriteLine("[7] Exit");
        }

        public void Main(){

            base.ShowMenusName();

            this.ShowAllTheMenuOptions();

            base.ShowMenusLineSeparation();

            base.AskMenusOption();

            this.ShowTheChoosedMenuOption();
        }

    }    
}