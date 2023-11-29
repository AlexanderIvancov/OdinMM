namespace Odin.CMB_Components
{
    public class DataNode
    {
        public int Id { get; set; }

        public string Text { get; set; }

        public int? ParentId { get; set; }

        public int ChildCount { get; set; }

    }
}
