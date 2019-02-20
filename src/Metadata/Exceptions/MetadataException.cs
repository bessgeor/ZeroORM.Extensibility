using System;

namespace ZeroORM.Extensibility.Metadata.Exceptions
{
	/// <summary>
	/// Marker parent type for metadata excpetions
	/// </summary>
	public abstract class MetadataException : ZeroORMException
	{
		public MetadataException() { }
		public MetadataException(string message) : base(message) { }
		public MetadataException(string message, Exception inner) : base(message, inner) { }
	}
}
