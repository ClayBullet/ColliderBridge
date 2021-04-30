using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyInteractions : MonoBehaviour
{
    
    public void ExplossionEffect()
    {

    }

    public void PlayerDamageHealth_EnterCollider(ColliderBridge bridgeCollider)
    {
        PlayerAvailable avPlayer = bridgeCollider.enterCollider.gameObject.GetComponent<PlayerAvailable>();
        if (avPlayer != null && !avPlayer.freezePlayerChronometerBool)
        {
          avPlayer.GetComponent<IDamage>().ReceiveDamage(200f);
        }
        else
        {
            bridgeCollider.enterCollider.GetComponent<IDamage>().ReceiveDamage(200f);
        }
    }
}
