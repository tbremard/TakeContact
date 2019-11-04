using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Cmd
{
    public class CmdPool
    {
        public CmdInput cmdInput;

        public CmdPool(IDBService svc)
        {
            cmdInput = new CmdInput(svc);
        }

       
    }
}
