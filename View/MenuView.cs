namespace ScreenSound.View{
    internal class MenuView{ //class where contains all the main menu options
        
        private string menusName => @"𝕊𝕔𝕣𝕖𝕖𝕟𝕊𝕠𝕦𝕟𝕕 𝕄𝕖𝕟𝕦";

        private void ShowAllTheMenuOptions(){
            System.Console.WriteLine("[1] Add a new Band");
            System.Console.WriteLine("[2] Add a new Album");
            System.Console.WriteLine("[3] Add a new Song");
            System.Console.WriteLine("[4] See the Bands");
            System.Console.WriteLine("[5] See the Albums");
            System.Console.WriteLine("[6] See the Songs");
        }

        public void Main(){
            GenericMenuView.ShowMenusName(menusName);

            this.ShowAllTheMenuOptions();

            GenericMenuView.ShowMenusLineSeparation();
        }
    }    
}