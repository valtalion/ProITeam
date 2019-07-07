using AutoCheckSrv.api;
using RestSharp;

namespace AutoCheckSrv.patterns
{
	public class ServiceProxy
	{
		public string Url
		{ get; protected set; }

		public string ApiEntry
		{ get; protected set; }

		public MethodEnum Method
		{ get; protected set; }

		public ServiceProxy(string url, string api, MethodEnum method = MethodEnum.POST)
		{
			Url = url;
			ApiEntry = api;
			Method = method;
		}

		protected TResp Exec<TResp>(ApiRequest data)
			where TResp : new()
		{
			var client = new RestClient(Url);
			var request = new RestRequest(ApiEntry, (Method == MethodEnum.GET) ? RestSharp.Method.GET : RestSharp.Method.POST);
			request.RequestFormat = DataFormat.Json;
			request.AddJsonBody(data);

			var response = client.Execute<TResp>(request);

			return response.Data;
		}
	}
}
