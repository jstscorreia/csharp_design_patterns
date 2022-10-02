using System;
using System.Reflection;

namespace DesignPatterns.Behavioral.State
{
    internal class CardInsertedState : IAtmMachineState
    {
        public void InsertCard()
        {
            Log.ShowMessage(MethodBase.GetCurrentMethod().Name, "Invalid option.Card is inserted.");
        }
        public void EjectCard()
        {
            Log.ShowMessage(MethodBase.GetCurrentMethod().Name, "Card ejected.");
        }
        public void GetPIN()
        {
            Log.ShowMessage(MethodBase.GetCurrentMethod().Name, "The pin was read successfully.");
        }
        public void Withdraw()
        {
            Log.ShowMessage(MethodBase.GetCurrentMethod().Name, "Withdraw was successfully.");
        }
    }
}
