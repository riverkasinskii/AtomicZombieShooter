using Atomic.Elements;
using Atomic.Entities;
using UnityEngine;

namespace SampleGame
{
    public sealed class PistolAudioBehaviour : IEntityInit, IEntityDispose
    {
        private IEvent _fireEvent;

        private readonly AudioSource _audiosource;

        public PistolAudioBehaviour(AudioSource audioSource)
        {
            _audiosource = audioSource;
        }

        public void Init(in IEntity entity)
        {
            _fireEvent = entity.GetFireEvent();

            _fireEvent.Subscribe(OnFired);
        }

        public void Dispose(in IEntity entity)
        {
            _fireEvent.Unsubscribe(OnFired);
        }

        private void OnFired()
        {
            _audiosource.pitch = GetRandomPitch();            
            _audiosource.Play();
        }

        private float GetRandomPitch() 
            => Random.Range(0.9f, 1.1f);
    }
}
