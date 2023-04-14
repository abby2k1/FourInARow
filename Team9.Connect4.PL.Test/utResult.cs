using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Microsoft.EntityFrameworkCore.Storage;
using Team9.Connect4.PL;
using System.Security.Authentication.ExtendedProtection;

namespace Team9.Connect4.PL.Test
{
    [TestClass]
    public class utResult
    {
        protected Connect4Entities dc;
        protected IDbContextTransaction transaction;
        protected Guid testId = new Guid();

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
            var rows = dc.tblResults;

            actual = rows.Count();

            // Test to see if I got the right amount.
            Assert.AreEqual(expected, actual);

        }

        [TestMethod]
        public void InsertTest()
        {
            // Create a new row in memory
            tblResult newrow = new tblResult();

            // Set the properties
            newrow.Id = testId;
            newrow.WinnerId = null;
            newrow.LoserID = null;
            newrow.Turns = 0;

            // Insert the row into the table
            dc.tblResults.Add(newrow);
            int result = dc.SaveChanges();

            Assert.IsTrue(result == 1);
        }

        [TestMethod]
        public void UpdateTest()
        {
            // Create a new row in memory
            tblResult newrow = new tblResult();

            // Set the properties
            newrow.Id = testId;
            newrow.WinnerId = null;
            newrow.LoserID = null;
            newrow.Turns = 0;

            // Insert the row into the table
            dc.tblResults.Add(newrow);

            // Get a row to update
            // SELECT * FROM tblProgram dt where Id = 2

            dc.SaveChanges();
           
            // Set the properties
            newrow.Turns = 2;

            // Update the row into the table
            dc.tblResults.Update(newrow);

            int result = dc.SaveChanges();

            Assert.IsTrue(result == 1);
        }

        [TestMethod]
        public void DeleteTest()
        {
            // Create a new row in memory
            tblResult newrow = new tblResult();

            // Set the properties
            newrow.Id = testId;
            newrow.WinnerId = null;
            newrow.LoserID = null;
            newrow.Turns = 0;

            // Insert the row into the table
            dc.tblResults.Add(newrow);
            dc.SaveChanges();
            // Get a row to update
            // SELECT * FROM tblProgram dt where Id = 2
            tblResult row = (from dt in dc.tblResults
                             where dt.Id == testId
                             select dt).FirstOrDefault();

            if (row != null)
            {

                // Delete the row into the table
                dc.tblResults.Remove(row);
                int result = dc.SaveChanges();

                Assert.AreNotEqual(0, result);
            }
        }
    }
}
