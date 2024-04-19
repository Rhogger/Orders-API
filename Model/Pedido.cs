public class Pedido
{
    public string cgcCliente { get; set; }
    public string nome { get; set; }
    public string formaPagamento { get; set; }
    public string dataEntrega { get; set; }
    public double valorTotal { get; set; }
    public int quantidadeItens { get; set; }
    public List<Item> itens { get; set; }
}