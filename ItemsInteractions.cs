using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemsInteractions : MonoBehaviour
{
    private void Awake()
    {
        GameManager.managerGame.interactionItems = this;

    }
    public void DetonateEffect(ColliderBridge bridgeCollider)
    {


        StartCoroutine(AvoidFreezeScreen(bridgeCollider));
    }

    private IEnumerator AvoidFreezeScreen(ColliderBridge bridgeCollider)
    {
        yield return new WaitForEndOfFrame();
        WeaponScriptable managerWeaponPlayer = bridgeCollider.gameObject.GetComponent<ProjectileOwner>().gunShooted;
        GameManager.managerGame.damageArea.EffectArea(bridgeCollider.gameObject.transform.position, managerWeaponPlayer.distanceEnemy);


        if (bridgeCollider.gameObject.GetComponent<ProjectileFX>() != null)
        {

            bridgeCollider.gameObject.GetComponent<ProjectileFX>().ProjectileActive(bridgeCollider.gameObject.transform.position, bridgeCollider.gameObject.transform.rotation);
        }


        bridgeCollider.gameObject.SetActive(false);

    }
    public void DamageFall(ColliderBridge bridgeCollider)
    {
        if(bridgeCollider.enterCollider.GetComponent<IDamage>() != null)
        {
            bridgeCollider.enterCollider.gameObject.GetComponent<IDamage>().ReceiveDamage(10000);
        }
    }

}
