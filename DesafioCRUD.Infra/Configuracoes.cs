namespace DesafioCRUD.Infra
{
    public class Configuracoes
    {
        public string ConnectionString { get; }

        public Configuracoes()
        {
            ConnectionString = "Data Source=GARCIA-DELLG15\\SQLEXPRESS;Initial Catalog=DesafioCRUD;Integrated Security=True";
        }
    }
}
