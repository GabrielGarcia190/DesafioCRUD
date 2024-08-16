namespace DesafioCRUD.Infra
{
    public class Configuracoes
    {
        public string ConnectionString { get; }

        public Configuracoes()
        {
            ConnectionString = "Data Source=[Nome_Servidor]\\[Nome_instacia];Initial Catalog=[Nome_banco];Integrated Security=True";
        }
    }
}
