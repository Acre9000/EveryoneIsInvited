using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeRateOverTIme : MonoBehaviour
{
    public void RateOverTime(ParticleSystem particleSystem, float newRate)
    {
        var emission = particleSystem.emission;
        emission.rateOverTime = newRate;
    }
    public void RateOverDistance(ParticleSystem particleSystem, float newRate)
    {
        var emission = particleSystem.emission;
        emission.rateOverDistance = newRate;
    }

}
