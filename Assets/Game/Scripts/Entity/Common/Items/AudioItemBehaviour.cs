using Atomic.Elements;
using Atomic.Entities;
using UnityEngine;

namespace SampleGame
{
    public sealed class AudioItemBehaviour : IEntityInit, IEntityDispose
    {   
        private readonly AudioSource _audioSource;
        private IEvent _pickUpEvent;

        public AudioItemBehaviour(AudioSource audioSource) 
        {
            _audioSource = audioSource;
        }

        public void Init(in IEntity entity)
        {
            _pickUpEvent = entity.GetPickUpEvent();
            _pickUpEvent.Subscribe(OnPickUpEvent);
        }

        public void Dispose(in IEntity entity)
        {
            _pickUpEvent.Unsubscribe(OnPickUpEvent);
        }

        private void OnPickUpEvent()
        {            
            _audioSource.Play();
        }
    }
}
