using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BackendIW.Models
{
	public class Workorder  : 
		EntityBase
	{

		public DateTime Created { get; set; }
		public virtual ICollection<Scan> Scans { get; set; }
	}
}