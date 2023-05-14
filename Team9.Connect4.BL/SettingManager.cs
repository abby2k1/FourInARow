using Microsoft.EntityFrameworkCore.Storage;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;
using Team9.Connect4.BL.Models;
using Team9.Connect4.PL;

namespace Team9.Connect4.BL
{
    public class SettingManager
    {
        public async static Task<IEnumerable<Setting>> Load()
        {
            try
            {
                List<Setting> settings = new List<Setting>();
                using (Connect4Entities dc = new Connect4Entities())
                {
                    dc.tblSettings
                        .ToList()
                        .ForEach(c => settings.Add(new Setting
                        {
                            Id = c.Id,
                            BoardColor = c.BoardColor,
                            OpponentColor = c.OpponentColor,
                            PlayerColor = c.PlayerColor
                        }));
                }
                return settings;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public async static Task<Setting> Load(Guid id)
        {
            Connect4Entities dc = new Connect4Entities();
            tblSetting tblSetting = new tblSetting();
            tblSetting = await dc.tblSettings.FindAsync(id);
            Setting setting = new Setting();
            setting.Id = tblSetting.Id;
            setting.PlayerColor = tblSetting.PlayerColor;
            setting.OpponentColor = tblSetting.OpponentColor;
            setting.BoardColor = tblSetting.BoardColor;

            return setting;
        }

        public async static Task<Setting> LoadByPlayerId(Guid id)
        {
            Connect4Entities connect4Entities = new Connect4Entities();
            tblPlayer tblPlayer = new tblPlayer();
            tblPlayer = await connect4Entities.tblPlayers.FindAsync(id);
            tblSetting tblSetting = new tblSetting();
            tblSetting = await connect4Entities.tblSettings.FindAsync(tblPlayer.SettingId);
            Setting setting = new Setting();
            setting.Id = tblSetting.Id;
            setting.PlayerColor = tblSetting.PlayerColor;
            setting.OpponentColor = tblSetting.OpponentColor;
            setting.BoardColor = tblSetting.BoardColor;

            return setting;
        }

        public async static Task<int> Insert(Setting setting, bool rollback = false)
        {
            Connect4Entities connect4Entities = new Connect4Entities();
            tblSetting tblSetting = new tblSetting();
            tblSetting.Id = Guid.NewGuid();
            tblSetting.PlayerColor = setting.PlayerColor;
            tblSetting.OpponentColor = setting.OpponentColor;
            tblSetting.BoardColor = setting.BoardColor;

            using (IDbContextTransaction transaction = connect4Entities.Database.BeginTransaction())
            {
                try
                {
                    connect4Entities.tblSettings.Add(tblSetting);
                    int results = await connect4Entities.SaveChangesAsync();
                    if (rollback)
                    {
                        transaction.Rollback();
                    }
                    else
                    {
                        transaction.Commit();
                    }
                    return results;
                }
                catch (Exception ex)
                {
                    transaction.Rollback();
                    throw ex;
                }
            }
        }

        public async static Task<int> Update(Setting setting, bool rollback = false)
        {
            Connect4Entities connect4Entities = new Connect4Entities();
            tblSetting tblSetting = new tblSetting();
            tblSetting.Id = setting.Id;
            tblSetting.PlayerColor = setting.PlayerColor;
            tblSetting.OpponentColor = setting.OpponentColor;
            tblSetting.BoardColor = setting.BoardColor;

            using (IDbContextTransaction transaction = connect4Entities.Database.BeginTransaction())
            {
                try
                {
                    connect4Entities.tblSettings.Update(tblSetting);
                    int results = await connect4Entities.SaveChangesAsync();
                    if (rollback)
                    {
                        transaction.Rollback();
                    }
                    else
                    {
                        transaction.Commit();
                    }
                    return results;
                }
                catch (Exception ex)
                {
                    transaction.Rollback();
                    throw ex;
                }
            }
        }

        public async static Task<int> Delete(Guid id, bool rollback = false)
        {
            Connect4Entities dc = new Connect4Entities();
            tblSetting tblSetting = new tblSetting();
            tblSetting = await dc.tblSettings.FindAsync(id);
            if (tblSetting == null)
            {
                throw new Exception("Setting not found");
            }
            using (IDbContextTransaction transaction = dc.Database.BeginTransaction())
            {
                try
                {
                    dc.tblSettings.Remove(tblSetting);
                    int results = await dc.SaveChangesAsync();
                    if (rollback)
                    {
                        transaction.Rollback();
                    }
                    else
                    {
                        transaction.Commit();
                    }
                    return results;
                }
                catch (Exception ex)
                {
                    transaction.Rollback();
                    throw ex;
                }
            }
        }
    }
}
