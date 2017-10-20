
namespace BackendIW.Models
{
	public class Scan : ValueObject<Scan>
	{
		public Scan(string value)
		{
			Value = value;
		}

		internal Scan()
		{
		}

		public string Value { get; protected set; }
	}
}