using Atomic.Entities;
using Modules.Gameplay;
using UnityEngine;

namespace SampleGame
{
    public sealed class MoveAudioBehaviour : IEntityInit, IEntityUpdate
    {
        private AudioSource _audioSource;

        private readonly AudioClip[] _clips;
        private readonly Cooldown _cooldown;

        public MoveAudioBehaviour(AudioClip[] clips, Cooldown cooldown)
        {
            _clips = clips;
            _cooldown = cooldown;
        }

        public void Init(in IEntity entity)
        {            
            _audioSource = entity.GetAudioSource();            
        }

        public void OnUpdate(in IEntity entity, in float deltaTime)
        {
            if (MoveUseCase.IsMoving(entity))
            {
                _cooldown.Tick(deltaTime);
                if (!_cooldown.IsExpired())
                {
                    return;
                }

                AudioUseCase.PlayOneShotRandomClip(_audioSource, _clips);
                _cooldown.Reset();                
            }
        }
    }
}
