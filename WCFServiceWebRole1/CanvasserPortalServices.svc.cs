using CanvasserPortalWebApplication.Classes;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace WCFServiceWebRole1
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class CanvasserPortalService : ICanvasserPortalServices
    {
        private DBHelper Fact = null;

        public CanvasserPortalService()
        {
            this.Fact = new DBHelper();
        }

        public bool isUserCredentailsValid(string username, string password)
        {
            return true;
        }

        public string testDBConnections(string value)
        {
            try
            {
                string response = string.Empty;
                this.Fact.deleteStoredProcedurePrameters();
                this.Fact.AddStoredProcedureParameter("@Value", System.Data.SqlDbType.VarChar, value);
                DataSet ds = this.Fact.getDataSet("test", "test");
                if (ds != null)
                {
                    response = ds.Tables["test"].Rows[0][0].ToString();
                }
                else
                {
                    response =  "DataSet was null!";
                }
                return response;
                
            }
            catch (Exception ex)
            {
                return ex.Message;
            }

        }
    }
}
