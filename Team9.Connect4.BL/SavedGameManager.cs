using Microsoft.EntityFrameworkCore.Storage;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Team9.Connect4.BL.Models;
using Team9.Connect4.PL;

namespace Team9.Connect4.BL
{
    public class SavedGameManager
    {
        public async static Task<int> Insert(SavedGame savedGame, bool rollback = false)
        {
            try
            {
                IDbContextTransaction transaction = null;

                using (Connect4Entities dc = new Connect4Entities())
                {
                    if (rollback) transaction = dc.Database.BeginTransaction();

                    tblSavedGame newrow = new tblSavedGame();
                    newrow.Id = Guid.NewGuid();
                    newrow.ResultsId = savedGame.ResultsId;
                    newrow.Player1Id = savedGame.Player1Id;
                    newrow.Player2Id = savedGame.Player2Id;
                    newrow.BoardState = savedGame.BoardState;
                    newrow.GameCode = savedGame.GameCode;

                    savedGame.Id = newrow.Id;

                    dc.tblSavedGames.Add(newrow);
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

                    tblSavedGame row = dc.tblSavedGames.FirstOrDefault(c => c.Id == id);
                    int results = 0;
                    if (row != null)
                    {
                        if (rollback) transaction = dc.Database.BeginTransaction();

                        dc.tblSavedGames.Remove(row);
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

        public async static Task<int> Update(SavedGame savedGame, bool rollback = false)
        {
            try
            {
                IDbContextTransaction transaction = null;
                using (Connect4Entities dc = new Connect4Entities())
                {
                    tblSavedGame row = dc.tblSavedGames.FirstOrDefault(c => c.Id == savedGame.Id);
                    int results = 0;
                    if (row != null)
                    {
                        if (rollback) transaction = dc.Database.BeginTransaction();
                        row.Id = Guid.NewGuid();
                        row.ResultsId = savedGame.ResultsId;
                        row.Player1Id = savedGame.Player1Id;
                        row.Player2Id = savedGame.Player2Id;
                        row.BoardState = savedGame.BoardState;
                        row.GameCode = savedGame.GameCode;
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
        public async static Task<IEnumerable<SavedGame>> Load()
        {
            try
            {
                List<SavedGame> savedGames = new List<SavedGame>();
                using (Connect4Entities dc = new Connect4Entities())
                {
                    dc.tblSavedGames
                        .ToList()
                        .ForEach(c => savedGames.Add(new SavedGame
                        {
                            Id = c.Id,
                            ResultsId = (Guid)c.ResultsId,
                            Player1Id = (Guid)c.Player1Id,
                            Player2Id = (Guid)c.Player2Id,
                            BoardState = c.BoardState,
                            GameCode = c.GameCode
                        }));
                }
                return savedGames;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
        public async static Task<SavedGame> Load(Guid id)
        {
            Connect4Entities dc = new Connect4Entities();
            tblSavedGame tblSavedGame = new tblSavedGame();
            tblSavedGame = await dc.tblSavedGames.FindAsync(id);
            SavedGame savedGame = new SavedGame();
            savedGame.Id = tblSavedGame.Id;
            savedGame.ResultsId = tblSavedGame.ResultsId;
            savedGame.Player1Id = tblSavedGame.Player1Id;
            savedGame.Player2Id = tblSavedGame.Player2Id;
            savedGame.BoardState = tblSavedGame.BoardState;
            savedGame.GameCode = tblSavedGame.GameCode;

            return savedGame;
        }

        public async static Task<SavedGame> Load(string gameCode)
        {
            Connect4Entities dc = new Connect4Entities();
            tblSavedGame tblSavedGame = new tblSavedGame();
            tblSavedGame = dc.tblSavedGames.FirstOrDefault(c => c.GameCode == gameCode);
            SavedGame savedGame = new SavedGame();
            savedGame.Id = tblSavedGame.Id;
            savedGame.ResultsId = tblSavedGame.ResultsId;
            savedGame.Player1Id = tblSavedGame.Player1Id;
            savedGame.Player2Id = tblSavedGame.Player2Id;
            savedGame.BoardState = tblSavedGame.BoardState;
            savedGame.GameCode = tblSavedGame.GameCode;
            return savedGame;
        }
    }
}
