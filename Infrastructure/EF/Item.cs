namespace Todos_Infrastructure.EF
{
    public class Item
    {
        public int ItemId { get; set; }
        public string Name { get; set; }
        public bool IsChecked { get; set; }

        public int TodoId { get; set; }
        public Todo Todo { get; set; }
    }
}
