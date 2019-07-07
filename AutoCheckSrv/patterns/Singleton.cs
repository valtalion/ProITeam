namespace AutoCheckSrv.patterns
{
	public class Singleton<Elem>
		where Elem: class, new()
	{
		static Elem _instance;

		public static Elem Instance
		{
			get => _instance ?? (_instance = new Elem());
		}
	}
}
