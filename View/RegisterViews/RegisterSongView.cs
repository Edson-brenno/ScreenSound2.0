namespace ScreenSound.View.RegisterViews{
    internal class RegisterSongView:GenericRegisterView{
        public RegisterSongView():base(@"𝕊𝕔𝕣𝕖𝕖𝕟𝕊𝕠𝕦𝕟𝕕 𝕊𝕠𝕟𝕘 ℝ𝕖𝕘𝕚𝕤𝕥𝕖𝕣"){}

        public void Main(){
            base.ShowRegistersName();

            base.AskNewRegister("Please, type new songs name: ");
        }
    }
}