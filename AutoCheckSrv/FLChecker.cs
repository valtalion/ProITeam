using AutoCheckSrv.api.nalog;
using AutoCheckSrv.patterns;
using System;

namespace AutoCheckSrv
{
	public class FLChecker
	{
		public class Item
		{
		}

		public bool CheckTaxpayer(string inn, DateTime? date = null)
		{
			if (!date.HasValue) date = DateTime.Now;

			try
			{
				var res = Singleton<NalogService>.Instance.Taxpayer(inn, date.Value.ToString("yyyy-MM-dd"));

				return res.status;
			}
			catch(Exception ex)
			{
				//TODO: logging internal exption to log service
				throw new Exception("Произошла ошибка при обработке запроса статуса самозанятого", ex);
			}
		}
    }
}
