using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Xml;

namespace GMLpal {
    class Room: Code {
        public Room(string f, string n, string c) {
            file = f;
            name = n;
            code = c;
        }


        public override void Save() {
            if (!changed) return;
            changed = false;
            XmlDocument doc = new XmlDocument();
            doc.Load(file);
            doc.SelectSingleNode("room/code").InnerText = code;
            doc.Save(file);
        }
    }
}
