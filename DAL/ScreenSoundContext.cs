using Microsoft.EntityFrameworkCore;
using dotenv.net;
using ScreenSound.Model;

namespace ScreenSound.DAL{
    internal class ScreenSoundContext: DbContext{

        public DbSet<BandsModel> TbBands {get;set;}
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder){

            try{
                
                // Load the environment Variables
                DotEnv.Load();

                string? dbHost = Environment.GetEnvironmentVariable("HOST");
                string? dbPort = Environment.GetEnvironmentVariable("PORT");
                string? dbUserName = Environment.GetEnvironmentVariable("USERNAME");
                string? dbPassWord = Environment.GetEnvironmentVariable("PASSWORD");
                string? dbDataBase = Environment.GetEnvironmentVariable("DATABASE");

                //Connect to the postgresql server
                optionsBuilder.UseNpgsql(@$"Host={dbHost};Port={dbPort};Username={dbUserName};
                Password={dbPassWord};Database={dbDataBase}");
            }
            catch(Exception ex){
                System.Console.WriteLine(ex.Message);
            }
            
        }
    }
}