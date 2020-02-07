using Reply.Shared;
using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.IO;
using System.Text;

namespace Reply.Infra.ReplyContext.DataContext
{
    /// <summary>
    /// Class centralize open/close DataBase
    /// </summary>
    public class ReplyDataContext: IDisposable
    {
        public SQLiteConnection Connection { get; set; }

        public ReplyDataContext()
        {
          
            Connection = new SQLiteConnection(Settings.ConnectionString);
            Connection.Open();


        }

        public void Dispose()
        {
            if (Connection.State != System.Data.ConnectionState.Closed)
            {
                Connection.Close();
            }
        }
    }
}
