using Microsoft.EntityFrameworkCore.Storage;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Team9.Connect4.PL;

namespace Team9.Connect4.BL.Test
{
    [TestClass]
    public class utPlayer
    {
        protected Connect4Entities dc;
        protected IDbContextTransaction transaction;

        [TestInitialize]
        public void TestInitialize()
        {
            dc = new Connect4Entities();
            transaction = dc.Database.BeginTransaction();
        }

        [TestCleanup]
        public void TestCleanup()
        {
            transaction.Rollback();
            transaction.Dispose();
        }

        [TestMethod]
        public void InsertTest()
        {
            Task.Run(async () =>
            {
                tblPlayer newrow = new tblPlayer();

                newrow.Id = Guid.NewGuid();
                newrow.Username = "testUser";
                newrow.Password = "password";
                newrow.SettingId = Guid.NewGuid();

                dc.tblPlayers.Add(newrow);
                int results = dc.SaveChanges();

                Assert.AreEqual(1, results);
            });
        }

        [TestMethod]
        public void UpdateTest()
        {
            tblPlayer row = (from dt in dc.tblPlayers
                             where dt.Username == "testUser"
                             select dt).FirstOrDefault();
            if(row != null)
            {
                row.Password = "newPassword";

                int results = dc.SaveChanges();
                Assert.IsTrue(results == 1);
            }
        }

        [TestMethod]
        public void DeleteTest()
        {
            tblPlayer row = (from dt in dc.tblPlayers
                             where dt.Username == "testUser"
                             select dt).FirstOrDefault();
            if (row != null)
            {
                dc.tblPlayers.Remove(row);

                var results = dc.SaveChanges();
                Assert.AreEqual(results, 1);
            }
        }
    }
}
