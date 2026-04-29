using NUnit.Framework.Constraints;
using UnityEngine;

public enum PowerUpType { None, Pushback, Rockets, Smash }



public class PowerUp : MonoBehaviour
{
    public PowerUpType powerUpType;
}
