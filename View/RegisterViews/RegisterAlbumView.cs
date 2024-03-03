namespace ScreenSound.View.RegisterViews{
    internal class RegisterAlbumView:GenericRegisterView{

        public RegisterAlbumView():base(@"𝕊𝕔𝕣𝕖𝕖𝕟𝕊𝕠𝕦𝕟𝕕 𝔸𝕝𝕓𝕦𝕞 ℝ𝕖𝕘𝕚𝕤𝕥𝕖𝕣"){

        }

        public void Main(){
            base.ShowRegistersName();

            base.AskNewRegister("Please, type the new album");
        }

    }
}