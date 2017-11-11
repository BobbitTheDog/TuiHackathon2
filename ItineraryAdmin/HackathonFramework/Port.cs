namespace HackathonFramework
{
    public class Port
    {
        private readonly string _portID;
        public string ID => _portID;

        private readonly string _portName;
        public string Name => _portName;

        public Port(string portID, string portName)
        {
            _portID = portID;
            _portName = portName;
        }
    }
}