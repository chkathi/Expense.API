using System.ComponentModel.DataAnnotations;

namespace Expenses.WebAPI.Models
{
	public class Expense
	{
        [Key]
        public int Id { set; get; }
        public string Description { set; get; } = "Groceries";
        public double Amount { set; get; } = 0.00;
    }
}

