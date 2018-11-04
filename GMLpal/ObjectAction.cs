using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Xml;

namespace GMLpal {
    class ObjectAction: Code {
        int eventN, actionN;

        public ObjectAction(string f, string n, int e, int a, string c) {
            file = f;
            name = n;
            eventN = e;
            actionN = a;
            code = c;
        }

        public override void Save() {
            if (!changed) return;
            changed = false;
            XmlDocument doc = new XmlDocument();
            doc.Load(file);
            doc.SelectNodes("object/events/event")[eventN].SelectNodes("action/arguments/argument/string")[actionN].InnerText = code;
            doc.Save(file);
        }
    }
}
