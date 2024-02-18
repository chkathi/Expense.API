using Microsoft.AspNetCore.Mvc;


// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Expenses.WebAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ExpensesController : ControllerBase
    {
        private static List<Expense> expenses = new List<Expense> {
            new Expense{ Id = 0, Description= "Eating Out", Amount=11.99},
            new Expense{ Id = 1, Description= "Gas", Amount=12.99},
            new Expense{ Id = 2, Description= "Tuition", Amount=1111.99},
        };
        // GET: api/values
        [HttpGet("GetAll")]
        public ActionResult<List<Expense>> Get()
        {
            return Ok(expenses);
        }

        [HttpGet("{id}")]
        public ActionResult<Expense> GetSingle(int id)
        {

            return (expenses.FirstOrDefault(e => e.Id == id));
        }

        [HttpPost]
        public ActionResult<List<Expense>> AddExpense(Expense newExpense) {
            expenses.Add(newExpense);
            return Ok(expenses);
        }
    }
}

