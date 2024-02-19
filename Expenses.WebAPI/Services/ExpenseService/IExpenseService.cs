using System;
using Expenses.WebAPI.Models;

namespace Expenses.WebAPI.Services.ExpenseService
{
	public interface IExpenseService
	{
        Task<ServiceResponse<List<Expense>>> GetAllExpenses();
        Task<ServiceResponse<Expense>> GetExpenseById(int id);
        Task<ServiceResponse<List<Expense>>> AddExpense(Expense newExpense);
     
    }
}

