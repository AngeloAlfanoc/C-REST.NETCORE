using System.Collections.Generic;
using Commander.Models;

namespace Commander.Data
{
    public class MockCommanderRepo : ICommanderRepo
    {
        public void CreateCommand(Command cmd)
        {
            throw new System.NotImplementedException();
        }

        public IEnumerable<Command> GetAllCommands()
        {
            var commands = new List<Command>
            {
                new Command{Id=0, HowTo="White", Line="Boil water", Platform="Kettle & pan"},
                new Command{Id=1, HowTo="Knife and chopping board", Line="sdfsdf", Platform="Kettle & pan"},
                new Command{Id=2, HowTo="Make Cup of Tea", Line="sdf", Platform="Kettle & pan"},
            };

            return commands;
        }

        public Command GetCommandById(int id)
        {
           return new Command{Id=0, HowTo="Boil an egg", Line="Boil Water", Platform="Kettle & pan"};
        }

        public bool SaveChanges()
        {
            throw new System.NotImplementedException();
        }
    }
}