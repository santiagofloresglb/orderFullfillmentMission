using Microsoft.AspNetCore.Mvc;
using OrderFullfillment.Application.Interfaces;
using System.Threading.Tasks;

namespace OrderFullfillment.Controllers
{
    [ApiController]
    public class InvoiceController : Controller
    {
        private readonly IInvoiceService _invoiceService;

        public InvoiceController(IInvoiceService invoiceService)
        {
            _invoiceService = invoiceService;
        }

        [HttpPost]
        [Route("[controller]/sign/{orderId}")]
        public async Task SignInvoice(int orderId)
        {
            await _invoiceService.Sing(orderId);
        }
    }
}
