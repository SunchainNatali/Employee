using System;
namespace Employee
{
    public class Assistant : Worker
    {
        private string _name;
        private double _wage;
        private int _subordinates;

        public Assistant(string name, double wage, int subordinates)
        {
            _name = name;
            _wage = wage;
            _subordinates = subordinates;
        }
        public override string Position()
        {
            return "Assistantss";
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
            return "Responsible for the delivery of materials";
        }
      
    }
}
