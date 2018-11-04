using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Xml;

namespace GMLpal {
    class Constant: Code {
        int constantN;
        public Constant(string f, string n, int cN, string c) {
            file = f;
            name = n;
            constantN = cN;
            code = c;
        }

        public override void Save() {
            if (!changed) return;
            changed = false;
            XmlDocument doc = new XmlDocument();
            doc.Load(file);
            doc.SelectNodes("assets/constants/constant")[constantN].InnerText = code;
            doc.Save(file);
        }
    }
}
