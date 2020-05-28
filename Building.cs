using System;

namespace Planner
{
    class Building
    {
        private string _designer = "Tyler Davis";
        private DateTime _dataConstructed { get; set; }
        private string _address { get; set; }
        private string _owner { get; set; }

        public int Stories { get; set; }
        public double Width { get; set; }
        public double Depth { get; set; }
        public double Volume
        {
            get
            {
                return Width * Depth * (3 * Stories);
            }
        }

        public Building(string address)
        {
            _address = address;
        }

        public string Designer
        {
            get
            {
                return _designer;
            }
        }
        public string Address
        {
            get
            {
                return _address;
            }
        }
        public string Owner
        {
            get
            {
                return _owner;
            }
        }

        public DateTime DateConstructed
        {
            get
            {
                return _dataConstructed;
            }
        }
        public void Construct()
        {
            _dataConstructed = DateTime.Now;
        }
        public void Purchase(string name)
        {
            _owner = name;
        }
    }
}