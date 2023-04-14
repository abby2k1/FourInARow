using System;
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
            // How many I expect
            int expected = 3;
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
            newrow.Id = new Guid();
            newrow.Username = "My new UserName";


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
            // Get a row to update
            // SELECT * FROM tblProgram dt where Id = 2
            tblPlayer row = (from dt in dc.tblPlayers
                             where dt.Password == "Maple"
                             select dt).FirstOrDefault();

            if (row != null)
            {

                // Delete the row into the table
                dc.tblPlayers.Remove(row);
                int result = dc.SaveChanges();

                Assert.AreNotEqual(0, result);
            }
        }
    }
}
