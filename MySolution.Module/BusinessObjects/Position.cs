using DevExpress.Persistent.Base;
using DevExpress.Persistent.BaseImpl.EF;
using System.ComponentModel;

namespace MySolution.Module.BusinessObjects
{
	[DefaultClassOptions]
	[DefaultProperty(nameof(Title))]
	public class Position : BaseObject
	{
		public virtual string Title { get; set; }
	}
}