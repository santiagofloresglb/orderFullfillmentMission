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
            return await GetInvoice(id);
        }

        public async Task Sing(int orderId)
        {
            var invoice = await GetInvoice(orderId);
            invoice.Sing(orderId);
        }

        public async Task Export(int orderId)
        {
            var invoice = await GetInvoice(orderId);
            invoice.Export(orderId);
        }

        private async Task<InvoiceBase> GetInvoice(int orderId)
        {
            var order = await _orderService.Get(orderId);
            var invoiceId = order.InvoiceId;
            var invoice = await GetInvoiceTypeByOrderId(order, invoiceId);
            return invoice;
        }

        private async Task<InvoiceBase> GetInvoiceTypeByOrderId(InvoiceOrder order, int invoiceId)
        {
            switch (order.Type)
            {
                case InvoiceOrder.OrderType.Company:
                    {
                        return await _companyInvoiceRepository.Get(invoiceId);
                    }
                case InvoiceOrder.OrderType.Personal:
                    {
                        return await _personalInvoiceRepository.Get(invoiceId);
                    }
                default: throw new NotImplementedException();
            }
        }
    }
}
