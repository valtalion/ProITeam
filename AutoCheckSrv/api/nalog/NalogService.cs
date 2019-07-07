using AutoCheckSrv.patterns;

namespace AutoCheckSrv.api.nalog
{
	public class NalogService : ServiceProxy
	{
		public const string NALOG_URL = "https://statusnpd.nalog.ru:443";
		public const string NALOG_TAXPAYER = "api/v1/tracker/taxpayer_status";

		public NalogService()
			: base(/*ConfigurationManager.AppSettings["nalogurl"] ??*/ NALOG_URL
				  , /*ConfigurationManager.AppSettings["nalogtaxpayer"] ??*/ NALOG_TAXPAYER)
		{
		}

		/// <summary>
		/// Описание ОПИ https://npd.nalog.ru/html/sites/www.npd.nalog.ru/api_statusnpd_nalog_ru.pdf
		/// </summary>
		public TaxpayerResponse Taxpayer(string rinn, string rdate)
		{
			var res = Exec<TaxpayerResponse>(new TaxpayerRequest() {inn = rinn, requestDate = rdate});
			//return res.message

			return res;
		}
	}
}
