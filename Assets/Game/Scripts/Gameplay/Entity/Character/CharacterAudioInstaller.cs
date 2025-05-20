using Atomic.Entities;
using Modules.Gameplay;
using SampleGame;
using UnityEngine;
using UnityEngine.Serialization;

namespace Game.Gameplay
{
    public sealed class CharacterAudioInstaller : SceneEntityInstaller
    {
        [SerializeField]
        private AudioSource _audioSource;
        
        [FormerlySerializedAs("_damageLevels")]
        [SerializeField]
        private PainSoundBehaviour.Level[] _painLevels;

        [SerializeField]
        private AudioClip[] _deathClips;

        [SerializeField]
        private AudioClip[] _moveStepClips;

        [SerializeField]
        private AudioClip _bodyFallClip;

        [SerializeField]
        private AudioClip _meleeDamageClip;

        [SerializeField]
        private AudioClip _bulletDamageClip;

        [SerializeField]
        private float _moveStepDuration = 0.3f;

        public override void Install(IEntity entity)
        {
            entity.AddAudioSource(_audioSource);
            entity.AddBehaviour(new MoveAudioBehaviour(_moveStepClips, new Cooldown(_moveStepDuration, _moveStepDuration)));
            entity.AddBehaviour(new DeathAudioBehaviour(_deathClips));
            entity.AddBehaviour(new CharacterTakeDamageAudioBehaviour(_painLevels));
        }
    }
}