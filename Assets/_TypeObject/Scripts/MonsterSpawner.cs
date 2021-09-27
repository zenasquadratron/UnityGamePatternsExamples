using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MonsterSpawner : MonoBehaviour
{
    private MonsterType dragon;
    private MonsterType troll;

    public BreedData[] breeds;

    private List<MonsterType> monsters = new List<MonsterType>();

    // Start is called before the first frame update
    void Start()
    {
        dragon = new MonsterType(new Breed("Dragon", 230, "breathes fire!"));
        //Debug.Log("A " + dragon.GetName() + " has spawned.");
        monsters.Add(dragon);


        troll = new MonsterType(new Breed("Troll", 56, "clubs you."));
        //Debug.Log("A " + troll.GetName() + " has spawned.");
        monsters.Add(troll);

        foreach (BreedData bd in breeds)
        {
            int randomCount = Random.Range(0, 20);

            Breed breed = new Breed(bd.BreedName, bd.Health, bd.Attack);
            MonsterType monster = new MonsterType(breed);

            for (int i = 0; i < randomCount; i++)
            {
                monsters.Add(monster);
            }
        }

        foreach (MonsterType mt in monsters)
        {
            
            Debug.Log("A " + mt.GetName() + " has spawned.");
        }
    }

    // Update is called once per frame
    void Update()
    {
        TestAttacks();
    }

    void TestAttacks()
    {
        if (Input.GetKeyDown(KeyCode.A))
        {
            int randomMonster = Random.Range(0, monsters.Count);

            string attackMessage = monsters[randomMonster].GetAttack();

            Debug.Log(attackMessage);
        }
    }
}
