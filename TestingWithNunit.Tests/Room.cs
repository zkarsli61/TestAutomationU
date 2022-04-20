namespace TestingWithNunit.Tests
{
    public class Room
    {

        public string Number { get; set; }
        public object Type { get; set; }
        public string Price { get; set; }
        public bool Accessible { get; set; }
        public bool HasWifi { get; set; }
        public bool HasView { get; set; }
        public bool HasRadio { get; internal set; }
        public bool HasRefreshments { get; internal set; }
        public bool HasSafe { get; internal set; }
        public bool HasTelevision { get; internal set; }
    }
}