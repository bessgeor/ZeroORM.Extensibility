using System;

namespace ZeroORM
{
	/// <summary>
	/// Base class for all of the ZeroORM custom exceptions to be easily catchable
	/// </summary>
	[Serializable]
	public class ZeroORMException : Exception
	{
		public ZeroORMException() { }
		public ZeroORMException( string message ) : base( message ) { }
		public ZeroORMException( string message, Exception inner ) : base( message, inner ) { }
		protected ZeroORMException( System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context ) : base( info, context ) { }
	}
}
