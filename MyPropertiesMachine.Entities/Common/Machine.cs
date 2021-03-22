using System;

namespace MyPropertiesMachine.Entities
{
    public class Machine
    {
        public Machine()
        {

            SO = string.Empty;
            MachineName = string.Empty;
            IP = string.Empty;
            RAM = string.Empty;
            CPU = string.Empty;
            id = Guid.NewGuid();
            CreationDate = DateTime.Now.ToLocalTime();
        }

        public Guid id { get; set; }

        public string SO { get; set; }
        public string MachineName { get; set; }
        public string IP { get; set; }
        public string HardDisk { get; set; }
        public string RAM { get; set; }
        public string CPU { get; set; }
        public string UserDomain { get; set; }
        public DateTime CreationDate { get; set; }

    }
}
