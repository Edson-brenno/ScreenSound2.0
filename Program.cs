using dotenv.net;

namespace ScreenSound{
    public class ScreenSound{
        public static void Main(String[] args){
            DotEnv.Load();

            System.Console.WriteLine(Environment.GetEnvironmentVariable("TEST"));
        } 
    }
}
