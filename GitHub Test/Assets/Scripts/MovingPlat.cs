using UnityEngine;

public class MovingPlat : MonoBehaviour
{
    public Transform platform, orgion, target;
    [SerializeField] private bool movingTowardsTarget;
    [SerializeField] private float lerpTime, platformSpeed;

    private void Start()
    {
        platform.position = orgion.position;
    }

    private void Update()
    {
        if(movingTowardsTarget)
        {
            lerpTime += Time.deltaTime * platformSpeed;
            lerpTime = Mathf.Clamp(lerpTime, 0, 1);

            platform.position = Vector3.Lerp(orgion.position, target.position, lerpTime);
            if(lerpTime >=1)
            {
                movingTowardsTarget = false;
                lerpTime = 0;
            }
        }
        else
        {
            lerpTime += Time.deltaTime * platformSpeed;
            lerpTime = Mathf.Clamp(lerpTime, 0, 1);

            platform.position = Vector3.Lerp(target.position, orgion.position, lerpTime);
            if (lerpTime >= 1)
            {
                movingTowardsTarget = true;
                lerpTime = 0;
            }
        }
    }
}
