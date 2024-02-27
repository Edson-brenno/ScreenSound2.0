using System.Reflection.Metadata.Ecma335;
using screenSound.DAL;
using ScreenSound.DAL;
using ScreenSound.Model;
using ScreenSound.View;

namespace ScreenSound{
    public class ScreenSound{
        public static void Main(String[] args){
            MenuView menuView = new MenuView();

            menuView.Main();
        } 
    }
}
