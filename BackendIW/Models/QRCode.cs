﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BackendIW.Models
{
	public class QRCode : Scan
	{
		public QRCode(string value) : 
			base(value)
		{			
		}

	}
}