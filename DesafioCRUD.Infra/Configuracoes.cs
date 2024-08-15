namespace DesafioCRUD.Infra
{
    public class Configuracoes
    {
        public string ConnectionString { get; }

        public Configuracoes()
        {
            ConnectionString = "Data Source=[Nome_do_Servidor]\\[Nome_da_Instancia];Initial Catalog=[Nome_do_Banco];Integrated Security=True";
        }
    }
}
