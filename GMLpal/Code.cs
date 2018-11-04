using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GMLpal {
    abstract class Code {
        public string file, name, code;
        public bool changed = false;
        public abstract void Save();
    }
}
