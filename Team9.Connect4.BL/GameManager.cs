using Microsoft.EntityFrameworkCore.Storage;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
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
                    if (rollback) transaction = dc.Database.BeginTransaction();

                    tblSavedGame tblSavedGame = dc.tblSavedGames.FirstOrDefault(c => c.ResultsId == id);
                    if (tblSavedGame != null)
                    {
                        dc.tblSavedGames.Remove(tblSavedGame);
                    }

                    tblResult row = dc.tblResults.FirstOrDefault(c => c.Id == id);
                    int results = 0;
                    if (row != null)
                    {
                        dc.tblResults.Remove(row);
                        results = dc.SaveChanges();
                        if (rollback) transaction.Rollback();
                    }
                    else
                    {
                        if (rollback) transaction.Rollback();
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
                        //row.Id = Guid.NewGuid();
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

                    if (!rollback)
                    {
                        //CheckWinner();
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
                return games.OrderBy(c=>c.Turns);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public static void SendEmail(string userEmail)
        {
            try
            {

                SmtpClient mySmtpClient = new SmtpClient("smtp.outlook.com");

                // set smtp-client with basicAuthentication
                mySmtpClient.UseDefaultCredentials = false;
                System.Net.NetworkCredential basicAuthenticationInfo = new
                System.Net.NetworkCredential("username", "password");
                mySmtpClient.Credentials = basicAuthenticationInfo;
                mySmtpClient.EnableSsl = true;

                // add from,to mailaddresses
                MailAddress from = new MailAddress("300013555@fvtc.edu", "Max");
                MailAddress to = new MailAddress(userEmail, "TestToName");
                MailMessage myMail = new System.Net.Mail.MailMessage(from, to);

                // add ReplyTo
                MailAddress replyTo = new MailAddress("reply@example.com");
                myMail.ReplyToList.Add(replyTo);

                // set subject and encoding
                myMail.Subject = "Test message";
                myMail.SubjectEncoding = System.Text.Encoding.UTF8;

                // set body-message and encoding
                myMail.Body = "<b>Test Mail</b><br>using <b>HTML</b>.";
                myMail.BodyEncoding = System.Text.Encoding.UTF8;
                // text or html
                myMail.IsBodyHtml = true;

                mySmtpClient.Send(myMail);
            }

            catch (SmtpException ex)
            {
                throw new ApplicationException
                  ("SmtpException has occured: " + ex.Message);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
