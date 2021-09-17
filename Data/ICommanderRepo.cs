using System.Collections.Generic;
using Commander.Models;

namespace Commander.Data{
    public interface ICommanderRepo{

        bool SaveChange();
        IEnumerable<Command> GetAppCommands();
        Command GetCommandById(int id);
        void CreateCommand(Command cmd);

        void UpdateCommand(Command cmd);
        
    }
}