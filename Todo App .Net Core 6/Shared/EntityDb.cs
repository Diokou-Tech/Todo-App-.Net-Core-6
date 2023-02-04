namespace Todo_App_.Net_Core_6.Shared
{
    public abstract class EntityDb
    {
        public string Id { get; set; } = Guid.NewGuid().ToString();
    }
}
