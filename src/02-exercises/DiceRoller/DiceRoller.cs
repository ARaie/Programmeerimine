using System;

public class DiceRoller

{
    public List<DiceRoll> Roll(List<Dice> dices)
    {
        var result = new List<DiceRoll>();

        foreach (var dice in dices)
        {
        

            result.Add(new DiceRoll(dice.description, dice.Roll()));
        }
        return result;
    }
    
	
}
