using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace ExampleWcfLib
{
    public class RecordsKeeperService : IRecordsKeeper
    {
        /**** Ned - Note the use of the 'SortedList' collection, now we just need infinity customers... ****/
        private SortedList<string, double> _db = new  SortedList<string, double>();
        private bool _consoleDebug=true;

        /// <summary>
        /// Method for determining next available identifier.
        /// </summary>
        /// <returns>returns next available customer intentifier as a string</returns>
        public string GetNextAvailableIdentifier()
        {
            int id = 0;
            while (true)
            {
                if (!_db.ContainsKey(id.ToString()))
                {
                    return id.ToString();
                }
                id++;
            }
        }

        /// <summary>
        /// Adds person into the identifier database.
        /// </summary>
        /// <param name="identifier"></param>
        /// <exception cref="Exception">Identifier cannot be added to the database.</exception>
        /// <returns>Success/Failure</returns>
        public bool AddPerson(string identifier)
        {
            if (_db.ContainsKey(identifier))
            {
                /* ID already exists, simply return.  Obviously in a real world situation there would
                 * need to be a more complicated structure to handle this case */
                return true;
            }
            try
            {
                _db.Add(identifier, 0.0D);
            }
            catch (Exception e)
            {
                Console.WriteLine("Failed to add new identifier" + e.ToString());
                return false;
            }
            if (_consoleDebug)
            {
                Console.WriteLine("Successfully added identifier: " + identifier);
            }
            return true;
        }

        /// <summary>
        /// Add money to specified identifier.
        /// </summary>
        /// <param name="valueToAdd"></param>
        /// <param name="identifier"></param>
        /// <exception cref="IndexOutOfRangeException">If identifier does not exist in database</exception>
        /// <returns>Current balance after money is added</returns>
        public double AddMoney(double valueToAdd, string identifier)
        {
            if (!_db.ContainsKey(identifier))
            {
                throw new IndexOutOfRangeException("Identifier does not exist while attempting to add money.");
            }
            _db[identifier] += valueToAdd;
            if (_consoleDebug)
            {
                Console.WriteLine("Added ${0} to id: {1}, for a current balance of {2}", valueToAdd, identifier, _db[identifier]);
            }
            return _db[identifier];
        }

        /// <summary>
        /// Subract money from identifier balance
        /// </summary>
        /// <param name="valueToSubtract"></param>
        /// <param name="identifier"></param>
        /// <exception cref="IndexOutOfRangeException">Identifier does not exist while attempting to subract money.</exception>
        /// <exception cref="ArgumentOutOfRangeException">Not enough money to subract the requested amount.</exception>
        /// <returns>current balance after money is subracted</returns>
        public double SubractMoney(double valueToSubtract, string identifier)
        {
            if (!_db.ContainsKey(identifier))
            {
                throw new IndexOutOfRangeException("Identifier does not exist while attempting to subtract money.");
            }
            if ((_db[identifier] - valueToSubtract) < 0)
            {
                Console.WriteLine("Identifier {0} does not have enough money to subract ${}.", identifier, valueToSubtract);
                throw new ArgumentOutOfRangeException("Not enough money to subtract.");
            }

            _db[identifier] -= valueToSubtract;
            if (_consoleDebug)
            {
                Console.WriteLine("Subracted ${0} to id: {1}, for a current balance of {2}", valueToSubtract, identifier, _db[identifier]);
            }
            return _db[identifier];    
        }

        /// <summary>
        /// Get current balance of specified identifier.
        /// </summary>
        /// <param name="identifier"></param>
        /// /// <exception cref="IndexOutOfRangeException">Identifier does not exist while attempting to get balance.</exception>
        /// <returns>current balance</returns>
        public double GetBalance(string identifier)
        {
            if (!_db.ContainsKey(identifier))
            {
                throw new IndexOutOfRangeException("Identifier does not exist while attempting to get balance.");
            }
            if (_consoleDebug)
            {
                Console.WriteLine("Current balance of id: {0} = {1}", identifier, _db[identifier]);
            }
            return _db[identifier];              
        }
    }
}
