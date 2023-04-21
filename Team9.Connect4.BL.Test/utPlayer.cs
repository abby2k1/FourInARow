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
                Models.Player player = new Models.Player();

                player.Username = "testUser";
                player.Password = "password";
                player.Id = Guid.NewGuid();
                player.SettingId = Guid.NewGuid();

                int results = await PlayerManager.Insert(player, true);
                Assert.IsTrue(results > 0);
            });
        }

        [TestMethod]
        public void UpdateTest()
        {
            Task.Run(async () =>
            {
                var task = await PlayerManager.Load();
                IEnumerable<Models.Player> players = task;
                Models.Player player = players.FirstOrDefault(p => p.Username == "testUser");
                player.Password = "newPassword";
                int results = await PlayerManager.Update(player, true);
                Assert.IsTrue(results > 0);
            });
        }

        [TestMethod]
        public void DeleteTest()
        {
            Task.Run(async () =>
            {
                var task = await PlayerManager.Load();
                IEnumerable<Models.Player> players = task;
                Models.Player player = players.FirstOrDefault(p => p.Username == "testUser");
                int results = await PlayerManager.Delete(player.Id, true);
                Assert.IsTrue(results > 0);
            });
        }
    }
}
