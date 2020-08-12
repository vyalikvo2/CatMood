using CatSimulator.Utils;
using CatSimulator.Data;
using TMPro;
using UnityEngine;

namespace CatSimulator.UI
{
    public class InfoPanel : MonoBehaviour
    {
        private const string COLOR_GREEN = "#31FF40";
        private const string COLOR_ORANGE= "#FFB431";
        private const string COLOR_RED= "#FF3159";
        
        [SerializeField] private TMP_Text textFieldMood;
        [SerializeField] private TMP_Text textFieldReaction;

        void Start()
        {
            textFieldMood.RecalculateRectTransform(); 
            textFieldReaction.RecalculateRectTransform();
        }
        
        // -----------------------------------------------------------------
        public void SetMood(CatMood mood)
        {
            textFieldMood.text = CatStrings.GetByMood(mood);
            textFieldMood.RecalculateRectTransform();

            SetMoodFieldColor(mood);
        }
        
        // -----------------------------------------------------------------
        public void SetReaction(CatReaction reaction)
        {
            textFieldReaction.text = CatStrings.GetByReaction(reaction);
            textFieldReaction.RecalculateRectTransform();
        }
        
        // -----------------------------------------------------------------
        private void SetMoodFieldColor(CatMood mood)
        {
            string colorString;
            
            switch (mood)
            {
                case CatMood.BAD:
                    colorString = COLOR_RED;
                    break;
                case CatMood.GOOD:
                    colorString = COLOR_ORANGE;
                    break;
                case CatMood.EXCELLENT:
                    colorString = COLOR_GREEN;
                    break;
                default:
                    colorString = COLOR_GREEN;
                    break;
            }
            
            Color moodTextColor;
            if (ColorUtility.TryParseHtmlString(colorString, out moodTextColor))
                textFieldMood.color = moodTextColor;
        }
    }
    
}


