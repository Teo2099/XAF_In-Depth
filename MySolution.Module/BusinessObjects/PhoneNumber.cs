using DevExpress.Persistent.BaseImpl.EF;
using System.Collections.ObjectModel;
using System.ComponentModel;

namespace MySolution.Module.BusinessObjects;

[DefaultProperty(nameof(Number))]
public class PhoneNumber : BaseObject
{

	public virtual String Number { get; set; }

	public virtual String PhoneType { get; set; }

	public virtual Employee Employee { get; set; }

	public override String ToString()
	{
		return Number;
	}
}