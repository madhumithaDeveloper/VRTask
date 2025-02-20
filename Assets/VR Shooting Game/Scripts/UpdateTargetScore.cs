using UnityEngine;

public class UpdateTargetScore : MonoBehaviour
{
    public Transform shootingTarget;
    public Transform bullseyeTransform;
    public Transform midRingTrandform;
    public Transform outerRingTransform;
    public int bullseyeScore = 50;
    public int midRingScore = 25;
    public int outerRingScore = 10;

    float distanceFromCenter;
    float bullseyeThrehold;
    float midRingThrehold;
    float outerRingThrehold;

    public void Awake()
    {
        bullseyeThrehold = Vector3.Distance(shootingTarget.transform.position, bullseyeTransform.transform.position);
        midRingThrehold = Vector3.Distance(bullseyeTransform.transform.position, midRingTrandform.transform.position);
        outerRingThrehold = Vector3.Distance(midRingTrandform.transform.position, outerRingTransform.transform.position);
    }


    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.CompareTag("Bullet"))
        {
            AudioSource.PlayClipAtPoint(TargetHitFeedback.instance.bulletHitAudioClip, other.transform.position);
            TargetHitFeedback.instance.targetHitParticle.position = other.transform.position;
            TargetHitFeedback.instance.decalEffect.Play();
            distanceFromCenter = Vector3.Distance(other.transform.position, shootingTarget.transform.position);
            CheckHitTargetScore();
        }
    }


    public void CheckHitTargetScore()
    {
        if (distanceFromCenter < bullseyeThrehold)
        {
            ScoreManager.instance.UpdateScore(bullseyeScore);
        }
        else if (distanceFromCenter > bullseyeThrehold && distanceFromCenter < midRingThrehold)
        {
            ScoreManager.instance.UpdateScore(midRingScore);
        }
        else if (distanceFromCenter > midRingThrehold && distanceFromCenter < outerRingThrehold)
        {
            ScoreManager.instance.UpdateScore(outerRingScore);
        }
    }
}
