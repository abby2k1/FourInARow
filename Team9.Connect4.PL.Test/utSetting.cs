using Microsoft.EntityFrameworkCore.Storage;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Team9.Connect4.PL.Test
{
    [TestClass]
    public class utSetting
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
        public void LoadTest()
        {
            int expected = 3;
            int actual;

            var rows = dc.tblSettings;
            actual = rows.Count();

            Assert.AreEqual(expected, actual);
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

            tblSetting existingrow = dc.tblSettings.FirstOrDefault(c => c.PlayerColor == "Rebecca Purple");

            if (existingrow != null)
            {
                existingrow.PlayerColor = "Updated Color";
                dc.SaveChanges();
            }

            tblSetting row = dc.tblSettings.FirstOrDefault(c => c.PlayerColor == "Updated Color");

            Assert.AreEqual(existingrow.PlayerColor, row.PlayerColor);
        }

        [TestMethod]
        public void DeleteTest()
        {
            InsertTest();

            tblSetting row = dc.tblSettings.FirstOrDefault(c => c.PlayerColor == "Blanched Almond");

            if (row != null)
            {
                dc.tblSettings.Remove(row);
                dc.SaveChanges();
            }

            tblSetting deletedrow = dc.tblSettings.FirstOrDefault(c => c.PlayerColor == "Blanched Almond");

            Assert.IsNull(deletedrow);
        }

    }
}
