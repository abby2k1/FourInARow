using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Team9.Connect4.BL.Models;
using Team9.Connect4.API.Test;

namespace Team9.Connect4.API.Test
{
    [TestClass]
    public class utGame : utBase
    {
        [TestMethod]
        public async Task LoadTestAsync()
        {
            await base.LoadTestAsync<Game>();
        }

        //[TestMethod]
        //public async Task InsertTestAsync()
        //{
        //    Game game = new Game { Id = new Guid(), WinnerId = new Guid(), LoserId = new Guid(), Turns = 4 };
        //    await base.InsertTestAsync<Game>(game);
        //}

        [TestMethod]
        public async Task DeleteTestAsync()
        {
            await base.DeleteTestAsync<Game>(new KeyValuePair<string, string>("Turns", "10"));
        }

        //[TestMethod]
        //public async Task UpdateTestAsync()
        //{
        //    Game game = new Game { Turns = 12 };
        //    await base.UpdateTestAsync<Game>(new KeyValuePair<string, string>("Turns", "10"), game);
        //}
    }
}
