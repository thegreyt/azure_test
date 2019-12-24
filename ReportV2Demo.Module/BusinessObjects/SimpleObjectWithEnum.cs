using DevExpress.Persistent.Base;
using DevExpress.Persistent.BaseImpl;
using DevExpress.Xpo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReportV2Demo.Module.BusinessObjects {
    [DefaultClassOptions]
    public class SimpleObjectWithEnum : BaseObject {
        public SimpleObjectWithEnum(Session session) : base(session) {
        }
        private string name;
        public string Name {
            get { return name; }
            set { SetPropertyValue(nameof(Name), ref name, value); }
        }
        private SimpleEnum simpleEnum;
        public SimpleEnum SimpleEnum {
            get { return simpleEnum; }
            set { SetPropertyValue(nameof(SimpleEnum), ref simpleEnum, value); }
        }
    }
    public enum SimpleEnum {
        One, Two
    }
}
