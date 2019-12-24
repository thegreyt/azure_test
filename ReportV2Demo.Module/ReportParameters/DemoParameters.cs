using System.Collections.Generic;
using DevExpress.Data.Filtering;
using DevExpress.ExpressApp;
using DevExpress.ExpressApp.DC;
using DevExpress.ExpressApp.ReportsV2;
using DevExpress.Xpo;
using DevExpress.Xpo.DB;
using ReportV2Demo.Module.BusinessObjects;

namespace ReportV2Demo.Module
{
    [DomainComponent]
    public class DemoParameters : ReportParametersObjectBase
    {
        public bool SortByFirstName { get; set; }
        public bool FilterByFirstName { get; set; }
        public string FirstName { get; set; }
        public bool FilterByPosition { get; set; }
        public Position ContactPosition { get; set; }

        public DemoParameters(IObjectSpaceCreator provider) : base(provider) { }

        protected override IObjectSpace CreateObjectSpace()
        {
            return objectSpaceCreator.CreateObjectSpace(typeof(Contact));
        }

        public override CriteriaOperator GetCriteria()
        {
            CriteriaOperator criteriaName = null;
            CriteriaOperator criteriaPosition = null;
            if (FilterByFirstName)
            {
                criteriaName = CriteriaOperator.Parse("FirstName = ?", FirstName);
            }
            if(FilterByPosition && ContactPosition != null)
            {
                criteriaPosition = CriteriaOperator.Parse("Position.Oid = ?", ContactPosition.Oid);
            }
            return CriteriaOperator.And(criteriaName, criteriaPosition);
        }

        public override SortProperty[] GetSorting()
        {
            List<SortProperty> sorting = new List<SortProperty>();
            if (SortByFirstName)
            {
                sorting.Add(new SortProperty(nameof(FirstName), SortingDirection.Ascending));
            }
            return sorting.ToArray();
        }

        public override string ToString() {
            return "London";
        }
    }
}
