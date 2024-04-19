public class Pedido
{
    public string CGC_Cliente { get; set; }
    public string Nome { get; set; }
    public string Forma_de_Pagamento { get; set; }
    public string Data_de_Entrega { get; set; }
    public double Valor_Total { get; set; }
    public int Quantidade_de_Itens { get; set; }
    public List<Item> Lista_de_Itens { get; set; }
}