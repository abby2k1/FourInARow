using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Team9.Connect4.BL.Models;
using Team9.Connect4.API;
using Team9.Connect4.API.Test;

namespace Team9.Connect4.API.Test
{
    [TestClass]
    public class utPlayer : utBase
    {
        [TestMethod]
        public async Task LoadTestAsync()
        {
            await base.LoadTestAsync<Player>();
        }

        [TestMethod]
        public async Task InsertTestAsync()
        {
            Player player = new Player
            {
                Id = Guid.NewGuid(),
                Username = "Test",
                Password = "password",
                SettingId = Guid.NewGuid()
            };
            await base.InsertTestAsync<Player>(player);
        }

        [TestMethod]
        public async Task DeleteTestAsync()
        {
            await base.DeleteTestAsync<Player>(new KeyValuePair<string, string>("Username", "Test"));
        }

        [TestMethod]
        public async Task UpdateTestAsync()
        {
            Player player = new Player
            {
                Id = Guid.NewGuid(),
                Username = "UpdateTest",
                Password = "password",
                SettingId = Guid.NewGuid()
            };
            await base.UpdateTestAsync<Player>(new KeyValuePair<string, string>("Password", "UpdatedPassword"), player);
        }

    }
}
