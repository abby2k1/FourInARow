using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Storage;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using Team9.Connect4.BL.Models;
using Team9.Connect4.PL;

namespace Team9.Connect4.BL
{
    public  class PlayerManager
    {
        private const string RowError = "Row doesn't exist.";

        public async static Task<IEnumerable<Player>> Load()
        {
            try
            {
                List<Player> players = new List<Player>();
                using (Connect4Entities dc = new Connect4Entities())
                {
                    (await dc.tblPlayers
                        .ToListAsync()
                        .ConfigureAwait(false))
                        .ForEach(p => players.Add(new Player
                        {
                            Id = p.Id,
                            Username = p.Username,
                            Password = p.Password,
                            SettingId = p.SettingId
                        }));
                }
                return players;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
        public async static Task<int> Insert(Player player, bool rollback = false)
        {
            try
            {
                IDbContextTransaction dbContextTransaction = null;
                using (Connect4Entities dc = new Connect4Entities())
                {
                    if (rollback) dbContextTransaction = dc.Database.BeginTransaction();

                    tblPlayer newrow = new tblPlayer();
                    newrow.Id = Guid.NewGuid();
                    newrow.Username = player.Username;
                    newrow.Password = player.Password;
                    newrow.SettingId = player.SettingId;

                    dc.tblPlayers.Add(newrow);
                    int results = dc.SaveChanges();

                    if (rollback) dbContextTransaction.Rollback();
                    return results;
                }
            }
            catch (Exception ex) 
            { 
                throw ex; 
            }
        }

        public async static Task<int> Update(Player player, bool rollback = false)
        {
            try
            {
                int results = 0;
                using (Connect4Entities dc = new Connect4Entities())
                {
                    IDbContextTransaction dbContextTransaction = null;
                    if (rollback) dbContextTransaction = dc.Database.BeginTransaction();

                    tblPlayer row = dc.tblPlayers.Where(p => p.Id == player.Id).FirstOrDefault();

                    if (row != null)
                    {
                        row.Username = player.Username;
                        row.Password = player.Password;
                        row.SettingId = player.SettingId;

                        results = dc.SaveChanges();

                        if (rollback) dbContextTransaction.Rollback();
                    }
                    else
                    {

                        throw new Exception(RowError);
                    }
                }
                return results;
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
                int results = 0;
                using (Connect4Entities dc = new Connect4Entities())
                {
                    IDbContextTransaction dbContextTransaction = null;
                    if (rollback) dbContextTransaction = dc.Database.BeginTransaction();

                    tblPlayer row = dc.tblPlayers.Where(p => p.Id == id).FirstOrDefault();

                    if (row != null)
                    {
                        dc.tblPlayers.Remove(row);
                        results = dc.SaveChanges();

                        if (rollback) dbContextTransaction.Rollback();
                    }
                    else
                    {
                        throw new Exception(RowError);
                    }
                }
                return results;
            }
            catch(Exception ex)
            {
                throw ex;
            }
            
        }
    }
}
