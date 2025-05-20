using Atomic.Elements;
using Atomic.Entities;
using UnityEngine;

namespace SampleGame
{
    public sealed class DeathAudioBehaviour : IEntityInit, IEntityDispose
    {
        private AudioSource _audioSource;        
        private IEvent<int> _healthEvent;

        private readonly AudioClip[] _clips;        

        public DeathAudioBehaviour(AudioClip[] clips)
        {
            _clips = clips;                        
        }

        public void Init(in IEntity entity)
        {
            _audioSource = entity.GetAudioSource();
            _healthEvent = entity.GetHealthEvent();

            _healthEvent.Subscribe(OnHealthEnded);
        }

        public void Dispose(in IEntity entity)
        {
            _healthEvent.Unsubscribe(OnHealthEnded);
        }

        private void OnHealthEnded(int value)
        {
            if (value <= 0)
            {                
                AudioUseCase.PlayOneShotRandomClip(_audioSource, _clips);
            }            
        }
    }
}
