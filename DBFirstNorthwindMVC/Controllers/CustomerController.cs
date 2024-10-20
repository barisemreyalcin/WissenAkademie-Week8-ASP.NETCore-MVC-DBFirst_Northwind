using DBFirstNorthwindMVC.Models;
using Microsoft.AspNetCore.Mvc;

namespace DBFirstNorthwindMVC.Controllers
{
    public class CustomerController : Controller
    {
        NorthwindDbContext context;
        private readonly ILogger logger;

        //injection
        public CustomerController(NorthwindDbContext _context, ILogger<CustomerController> _logger)
        {
            this.context = _context;
            this.logger = _logger;
        }

        public IActionResult Index()
        {
            var customers = context.Customers.ToList<Customer>(); // <> istersem veririm
            return View(customers);
        }

        public IActionResult Details(string id)
        {
            var customer = context.Customers.SingleOrDefault(x => x.CustomerId == id);
            return View(customer);
        }

        public IActionResult Delete(string id)
        {
            var customer = context.Customers.SingleOrDefault(x => x.CustomerId == id);
            return View(customer);
        }
    }
}
