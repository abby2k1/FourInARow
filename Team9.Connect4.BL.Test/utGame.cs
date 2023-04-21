using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using Team9.Connect4.BL.Models;

namespace Team9.Connect4.BL.Test
{
    [TestClass]
    public class utGame
    {
        [TestMethod]
        public void LoadTest()
        {
            Task.Run(async () =>
            {
                var task = await GameManager.Load();
                IEnumerable<Models.Game> games = task;
                Assert.IsTrue(games.Count() > 0);
            }).GetAwaiter().GetResult();

        }

        //[TestMethod]
        //public void InsertTest()
        //{
        //    Task.Run(async () =>
        //    {
        //        Models.Vehicle vehicle = new Models.Vehicle();

        //        var task1 = await ColorManager.Load();
        //        IEnumerable<Models.Color> colors = task1;

        //        vehicle.ColorId = colors.LastOrDefault().Id;
        //        vehicle.MakeId = makes.LastOrDefault().Id;
        //        vehicle.ModelId = models.LastOrDefault().Id;
        //        vehicle.VIN = "NEWVIN";
        //        vehicle.Year = 1987;

        //        int results = await VehicleManager.Insert(vehicle, true);
        //        Assert.IsTrue(results > 0);

        //    });

        //}

        [TestMethod]
        public void UpdateTest()
        {
            Task.Run(async () =>
            {
                var task = await GameManager.Load();
                IEnumerable<Models.Game> games = task;
                Models.Game game = games.FirstOrDefault(c => c.Turns == 10);
                game.Turns = 12;
                int results = await GameManager.Update(game, true);
                Assert.IsTrue(results > 0);

            });

        }


        [TestMethod]
        public void DeleteTest()
        {
            Task.Run(async () =>
            {
                var task = await GameManager.Load();
                IEnumerable<Game> games = task;
                Game game = games.FirstOrDefault(c => c.Turns == 10);
                int results = await GameManager.Delete(game.Id, true);
                Assert.IsTrue(results > 0);

            });
        }
    }
}
