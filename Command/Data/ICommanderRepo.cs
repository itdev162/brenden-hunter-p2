using System.Collections.Generic;
using Command.Models;

namespace Commander.Data{
    
    public interface ICommanderRepo{

        IEnumerable<Command> GetAppCommands();
        Command GetCommandById(int id);
    }
}