namespace ControleFinanceiro
{
    interface IDespesaVariavel
    {
        string Descricao { get; set; }
        string FormaPgmt { get; set; }
        string Local { get; set; }
        string TipoGasto { get; set; }
        string Valor { get; set; }
    }
}