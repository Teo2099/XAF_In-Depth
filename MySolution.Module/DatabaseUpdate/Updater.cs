using DevExpress.ExpressApp;
using DevExpress.Data.Filtering;
using DevExpress.Persistent.Base;
using DevExpress.ExpressApp.Updating;
using DevExpress.ExpressApp.EF;
using DevExpress.Persistent.BaseImpl.EF;
using Microsoft.Extensions.DependencyInjection;
using MySolution.Module.BusinessObjects;

namespace MySolution.Module.DatabaseUpdate;

// For more typical usage scenarios, be sure to check out https://docs.devexpress.com/eXpressAppFramework/DevExpress.ExpressApp.Updating.ModuleUpdater
public class Updater : ModuleUpdater {
    public Updater(IObjectSpace objectSpace, Version currentDBVersion) :
        base(objectSpace, currentDBVersion) {
    }
    public override void UpdateDatabaseAfterUpdateSchema() {
        base.UpdateDatabaseAfterUpdateSchema();
		Employee employeeMary = ObjectSpace.FirstOrDefault<Employee>(x => x.FirstName == "Mary" && x.LastName == "Tellitson");
		if (employeeMary == null)
		{
			employeeMary = ObjectSpace.CreateObject<Employee>();
			employeeMary.FirstName = "Mary";
			employeeMary.LastName = "Tellitson";
			employeeMary.Email = "tellitson@example.com";
			employeeMary.Birthday = new DateTime(1980, 11, 27);
		}

		ObjectSpace.CommitChanges(); //Uncomment this line to persist created object(s).
	}
    public override void UpdateDatabaseBeforeUpdateSchema() {
        base.UpdateDatabaseBeforeUpdateSchema();
    }
}
