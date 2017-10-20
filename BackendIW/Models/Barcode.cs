using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BackendIW.Models
{
	public class Barcode :  Scan
	{
		public Barcode(string value) :
			base(value)
		{
		}
	}
}