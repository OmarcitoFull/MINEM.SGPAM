using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Minem.Sgpam.ClienteInterno
{
    public class FullEstructura
    {
        public string _buffer { get; set; }
        public long _origin { get; set; }
        public long _position { get; set; }
        public long _length { get; set; }
        public long _capacity { get; set; }
        public bool _expandable { get; set; }
        public bool _writable { get; set; }
        public bool _exposable { get; set; }
        public bool _isOpen { get; set; }


    }
}
