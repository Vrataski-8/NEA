using System.Collections.Generic;
using UnityEngine;

namespace CardDefiner
{
    [CreateAssetMenu(fileName = "New Card", menuName = "Card")]  
    public class Card : ScriptableObject
    {
        public string cardName;
        public CardType cardType;
        public int damage;
        public int healing;
        public int magLoading;
        public bool shoot;
        public int lockCardQuantity; 
        public Sprite cardSprite;
        public Sprite cardTypeImage;
        public List<ControlType> controlType;
        public Sprite[] controlTypeSprites;
        public enum ControlType
        {
            None,
            Stun,
            Lock,
            Sabotage
        }

        public enum CardType
        {
            Rock,
            Paper,
            Scissors
        }
    }
}