using System.Collections.Generic;

namespace Cmd
{
    public interface IDBService
    {
        bool AddNewEntry(LineEntry e);
        int GetNumberEntries();
        bool Connect();
        List<LineEntry> GetEntries();
        bool ClearDatabase();
    }
}

