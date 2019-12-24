using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DevExpress.ExpressApp;
using DevExpress.Persistent.Base;
using DevExpress.Persistent.BaseImpl;
using DevExpress.Persistent.BaseImpl.PermissionPolicy;
using DevExpress.Xpo;

namespace ReportV2Demo.Module.BusinessObjects {
    [DefaultClassOptions]
    public class ObjectWithSecurity : BaseObject {
        public ObjectWithSecurity(Session session) : base(session) {
        }
        private string name;
        public string Name {
            get { return name; }
            set { SetPropertyValue(nameof(Name), ref name, value); }
        }
        public string UserName {
            get { return SecuritySystem.CurrentUserName; }
        }
        private PermissionPolicyUser user;
        public PermissionPolicyUser User {
            get { return user; }
            set { SetPropertyValue(nameof(User), ref user, value); }
        }
    }
}
