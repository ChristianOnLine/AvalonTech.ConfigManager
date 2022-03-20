namespace AvalonTech.ConfigManager.Model
{
    public class ConfigData: ITrackChanges
    {
        public string KeyName { get; set; }
        public string Value { get; set; }
        public string Description { get; set; }
        public string UserCreated { get; set; }
        public DateTime DateCreated { get; set; }
        public string UserModified { get; set; }
        public DateTime DateModified { get; set; }
    }
}