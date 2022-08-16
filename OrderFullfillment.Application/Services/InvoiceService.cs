using OrderFullfillment.Application.Interfaces;
using OrderFullfillment.Entity.Models.Invoice;
using OrderFullfillment.Entity.Models.Order;
using OrderFullfillment.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderFullfillment.Application.Services
{
    public class InvoiceService : IInvoiceService
    {
        private readonly IRepository<CompanyInvoice> _companyInvoiceRepository;
        private readonly IRepository<PersonalInvoice> _personalInvoiceRepository;
        private readonly IOrderService _orderService;

        public InvoiceService(IRepository<CompanyInvoice> companyInvoiceRepository, IRepository<PersonalInvoice> personalInvoiceRepository, IOrderService orderService)
        {
            _companyInvoiceRepository = companyInvoiceRepository;
            _personalInvoiceRepository = personalInvoiceRepository;
            _orderService = orderService;
        }

        public async Task<InvoiceBase> Get(int id)
        {
            throw new NotImplementedException();
        }

        public async Task Sing(int orderId)
        {
            var order = await _orderService.Get(orderId);
            var invoiceId = order.InvoiceId;

            switch (order.Type)
            {
                case InvoiceOrder.OrderType.Company:
                    {
                        var companyInvoice = await _companyInvoiceRepository.Get(invoiceId);
                        companyInvoice.Sing(orderId);
                    }
                    break;
                case InvoiceOrder.OrderType.Personal:
                    {
                        var personalInvoice = await _personalInvoiceRepository.Get(invoiceId);
                        personalInvoice.Sing(orderId);
                    }
                    break;
                default:
                    break;
            }
        }
    }
}
