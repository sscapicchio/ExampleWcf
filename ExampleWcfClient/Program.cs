using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;
using ExampleWcfClient.ServiceReference1;

namespace ExampleWcfClient
{
    class Program
    {
        /// <summary>
        /// Very simple example of creating an identifier and making common transactions with identifier.
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            RecordsKeeperClient client = new RecordsKeeperClient();

            string currentId = null;
            double moneyToAdd = 20;
            double moneyToSubtract = 4.55;

            try
            {
                /* Find the next ID (which in this case is the first ID), create the ID, add money, subract 
                 * money and get the balance. */
                currentId = client.GetNextAvailableIdentifier(); 
                client.AddPerson(currentId.ToString());
                client.AddMoney(moneyToAdd, currentId.ToString());
                client.SubractMoney(moneyToSubtract, currentId.ToString());
                Console.WriteLine("ID {0} has a balance of: ${1}.", currentId, client.GetBalance(currentId));

            }
            catch (IndexOutOfRangeException ioor)
            {
                Console.WriteLine("Invalid identifier. " + ioor.ToString());
                client.Abort();
            }
            catch (Exception e)
            {
                Console.WriteLine("Unable to perform service. " +e.ToString());
                client.Abort();
            }

            /* Change the values to keep it interesting */
            moneyToAdd = 35;
            moneyToSubtract = 11.01;

            try
            {
                /* Find the next ID, create the ID, add money, subract money and get the balance. */
                currentId = client.GetNextAvailableIdentifier();
                client.AddPerson(currentId);
                client.AddMoney(moneyToAdd, currentId);
                client.SubractMoney(moneyToSubtract, currentId);
                Console.WriteLine("ID {0} has a balance of: ${1}.", currentId, client.GetBalance(currentId));
            }
            catch (IndexOutOfRangeException ioor)
            {
                Console.WriteLine("Invalid identifier. " + ioor.ToString());
                client.Abort();
            }
            catch (Exception e)
            {
                Console.WriteLine("Unable to perform service. " + e.ToString());
                client.Abort();
            }

            if (client.State != CommunicationState.Closed)
            {
                client.Close();
            }
        }
    }
}
