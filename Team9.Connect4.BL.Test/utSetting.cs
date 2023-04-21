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
    public class utSetting
    {
        protected Connect4Entities dc;

        [TestInitialize]
        public void TestInitialize()
        {
        }

        [TestCleanup]
        public void TestCleanup()
        {
        }

        [TestMethod]
        public void LoadTest()
        {
            Guid guid = dc.tblSettings.GetType().GUID;

            var results = SettingManager.Load(guid);

            Assert.IsNotNull(results);
        }

        [TestMethod]
        public void LoadByPlayerIdTest()
        {
            Guid guid = dc.tblPlayers.FirstOrDefault().SettingId;

            var results = SettingManager.LoadByPlayerId(guid);

            Assert.IsNotNull(results);
        }

        [TestMethod]
        public void InsertTest()
        {
            tblSetting newrow = new tblSetting();

            newrow.Id = new Guid();
            newrow.PlayerColor = "Cornflower Blue";
            newrow.BoardColor = "Rebecca Purple";
            newrow.OpponentColor = "Blanched Almond";

            dc.tblSettings.Add(newrow);
            var results = dc.SaveChanges();

            Assert.IsTrue(results == 1);
        }

        [TestMethod]
        public void UpdateTest()
        {
            InsertTest();

            tblSetting existingrow = dc.tblSettings.FirstOrDefault(c => c.PlayerColor == "Cornflower Blue");


            existingrow.PlayerColor = "Updated Color";
            dc.Update(existingrow);
            int results = dc.SaveChanges();


            Assert.AreEqual(results, 1);
        }

        [TestMethod]
        public void DeleteTest()
        {
            InsertTest();

            tblSetting row = dc.tblSettings.FirstOrDefault(c => c.OpponentColor == "Blanched Almond");

            Guid deleted = row.Id;

            if (row != null)
            {
                dc.tblSettings.Remove(row);
                dc.SaveChanges();
            }

            tblSetting deletedrow = dc.tblSettings.FirstOrDefault(c => c.Id == deleted);

            Assert.IsNull(deletedrow);
        }
    }
}