using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BuildMonsters : MonoBehaviour
{
    public List<MonsterInfo> monsters = new List<MonsterInfo>();

    MonsterInfo monster;

    // Start is called before the first frame update
    void Start()
    {
        string monsterData = "" +
            "{ 'name': 'Demon', 'health': 100, 'attack': 50, 'defence': 60, 'warcry': 'Burn in hellfire!' }, ";

        monster = new MonsterInfo();
        monster = MonsterInfo.CreateFromJSON(monsterData);

        Debug.Log(monster.name);
        Debug.Log(monster.health);
        Debug.Log(monster.attack);
        Debug.Log(monster.defence);
        Debug.Log(monster.warcry);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

[System.Serializable]
public class MonsterInfo
{
    public string name;
    public int health;
    public int attack;
    public int defence;
    public string warcry;

    public static MonsterInfo CreateFromJSON(string jsonString)
    {
        return JsonUtility.FromJson<MonsterInfo>(jsonString);
    }

}
