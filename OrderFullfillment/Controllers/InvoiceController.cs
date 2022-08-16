using Microsoft.AspNetCore.Mvc;
using OrderFullfillment.Application.Interfaces;
using OrderFullfillment.Entity.Models.Invoice;
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

        [HttpGet]
        [Route("[controller]")]
        public async Task<InvoiceBase> GetById([FromQuery]int orderId)
        {
            return await _invoiceService.Get(orderId);
        }

        [HttpPost]
        [Route("[controller]/sign/{orderId}")]
        public async Task SignInvoice(int orderId)
        {
            await _invoiceService.Sing(orderId);
        }

        [HttpPost]
        [Route("[controller]/export/{orderId}")]
        public async Task ExportInvoice(int orderId)
        {
            await _invoiceService.Export(orderId);
        }
    }
}
