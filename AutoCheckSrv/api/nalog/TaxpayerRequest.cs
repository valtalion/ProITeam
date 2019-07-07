namespace AutoCheckSrv.api.nalog
{
	public class TaxpayerRequest : ApiRequest
	{
		public string inn
		{ get; set; }

		public string requestDate
		{ get; set; }
	}
}
