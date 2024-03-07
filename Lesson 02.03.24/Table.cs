using System.Collections.Generic;

namespace Lesson_02._03._24
{
    public class Table
    {
        public int Number { get; set; }
        public int Capacity { get; set; }
        public bool IsReserved { get; set; }
        public Reservation Reservation { get; set; }
        public List<string> ReservedDishes { get; set; } = new List<string>();
    }
}
