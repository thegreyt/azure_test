using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using DevExpress.Data.Filtering;
using DevExpress.ExpressApp;
using DevExpress.ExpressApp.Security;

namespace ReportV2Demo.Web.Security {
  public class AuthenticationStandardForDebug : AuthenticationStandard {
        public AuthenticationStandardForDebug(Type userType, Type logonParametersType) : base(userType, logonParametersType) { }
        private static CriteriaOperator DebugUserCriteria = CriteriaOperator.Parse("UserName = ?", "User");
        public override bool AskLogonParametersViaUI { get { return false; } }
        public override object Authenticate(IObjectSpace objectSpace) {
            return objectSpace.FindObject(UserType, DebugUserCriteria);
        }
    }
}
