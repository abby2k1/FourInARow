using Microsoft.EntityFrameworkCore.Storage;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Team9.Connect4.BL.Models;
using Team9.Connect4.PL;

namespace Team9.Connect4.BL
{
    public class GameManager
    {
        public async static Task<int> Insert(Game game, bool rollback = false)
        {
            try
            {
                IDbContextTransaction transaction = null;

                using (Connect4Entities dc = new Connect4Entities())
                {
                    if (rollback) transaction = dc.Database.BeginTransaction();

                    tblResult newrow = new tblResult();
                    newrow.Id = Guid.NewGuid();
                    newrow.Turns = game.Turns;
                    newrow.WinnerId = game.WinnerId;
                    newrow.LoserID = game.LoserId;

                    game.Id = newrow.Id;

                    dc.tblResults.Add(newrow);
                    int results = dc.SaveChanges();

                    if (rollback) transaction.Rollback();

                    return results;
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
        public async static Task<int> Delete(Guid id, bool rollback = false)
        {
            try
            {
                IDbContextTransaction transaction = null;
                using (Connect4Entities dc = new Connect4Entities())
                {

                    tblResult row = dc.tblResults.FirstOrDefault(c => c.Id == id);
                    int results = 0;
                    if (row != null)
                    {
                        if (rollback) transaction = dc.Database.BeginTransaction();

                        dc.tblResults.Remove(row);
                        results = dc.SaveChanges();
                        if (rollback) transaction.Rollback();

                    }
                    else
                    {
                        throw new Exception("Row was not found.");
                    }
                    return results;
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public async static Task<int> Update(Game game, bool rollback = false)
        {
            try
            {
                IDbContextTransaction transaction = null;
                using (Connect4Entities dc = new Connect4Entities())
                {
                    tblResult row = dc.tblResults.FirstOrDefault(c => c.Id == game.Id);
                    int results = 0;
                    if (row != null)
                    {
                        if (rollback) transaction = dc.Database.BeginTransaction();
                        row.Id = Guid.NewGuid();
                        row.Turns = game.Turns;
                        row.WinnerId = game.WinnerId;
                        row.LoserID = game.LoserId;
                        results = dc.SaveChanges();
                        if (rollback) transaction.Rollback();

                    }
                    else
                    {
                        throw new Exception("Row was not found.");
                    }
                    return results;
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
        public async static Task<IEnumerable<Game>> Load()
        {
            try
            {
                List<Game> games = new List<Game>();
                using (Connect4Entities dc = new Connect4Entities())
                {
                    dc.tblResults
                        .ToList()
                        .ForEach(c => games.Add(new Game
                        {
                            Id = c.Id,
                            Turns = c.Turns,
                            WinnerId = (Guid)c.WinnerId,
                            LoserId = (Guid)c.LoserID
                        }));
                }
                return games;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
    }
}
