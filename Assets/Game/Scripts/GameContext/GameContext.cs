using Atomic.Contexts;

namespace SampleGame
{
    public interface IGameContext : IContext
    {
    }

    public sealed class GameContext : SingletonSceneContext<GameContext>, IGameContext
    {
    }
}
