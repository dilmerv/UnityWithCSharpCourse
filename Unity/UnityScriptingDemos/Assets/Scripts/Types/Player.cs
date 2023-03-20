using System;
using UnityEngine;

namespace Assets.Scripts.Types
{
    [Serializable]
    public class Player
    {
        [field: SerializeField]
        [Tooltip("Player Id")]
        public int Id { get; set; }

        [field: SerializeField]
        [Tooltip("Player Email")]
        public string Email;

        [field: SerializeField]
        [Tooltip("Player First Name")]
        public string FirstName;

        [field: SerializeField]
        [Tooltip("Player Last Name")]
        public string LastName;

        [field: SerializeField]
        [TextArea(5, 10)]
        [Tooltip("Player Notes")]
        public string notes;

        [Space]
        [Header("Minimun Player Requirements")]

        [field: SerializeField]
        [Range(18, 120)]
        [Tooltip("Minimun player age")]
        public int MinAge = 18;

        [field: SerializeField]
        [Tooltip("Where players are allowed to play from")]
        public CountryAllowed CountryAllowed = CountryAllowed.None;
    }
}
