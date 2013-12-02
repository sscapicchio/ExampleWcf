using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace ExampleWcfLib
{
    [ServiceContract] //namespace would go here if I had one...
    public interface IRecordsKeeper
    {
        [OperationContract]
        string GetNextAvailableIdentifier();

        [OperationContract]
        bool AddPerson(string identifier);

        [OperationContract]
        double AddMoney(double valueToAdd, string identifier);

        [OperationContract]
        double SubractMoney(double valueToAdd, string identifier);

        [OperationContract]
        double GetBalance(string identifier);

    }

}
