using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Storage;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Team9.Connect4.BL;
using Team9.Connect4.BL.Models;
using Team9.Connect4.PL;

namespace Team9.Connect4.BL.Test
{
    [TestClass]
    public class utSetting
    {
        protected Connect4Entities dc = new Connect4Entities();

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
            //c => c.SettingId != null

            var results = SettingManager.LoadByPlayerId(guid);

            Assert.IsNotNull(results);
        }

        [TestMethod]
        public void InsertTest()
        {
            Setting setting = new Setting();

            setting.Id = new Guid();
            setting.PlayerColor = Color.Blue;
            setting.BoardColor = Color.BlanchedAlmond;
            setting.OpponentColor = Color.Magenta;

            var results = SettingManager.Insert(setting, true);
            Assert.IsNotNull(results);
        }

        [TestMethod]
        public async Task UpdateTest()
        {
            Guid guid = dc.tblSettings.FirstOrDefault().Id;
            
            Setting setting = await SettingManager.Load(guid);

            setting.BoardColor = Color.PeachPuff;

            var results = SettingManager.Update(setting, true);
            Assert.IsNotNull(results);
        }

        [TestMethod]
        public async Task DeleteTest()
        {
            Guid guid = dc.tblSettings.GetType().GUID;

            var results = SettingManager.Delete(guid, true);
            Assert.IsNotNull(results);
        }
    }
}