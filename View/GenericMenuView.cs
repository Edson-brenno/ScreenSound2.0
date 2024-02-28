namespace ScreenSound.View{
    internal class GenericMenuView{

        protected string? GenericMenusName;

        public GenericMenuView(string menusName){
            this.GenericMenusName = menusName;
        }
        protected void ShowMenusName(){
            System.Console.WriteLine("==================================================="); 
            System.Console.WriteLine($"{this.GenericMenusName}");
            System.Console.WriteLine("===================================================");
        }

        protected void ShowMenusLineSeparation(){
            System.Console.WriteLine("===================================================");
        }

    }
}