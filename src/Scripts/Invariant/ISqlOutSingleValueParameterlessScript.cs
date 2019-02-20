using ZeroORM.Extensibility.Scripts.Granular;

namespace ZeroORM.Extensibility.Scripts.Invariant
{
	public interface ISqlOutSingleValueParameterlessScript<TValue> : ISqlRawScript, ISqlOutSingleValueScript<TValue>, ISqlParameterlessScript
	{
	}
}
