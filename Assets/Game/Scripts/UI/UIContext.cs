using Atomic.Contexts;

namespace SampleGame
{
    public interface IUIContext : IContext
    {
    }

    public sealed class UIContext : SceneContext, IUIContext
    {
    }
}
