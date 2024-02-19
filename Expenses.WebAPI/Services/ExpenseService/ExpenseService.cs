using System;
namespace Expenses.WebAPI.Services.ExpenseService
{
	public class ExpenseService : IExpenseService
    {
        private static List<Expense> expenses = new List<Expense> {
            new Expense{ Id = 0, Description= "Eating Out", Amount=11.99},
            new Expense{ Id = 1, Description= "Gas", Amount=12.99},
            new Expense{ Id = 2, Description= "Tuition", Amount=1111.99},
        };

        public async Task<ServiceResponse<List<Expense>>> AddExpense(Expense newExpense)
        {
            var serviceResponse = new ServiceResponse<List<Expense>>();
            expenses.Add(newExpense);
            serviceResponse.Data = expenses;
          
            return serviceResponse;
        }

        public async Task<ServiceResponse<List<Expense>>> GetAllExpenses()
        {
            var serviceResponse = new ServiceResponse<List<Expense>>();
            serviceResponse.Data = expenses;
            return serviceResponse;
        }

        public async Task<ServiceResponse<Expense>> GetExpenseById(int id)
        {
            var serviceResponse = new ServiceResponse<Expense>();
            var expense = expenses.FirstOrDefault(e => e.Id == id);
            serviceResponse.Data = expense;
            return serviceResponse;
            
           

        }
	}
}

