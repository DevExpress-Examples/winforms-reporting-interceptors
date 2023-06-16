using DevExpress.DataAccess.Sql;
using System.Data;

namespace XtraReportApp {
    internal class NolockInterceptor : IDBCommandInterceptor {
        public void CommandCreated(string queryName, IDbCommand command) {
            command.CommandText += " WITH (NOLOCK)";
        }
    }
}
