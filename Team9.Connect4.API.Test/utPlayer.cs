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
                // This is going to update with every publish, and will need to be changed
                SettingId = new Guid("ff15f9c8-166c-4a9e-a178-0df5f68474a6")
            };
            await base.InsertTestAsync<Player>(player);
        }

        [TestMethod]
        public async Task DeleteTestAsync()
        {
            await base.DeleteTestAsync<Player>(new KeyValuePair<string, string>("Id", "98f9d6bf-f18c-4280-9ac0-8fba8768940b"));
        }

        [TestMethod]
        public async Task UpdateTestAsync()
        {
            Player player = new Player
            {
                Username = "UpdatedPlayer",
                Password = "Maple",
                SettingId = new Guid("ff15f9c8-166c-4a9e-a178-0df5f68474a6")
            };

            await base.UpdateTestAsync<Player>(new KeyValuePair<string, string>("Username", "AbbieProudlock"), player);
        }

    }
}
