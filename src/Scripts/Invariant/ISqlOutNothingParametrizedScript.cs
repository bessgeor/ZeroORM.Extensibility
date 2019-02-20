using ZeroORM.Extensibility.Scripts.Granular;

namespace ZeroORM.Extensibility.Scripts.Invariant
{
	public interface ISqlOutNothingParametrizedScript<TParameters> : ISqlRawScript, ISqlOutNothingScript, ISqlParametrizedScript<TParameters>
	{
	}
}
