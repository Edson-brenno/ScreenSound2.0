namespace ScreenSound.View.RegisterViews{
    internal class RegisterBandView:GenericRegisterView{
        
        public RegisterBandView():base(@"𝕊𝕔𝕣𝕖𝕖𝕟𝕊𝕠𝕦𝕟𝕕 ℝ𝕖𝕘𝕚𝕤𝕥𝕖𝕣 𝕒 𝔹𝕒𝕟𝕕"){

        }

        internal void Main(){
            base.ShowRegistersName();

            base.AskNewRegister("Please, type the name of the Band: ");
        }
    }
}