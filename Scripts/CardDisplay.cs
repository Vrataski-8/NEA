using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using CardDefiner;

public class CardDisplay : MonoBehaviour
{
    public Card cardData;
    public Image cardImage;
    public TMP_Text nameText;
    public TMP_Text healingText;
    public TMP_Text damageText;
    public TMP_Text lockText;
    public TMP_Text ammoText;
    public Image cardType;
    public Image healingImage;
    public Image damageImage;
    public Image reloadImage;
    public Image[] controlTypeImages;

    void Start()
    {
        UpdateCardDisplay();
    }

    public void UpdateCardDisplay()
    {
        
        //ensures that only the necessary data is being shown to prevent clutter on the card sprite
        if (cardData.magLoading != 0)
        {
            ammoText.gameObject.SetActive(true);
            reloadImage.gameObject.SetActive(true);
            ammoText.text = cardData.magLoading.ToString();
        }

        if (cardData.healing > 0)
        {
            healingText.gameObject.SetActive(true);
            healingImage.gameObject.SetActive(true);
            healingText.text = cardData.healing.ToString();
        }

        if (cardData.damage > 0)
        {
            damageText.gameObject.SetActive(true);
            damageImage.gameObject.SetActive(true);
            damageText.text = cardData.damage.ToString();
        }

        if (cardData.lockCardQuantity > 0)
        {
            lockText.gameObject.SetActive(true);
            lockText.text = cardData.lockCardQuantity.ToString();
        }
        
        nameText.text = cardData.cardName;
        lockText.text = cardData.lockCardQuantity.ToString();
        cardType.sprite = cardData.cardTypeImage;

        //Update Control Type Images
        for (int i = 0; i < controlTypeImages.Length; i++)
        {
            if (i < cardData.controlType.Count)
            {
                controlTypeImages[i].gameObject.SetActive(true);
                controlTypeImages[i].sprite = cardData.controlTypeSprites[i];
            }
            else
            {
                controlTypeImages[i].gameObject.SetActive(false);
            }
        }
    }
}