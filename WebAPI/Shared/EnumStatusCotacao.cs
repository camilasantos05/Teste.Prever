using System.ComponentModel;

namespace WebAPI.Shared
{
    public enum EnumStatusCotacao
    {
        [Description("Aguardando Análise")]
        AguardandoAnalise = 1,
        [Description("Retorno Cotação")]
        RetornoCotacao = 2,
        [Description("Aprovar Cotação")]
        AprovarCotacao = 3,
        [Description("Solicitar Pagamento")]
        SolicitarPagamento = 4,
        [Description("InformarPagamento")]
        InformarPagamento = 5,
        [Description("Processando Solicitação")]
        PrococessandoSolicitacao = 6,
        [Description("Cancelar Cotação")]
        CancelrSolicitacao = 7
    }
}
