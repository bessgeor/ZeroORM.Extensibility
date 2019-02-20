using ZeroORM.Extensibility.Scripts.Granular;

namespace ZeroORM.Extensibility.Scripts.Invariant
{
	public interface ISqlOutSingleValueParametrizedScript<TParameters, TValue> : ISqlRawScript, ISqlOutSingleValueScript<TValue>, ISqlParametrizedScript<TParameters>
	{
	}
}
