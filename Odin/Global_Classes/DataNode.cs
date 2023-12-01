namespace Odin.Global_Classes
{
    public class DataNode
    {
        public int Id { get; set; }

        public string Text { get; set; }

        public int? ParentId { get; set; }

        public int ChildCount { get; set; }
    }
}
