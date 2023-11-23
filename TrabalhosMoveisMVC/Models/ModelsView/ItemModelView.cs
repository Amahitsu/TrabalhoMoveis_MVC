namespace TrabalhosMoveisMVC.Models.ModelsView
{
    public class ItemModelView
    {
        public String nomeMoveis { get; set; }

        public String checkMoveis { get; set; }

        public ItemModelView(string nomeMoveis, string checkMoveis)
        {
            this.nomeMoveis = nomeMoveis;
            this.checkMoveis = checkMoveis;
        }

        public ItemModelView()
        {
            
        }
    }
}
