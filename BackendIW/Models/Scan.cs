
namespace BackendIW.Models
{
	public abstract class Scan : ValueObject<Scan>
	{
		protected Scan(string value)
		{
			Value = value;
		}

		internal Scan()
		{
		}

		public string Value { get; protected set; }
	}
}