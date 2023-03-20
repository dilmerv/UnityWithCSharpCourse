using System;
using UnityEngine.Events;

namespace Assets.Scripts.Events
{
    [Serializable]
    public class UnityEventForEnemyCloseBy : UnityEvent<string, float>
    {}

    [Serializable]
    public class UnityEventForEnemyWithNameCloseBy : UnityEvent<string>
    { }
}
