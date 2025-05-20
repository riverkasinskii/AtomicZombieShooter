using Atomic.Entities;
using SampleGame;
using UnityEngine;

public sealed class WeaponVisualInstaller : SceneEntityInstaller
{
    [SerializeField]
    private ParticleSystem _fireVfx;

    [SerializeField]
    private AudioSource _audioSource;

    public override void Install(IEntity entity)
    {
        entity.AddBehaviour(new PistolVfxBehaviour(_fireVfx));
        entity.AddBehaviour(new PistolAudioBehaviour(_audioSource));
    }
}
