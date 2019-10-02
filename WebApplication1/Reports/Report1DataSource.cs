using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Security.Claims;
using System.Web;

namespace WebApplication1.Reports
{
	[DataObject]
	public class Report1DataSource
	{
		public string Type { get; set; }
		public string Value { get; set; }


		[DataObjectMethod(DataObjectMethodType.Select)]
		public static IList<Report1DataSource> GetDataSource()
		{

			ClaimsIdentity identity = System.Threading.Thread.CurrentPrincipal.Identity as ClaimsIdentity;

			return identity.Claims.Select(
				claim => new Report1DataSource()
				{
					Type = claim.Type,
					Value = claim.Value,
				}
			).ToList();
		}
	}
}