//TODO: Uncomment me
using System;
using UnityEngine;
using Random = UnityEngine.Random;

namespace Game.Gameplay
{
    public sealed class PainSoundBehaviour         
    {        
        [Serializable]
        public struct Level
        {
            [SerializeField, Range(0.01f, 1.0f)]
            public float percent;

            [SerializeField]
            public AudioClip[] clips;

            public readonly AudioClip RandomClip()
            {
                var index = Random.Range(0, this.clips.Length);
                return this.clips[index];
            }
        }
    }
}