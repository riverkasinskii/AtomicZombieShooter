using UnityEngine;

public static class AudioUseCase
{
    private static AudioClip GetRandomClip(in AudioClip[] clips)
    {
        var index = Random.Range(0, clips.Length);
        return clips[index];
    }

    public static void PlayOneShotRandomClip(in AudioSource audioSource, in AudioClip[] clips)
    {
        audioSource.PlayOneShot(GetRandomClip(clips));        
    }

    public static void PlayOneShot(in AudioSource audioSource, in AudioClip clip)
    {
        audioSource.PlayOneShot(clip);
    }
}
