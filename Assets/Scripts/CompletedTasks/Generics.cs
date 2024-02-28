using System;
using System.Collections.Generic;
using UnityEngine;

namespace MainPlayer.UnityEngine
{
    public class SoundManager<T> where T : MonoBehaviour
    {
        private static SoundManager<T> instance;

        public static SoundManager<T> Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new SoundManager<T>();
                }

                return instance;
            }
        }

        public void PlaySound(AudioClip audioClip)
        {
            Debug.Log("Playing sound: " + audioClip.name);
        }
        public void StopSound<TAudioSource>(TAudioSource audioSource) where TAudioSource : Component
        {
            // Логіка для зупинки звуку
            Debug.Log("Stopping sound from source: " + audioSource.name);
        }
    }

    public class AudioPlayer<T> : MonoBehaviour where T : MonoBehaviour
    {
        private SoundManager<T> soundManager;

        private void Awake()
        {
            soundManager = SoundManager<T>.Instance;
        }

        public void PlaySound(AudioClip audioClip)
        {
            soundManager.PlaySound(audioClip);
        }
        public void StopSound(Component audioSource)
        {
            soundManager.StopSound(audioSource);
        }
    }
}