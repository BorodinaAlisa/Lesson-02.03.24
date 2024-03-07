using System.Collections.Generic;

namespace Lesson_02._03._24
{
    public class Restaurant
    {
        public string Name { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }
        public string Menu { get; set; }
        public int TablesCount { get; set; }
        public List<Table> Tables { get; set; } = new List<Table>();
        public List<Client> Clients { get; set; } = new List<Client>();
    }
}
