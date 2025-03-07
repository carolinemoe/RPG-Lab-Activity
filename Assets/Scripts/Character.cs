using UnityEngine;

public class Character
{
    string characterName;
    GameObject character;
    AbilityScores AbScores;

    public Character (string name, GameObject thisCharacter, AbilityScores scores)
    {
        characterName = name;
        character = thisCharacter;
        AbScores = scores;
    }

    public int GetAbilityScoreBonus(AbilityScoreNames abilityName)
    {
        // int bonus;
        // int value = AbScores.(abilityName);
        // bonus = checkBonus(value);
        if(abilityName == AbilityScoreNames.Strength){
            return AbScores.Strength;
        }
    }

    
}

public int getBonus(int value)
{
    int bonus = 0;
    if(value == 0 || value == 1 || value == 2){
            bonus = -1;
        }
        else if(value == 3 || value == 4){
            bonus = 0;
        }
        else if(value == 5 || value == 6){
            bonus = 1;
        }
        else if(value == 7 || value == 8){
            bonus = 2;
        }
        else if(value == 9 || value == 10){
            bonus = 3;
        }
    return bonus;
}

public struct AbilityScores
{
    int Strength;
    int Dexterity;
    int Constitution;
    int Intelligence;
    int Wisdom;
    int Charisma;
    
}

