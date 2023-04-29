using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Team9.Connect4.BL.Models;
using Team9.Connect4.API;
using System.Drawing;

namespace Team9.Connect4.API.Test
{
    [TestClass]
    public class utSetting : utBase
    {
        [TestMethod]
        public async Task LoadByIdTestAsync()
        {
            await base.LoadByIdTestAsync<Setting>(KeyValuePair.Create<string, string>("BoardColor", "#FFFFFF"));
        }

        [TestMethod]
        public async Task InsertTestAsync()
        {
            Setting setting = new Setting
            {
                Id = Guid.NewGuid(),
                PlayerColor = Color.White,
                OpponentColor = Color.Black,
                BoardColor = Color.Beige
            };
            await base.InsertTestAsync<Setting>(setting);
        }

        [TestMethod]
        public async Task DeleteTestAsync()
        {
            await base.DeleteTestAsync<Setting>(new KeyValuePair<string, string>("BoardColor", "#FFFFFF"));
        }

        [TestMethod]
        public async Task UpdateTestAsync()
        {
            Setting setting = new Setting
            {
                Id = Guid.NewGuid(),
                PlayerColor = Color.White,
                OpponentColor = Color.Black,
                BoardColor = Color.Beige
            };
            await base.UpdateTestAsync<Setting>(new KeyValuePair<string, string>("BoardColor", "#FFFFFF"), setting);
        }
    }
}
