using System.ComponentModel;

namespace DesafioCRUD.Domain.Enums
{
    public enum EEstadoCivil
    {
        [Description("CASADO")]
        Casado = 1,
        [Description("SOLTEIRO")]
        Solteiro = 2,
        [Description("DIVORCIADO")]
        Divordicado = 3,
        [Description("VIÚVO")]
        Viuvo = 4,
        [Description("UNIÃO ESTÁVEL")]
        Uniao_Estavel = 5,
        [Description("NÃO INFORMAR")]
        Nao_Informado = 5
    }
}
