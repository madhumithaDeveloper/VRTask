using UnityEngine;

public class TargetHitFeedback : MonoBehaviour
{
    public static TargetHitFeedback instance;

    public Transform targetHitParticle;
    public ParticleSystem muzzleFlashEffect;
    public ParticleSystem decalEffect;

    public AudioSource bulletAudioEffect;
    public AudioClip bulletAudioClip;
    public AudioClip bulletHitAudioClip;


    private void Awake()
    {
        if (instance == null)
            instance = this;
        else
            Destroy(this);
    }
}
