namespace ExpenseDB;

public class Expense
{
    [Key]
    public int Id { get; set; }
    public string description { get; set; }
}

