using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using NUnit.Framework;

namespace Cmd.Tests
{
    public class CmdInputTests
    {
        CmdPool cmd;

        public void Init()
        {
            IDBService svc = new FakeDbService();
            cmd = new CmdPool(svc);
        }
        [Test]
        public void AddNewEntry_TenAdded()
        {
            const int EXPECTED_ENTRIES = 1;
            LineEntry e = LineEntry.CreateFake();

            cmd.cmdInput.AddNewEntry(e);
            Assert.AreEqual(EXPECTED_ENTRIES, cmd.cmdInput.GetNumberEntries());
        }

    }
}
