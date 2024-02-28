using ScreenSound.Interfaces.MenuInterface;

namespace ScreenSound.View{
    internal class MenuView: GenericMenuView,IMenu{ //class where contains all the main menu options
        
        public MenuView():base(@"𝕊𝕔𝕣𝕖𝕖𝕟𝕊𝕠𝕦𝕟𝕕 𝕄𝕖𝕟𝕦",1,6){
        }

        void IMenu.ShowTheChoosedMenuOption()
        {
            throw new NotImplementedException();
        }

        
        protected void ShowTheChoosedMenuOption(){

        }

        
        private void ShowAllTheMenuOptions(){
            System.Console.WriteLine("[1] Add a new Band");
            System.Console.WriteLine("[2] Add a new Album");
            System.Console.WriteLine("[3] Add a new Song");
            System.Console.WriteLine("[4] See the Bands");
            System.Console.WriteLine("[5] See the Albums");
            System.Console.WriteLine("[6] See the Songs");
        }

        public void Main(){

            base.ShowMenusName();

            this.ShowAllTheMenuOptions();

            base.ShowMenusLineSeparation();

            base.AskMenusOption();
        }

    }    
}