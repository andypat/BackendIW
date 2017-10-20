using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using BackendIW.Models;
using System.Collections.Generic;

namespace BackendIW.Tests
{
	[TestClass]
	public class ModelUnitTests
	{
		[TestMethod]
		public void TryCreateWorkorderWithSomeBarcodes()
		{
			var order = new Workorder();
			order.Scans = new List<Scan>
			{
				new Barcode("ASD123"),
				new QRCode("CIPPA_LIPPA_123")
			};

			Assert.IsTrue(order.Scans.Count > 0);

		}

		[TestMethod]
		public void TryCompareVariousBarcodes()
		{
			var b1 = new Barcode("ASD123");
			var b2 = new Barcode("ASD123");
			var q1 = new QRCode("ASD123");
			var q2 = new QRCode("ASD123");


			Assert.IsTrue(b1 == b2);
			Assert.IsTrue(q1 == q2);
			//Assert.IsTrue(b1 == b2 && q1 == q2 && b1 == q1 && b2 == q2 && b1 == q2 && b2 == q1);
			



		}

	}
}
