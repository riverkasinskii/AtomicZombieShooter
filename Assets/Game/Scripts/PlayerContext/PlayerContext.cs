using Atomic.Contexts;

namespace SampleGame
{
    public interface IPlayerContext : IContext
    {
    }

    public sealed class PlayerContext : SceneContext, IPlayerContext
    {
    }
}
