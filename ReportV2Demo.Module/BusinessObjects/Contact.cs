using DevExpress.ExpressApp.DC;
using DevExpress.Persistent.Base;
using DevExpress.Persistent.BaseImpl;
using DevExpress.Xpo;

namespace ReportV2Demo.Module.BusinessObjects
{
    [DefaultClassOptions]
    public class Contact : Person
    {
        private TitleOfCourtesy titleOfCourtesy;
        private Position position;
        public Contact(Session session) :
            base(session)
        {
        }
        public TitleOfCourtesy TitleOfCourtesy
        {
            get
            {
                return titleOfCourtesy;
            }
            set
            {
                SetPropertyValue(nameof(TitleOfCourtesy), ref titleOfCourtesy, value);
            }
        }
        public Position Position
        {
            get
            {
                return position;
            }
            set
            {
                SetPropertyValue(nameof(Position), ref position, value);
            }
        }
    }
    public enum TitleOfCourtesy
    {
        Dr,
        Miss,
        Mr,
        Mrs,
        Ms
    };
}
