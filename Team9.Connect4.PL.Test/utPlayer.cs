﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Microsoft.EntityFrameworkCore.Storage;
using Team9.Connect4.PL;

namespace Team9.Connect4.PL.Test
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
        public void LoadTest()
        {
            InsertTest();

            // How many I expect
            int expected = 4;
            // How many I did get back
            int actual = 0;

            // Get the rows. SELECT * FROM tblProgram
            // var rows = from dt in dc.tblPrograms;
            var rows = dc.tblPlayers;

            actual = rows.Count();

            // Test to see if I got the right amount.
            Assert.AreEqual(expected, actual);

        }

        [TestMethod]
        public void InsertTest()
        {
            // Create a new row in memory
            tblPlayer newrow = new tblPlayer();

            // Set the properties
            newrow.Id = Guid.NewGuid();
            newrow.Username = "My new UserName";
            newrow.Password = "Password123";
            newrow.SettingId = dc.tblSettings.FirstOrDefault().Id;

            // Insert the row into the table
            dc.tblPlayers.Add(newrow);
            int result = dc.SaveChanges();

            Assert.IsTrue(result == 1);
        }

        [TestMethod]
        public void UpdateTest()
        {
            // Get a row to update
            // SELECT * FROM tblProgram dt where Id = 2
            tblPlayer row = (from dt in dc.tblPlayers
                             where dt.Password == "Maple"
                             select dt).FirstOrDefault();

            if (row != null)
            {
                // Set the properties
                row.Username = "My new UserName";

                // Update the row into the table
                int result = dc.SaveChanges();

                Assert.IsTrue(result == 1);
            }
        }

        [TestMethod]
        public void DeleteTest()
        {
            InsertTest();

            tblPlayer row = dc.tblPlayers.FirstOrDefault(c => c.Username == "My new UserName");

            if (row != null)
            {
                dc.tblPlayers.Remove(row);
                dc.SaveChanges();
            }

            tblSetting deletedrow = dc.tblSettings.FirstOrDefault(c => c.PlayerColor == "My new UserName");

            Assert.IsNull(deletedrow);
        }
    }
}
