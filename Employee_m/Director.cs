using System;
namespace Employee
{
    public class Director : Worker
    {
        private string _name;
        private double _wage;
        private int _subordinates;

        public Director(string name, double wage, int subordinates)
        {
            _name = name;
            _wage = wage;
            _subordinates = subordinates;
        }

        public override string Position()
        {
             return "Director";
        }

        public override string Name()
        {

            return _name;

        }
        public override double Wage()
        {
            return _wage;
        }
        public override int Subordinates()
        {
            return _subordinates;
        }
        public override string LevelOfResponsibility()
        {
            return "Responsible for the whole company";
        }


    }
    
}
