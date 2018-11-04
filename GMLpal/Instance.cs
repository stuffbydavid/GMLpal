using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Xml;

namespace GMLpal {
    class Instance: Code {
        public int instanceN;
        public string instanceId;

        public Instance(string f, string n, int iN, string iId, string c) {
            file = f;
            name = n;
            instanceN = iN;
            instanceId = iId;
            code = c.Replace("\n", Environment.NewLine);
        }

        public override void Save() {
            if (!changed) return;
            changed = false;
            XmlDocument doc = new XmlDocument();
            doc.Load(file);
            doc.SelectNodes("room/instances/instance")[instanceN].Attributes[5].Value = code.Replace(Environment.NewLine, "\n");
            doc.Save(file);
        }
    }
}
