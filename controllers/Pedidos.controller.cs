using Microsoft.AspNetCore.Mvc;

[ApiController]
[Route("[controller]/[action]")]
public class PedidosController : ControllerBase
{

  private readonly ILogger<PedidosController> _logger;

  public PedidosController(ILogger<PedidosController> logger)
  {
    _logger = logger;
  }

  [HttpPost(Name = "Pedido")]
  public IActionResult Pedido([FromBody] Pedido pedido)
  {
    return CreatedAtAction(nameof(Pedido), "Dados recebidos");
  }
}