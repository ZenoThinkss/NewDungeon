namespace NewDungeonClassLibrary
{
    public class Character
    {
        //order matters if you put hp in front of maxhp in props and not in constructor things will go awry

        //Fields- Funny 
        private string _name;
        private int _hitPoints;
        private int _maxHitPoints;
        private int _defense;
        private int _accuracy;


        //Properties - People
        public string Name { get { return _name; } set { _name = value; } }

        public int MaxHitPoints { get { return _maxHitPoints; } set { _maxHitPoints = value; } }

        //ensures that hitpoints cannot be  higher than maxHitPoints 
        public int HitPoints { get { return _hitPoints; } set { _hitPoints = value <= MaxHitPoints ? value : MaxHitPoints; } }

        public int Accuracy { get { return _accuracy; } set { _accuracy = value; } }

        public int Defense { get { return _defense; } set { _defense = value; } }
        

       
         



        //Constructors - Collect 
        public Character(string name, int maxHitPoints, int hitPoints, int defense, int accuracy)
        {
            Name = name;
            MaxHitPoints = maxHitPoints;
            HitPoints = hitPoints;          
            Defense= defense;
            Accuracy= accuracy;
                
        }

        //both a fully qualified constructor and an unqualified/default ctor
        public Character() { }

        //Methods - Monkeys

        public override string ToString()
        {
            return $"---------------------------\n" +
                   $"**********{Name}***********\n" +
                   $"HP: {HitPoints} of {MaxHitPoints}\n" +
                   $"Accuracy: {Accuracy}%\n" +
                   $"Defense: {Defense}\n" +
                   $"----------------------------";

        }

        public int CalcDefense() { return _defense; }

        public int CalcAccuracy() { return _accuracy;}

        public int CalcDamage() { return 0;}


    }
}