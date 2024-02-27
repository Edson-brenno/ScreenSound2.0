namespace ScreenSound.View{
    internal class MenuView{ //class where contains all the main menu options
        
        private string menusName => @"𝕊𝕔𝕣𝕖𝕖𝕟𝕊𝕠𝕦𝕟𝕕 𝕄𝕖𝕟𝕦";

        public void Main(){
            GenericMenuView.ShowMenusName(menusName);
        }
    }    
}