using ZeroORM.Extensibility.Scripts.Granular;

namespace ZeroORM.Extensibility.Scripts.Invariant
{
	public interface ISqlOutMultiValueParameterlessScript<TValue> : ISqlRawScript, ISqlOutMultiValueScript<TValue>, ISqlParameterlessScript
	{
	}
}
