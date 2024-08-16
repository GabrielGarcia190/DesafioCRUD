namespace DesafioCRUD.Domain.Results
{
    public class ResultadoOperacao
    {
        public string Mensagem { get; private set; }

        public bool Sucesso { get; private set; }

        public ResultadoOperacao(string mensagem, bool sucesso)
        {
            Mensagem = mensagem;
            Sucesso = sucesso;
        }
    }
}
