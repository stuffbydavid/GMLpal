using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace GMLpal {
    class Script: Code {
        public Script(string f, string n, string c) {
            file = f;
            name = n;
            code = c;
        }
        public override void Save() {
            if (!changed) return;
            changed = false;
            File.WriteAllText(file, code);
        }
    }
}
