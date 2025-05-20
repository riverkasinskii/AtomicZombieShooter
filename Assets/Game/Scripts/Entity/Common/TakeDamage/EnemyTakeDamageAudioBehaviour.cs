using Atomic.Elements;
using Atomic.Entities;
using UnityEngine;

namespace SampleGame
{
    public sealed class EnemyTakeDamageAudioBehaviour : IEntityInit, IEntityDispose
    {
        private readonly AudioClip[] _takeDamageClips;
        private AudioSource _audioSource;

        private IEvent<int> _healthEvent;

        public EnemyTakeDamageAudioBehaviour(AudioClip[] takeDamageClips)
        {
            _takeDamageClips = takeDamageClips;
        }

        public void Init(in IEntity entity)
        {
            _audioSource = entity.GetAudioSource();
            _healthEvent = entity.GetHealthEvent();

            _healthEvent.Subscribe(OnTakeDamage);
        }

        public void Dispose(in IEntity entity)
        {
            _healthEvent.Unsubscribe(OnTakeDamage);
        }

        private void OnTakeDamage(int value)
        {
            AudioUseCase.PlayOneShotRandomClip(_audioSource, _takeDamageClips);
        }
    }
}