public abstract class Hero
{
    public Hero(string name)
    {
        Name = name;
    }
    public string Name { get; set; }
    public int Level { get; set; } 
    public int Experience { get; set; } 

    void SelectClass(int i)
    {

    }

    void UseAbility(Ability ability, Hero target)
    {

    }

    void LevelUp(int xp)
    {
        Level += (Experience + xp)/100;
        Experience = (Experience + xp)%100;
    }

    public virtual void GenerateAbilities()
    {

    }

    public override string ToString()
    {
        return $"{Name}, a  at level {Level}";
    }
}