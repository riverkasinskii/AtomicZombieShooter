using Atomic.Elements;
using Atomic.Entities;
using Game.Gameplay;
using UnityEngine;

namespace SampleGame
{
    public sealed class CharacterTakeDamageAudioBehaviour : IEntityInit, IEntityDispose
    {
        private readonly PainSoundBehaviour.Level[] _takeDamageClips;
        private AudioSource _audioSource;

        private IEvent<int> _healthEvent;

        public CharacterTakeDamageAudioBehaviour(PainSoundBehaviour.Level[] takeDamageClips)
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
            AudioUseCase.PlayOneShot(_audioSource, _takeDamageClips[GetRandomIndex()].RandomClip());
        }

        private int GetRandomIndex()
        {
            return Random.Range(0, _takeDamageClips.Length);
        }
    }
}