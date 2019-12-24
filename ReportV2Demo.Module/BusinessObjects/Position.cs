using DevExpress.Persistent.Base;
using DevExpress.Persistent.BaseImpl;
using DevExpress.Persistent.Validation;
using DevExpress.Xpo;

namespace ReportV2Demo.Module.BusinessObjects
{
    [DefaultClassOptions]
    [System.ComponentModel.DefaultProperty(nameof(Position.Title))]
    public class Position : BaseObject
    {
        public Position(Session session)
            : base(session)
        {
        }
        private string title;
        [RuleRequiredField("RuleRequiredField for Position.Title", DefaultContexts.Save)]
        public string Title
        {
            get
            {
                return title;
            }
            set
            {
                SetPropertyValue(nameof(Title), ref title, value);
            }
        }
    }
}
