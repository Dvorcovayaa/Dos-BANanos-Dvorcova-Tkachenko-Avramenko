using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CoinCounter : MonoBehaviour
{
    static public int coinCount; //Êîë-âî ìîíåòîê
    public Text Text; //Ïóáëè÷íîå ïîëå ñ òåêñòîì

    void Start() //Îáðàáàòûâàåòñÿ ïåðåä îòðèñîâêîé êàäðà
    {
        coinCount = 0; //Îïðåäåëÿåì íà÷àëüíîå êîë-âî ìîíåòîê
    }
    void OnTriggerEnter(Collider Collider) //Ïðè ñðàáàòûâàíèè òðèããåðà
    {
        if (Collider.CompareTag("Coin")) //Åñëè îáúåêò ñ òðèããåðîì èìååò òýã "Coin"
        {
            Collider.gameObject.GetComponent<Collider>().enabled = false; //Îòêëþ÷àåì åãî êîëëàéäåð
            Destroy(Collider.gameObject); //Óíè÷òîæàåì åãî
            coinCount++; //Ïðèáàâëÿåì ìîíåòêó
            Text.text = coinCount.ToString(); //Çàïèñûâàåì â ñ÷åò÷èê
            if (coinCount%10 == 0) //Åñëè êîëè÷åñòâî ìîíåòîê êðàòíî 10
            {
                HealthCounter.healthCount++; //Äîáàâëÿåì ê ÕÏ åäèíèöó
                HealthCounter.FindObjectOfType<Text>().text = HealthCounter.healthCount.ToString(); //Çàïèñûâàåì â ñ÷åò÷èê( По какой-то причине перстало работать))) )
            }
        }

    }
}
