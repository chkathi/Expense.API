using Microsoft.AspNetCore.Mvc;


// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Expenses.WebAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ExpensesController : ControllerBase
    {
        private readonly IExpenseService _expenseService;

        public ExpensesController(IExpenseService expenseService) {
            this._expenseService = expenseService;
        }

        // GET: api/values
        [HttpGet("GetAll")]
        public async Task<ActionResult<ServiceResponse<List<Expense>>>> Get()
        {
            return Ok(await _expenseService.GetAllExpenses());
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<ServiceResponse<Expense>>> GetSingle(int id)
        {

            return Ok(await _expenseService.GetExpenseById(id));
        }

        [HttpPost]
        public async Task<ActionResult<ServiceResponse<List<Expense>>>> AddExpense(Expense newExpense) {
            return Ok(await _expenseService.AddExpense(newExpense));
        }
    }


}

