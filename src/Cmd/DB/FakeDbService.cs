using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Cmd
{
    public class FakeDbService : IDBService
    {
        int iEntries = 0;
        public bool AddNewEntry(LineEntry e)
        {
            if (e == null)
                return false;

            iEntries++;
            lst.Add(e);
            Console.WriteLine("adding entry:" + e.FirstName);
            return true;
        }
        List<LineEntry> lst;


        public bool Connect()
        {
            lst = new List<LineEntry>();

            return true;
        }

        public int GetNumberEntries()
        {
            return this.iEntries;
        }
        public List<LineEntry> GetEntries()
        {
            return this.lst;
        }

        public bool ClearDatabase()
        {
            this.lst.Clear();
            return true;
        }
    }
}
