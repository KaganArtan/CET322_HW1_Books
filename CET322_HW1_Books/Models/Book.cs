namespace CET322_HW1_Books.Models
{
    public class Book
    {
        public string? Name { get; set; }
        public string? Author { get; set; }
        public int PageNumber { get; set; }
        public DateTime DueDate { get; set; }

        public string GetDueDateStatus()
        {
            int daysRemaining = (DueDate - DateTime.Now).Days;

            if (daysRemaining > 0)
                return "green";
            else if (daysRemaining == 0)
                return "yellow";
            else
                return "red";
        }

        public int DaysRemaining()
        {
            return (DueDate - DateTime.Now).Days;
        }
    }

}
