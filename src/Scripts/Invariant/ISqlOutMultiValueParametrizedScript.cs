using ZeroORM.Extensibility.Scripts.Granular;

namespace ZeroORM.Extensibility.Scripts.Invariant
{
	public interface ISqlOutMultiValueParametrizedScript<TParameters, TValue> : ISqlRawScript, ISqlOutMultiValueScript<TValue>, ISqlParametrizedScript<TParameters>
	{
	}
}
