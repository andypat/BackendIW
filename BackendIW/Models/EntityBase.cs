using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BackendIW.Models
{
	public abstract class EntityBase : IEntity
	{
		public int ID { get; set; }
	}
}