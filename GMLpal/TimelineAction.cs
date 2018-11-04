using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Xml;

namespace GMLpal {
    class TimelineAction: Code {
        int stepN, actionN;
        public TimelineAction(string f, string n, int s, int a, string c) {
            file = f;
            name = n;
            stepN = s;
            actionN = a;
            code = c;
        }

        public override void Save() {
            if (!changed) return;
            changed = false;
            XmlDocument doc = new XmlDocument();
            doc.Load(file);
            doc.SelectNodes("timeline/entry")[stepN].SelectNodes("event/action/arguments/argument/string")[actionN].InnerText = code;
            doc.Save(file);
        }
    }
}
