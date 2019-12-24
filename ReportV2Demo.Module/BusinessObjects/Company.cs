using DevExpress.Persistent.Base;
using DevExpress.Persistent.BaseImpl;
using DevExpress.Xpo;

namespace ReportV2Demo.Module.BusinessObjects
{
    #region DEMO_REMOVE
#if DEBUG
    //[DefaultClassOptions]
#endif
#endregion
    [System.ComponentModel.DefaultProperty(nameof(Name))]
    public class Company : BaseObject
    {
        public Company(Session session)
            : base(session)
        {
        }

        private string name;
        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                SetPropertyValue(nameof(Name), ref name, value);
            }
        }

        private string city;
        public string City
        {
            get
            {
                return city;
            }
            set
            {
                SetPropertyValue(nameof(City), ref city, value);
            }
        }
    }
}
