using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClientManagement
{
    class Client
    {

        public string clientName;
        public string clientPolicyID;
        public string clientStreetAddress;
        public string clientCityStateZip;
        public string clientDOB;

        public Client(string inName, string inPolicyID, string inStreetAddress, string inCityStateZip, string inDOB)
        {
            clientName = inName;
            clientPolicyID = inPolicyID;
            clientStreetAddress = inStreetAddress;
            clientCityStateZip = inCityStateZip;
            clientDOB = inDOB;
        }

    }
}
