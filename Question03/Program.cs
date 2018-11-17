using System;

namespace Question03
{
    class Program
    {
        static void Main(string[] args)
        {
            var john = new Humanoid(new Dancing());
            Console.WriteLine(john.ShowSkill()); //print dancing
            var alex = new Humanoid(new Cooking());
            Console.WriteLine(alex.ShowSkill());//print cooking
            var bob = new Humanoid();
            Console.WriteLine(bob.ShowSkill());//print no skill is defined
            Console.ReadLine();
        }
    }

    public class Humanoid
    {
        private string _skill;
        public Humanoid()
        {
            _skill = "no skill is defined.";
        }

        public Humanoid(ISkill skill)
        {
            _skill = skill.GetSkill();
        }

        public string ShowSkill()
        {
            return _skill;
        }
    }
    public interface ISkill
    {
        string GetSkill();
    }

    public class Dancing : ISkill
    {
        public string GetSkill()
        {
            return "Dancing";
        }
    }

    public class Cooking : ISkill
    {
        public string GetSkill()
        {
            return "Cooking";
        }
    }


}
