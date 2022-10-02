using System;
using System.Reflection;

namespace DesignPatterns.Behavioral.State
{
    internal class CardNotInsertedState : IAtmMachineState
    {
        public void InsertCard()
        {
            Log.ShowMessage(MethodBase.GetCurrentMethod().Name,"Card inserted.");
        }
        public void EjectCard()
        {
            Log.ShowMessage(MethodBase.GetCurrentMethod().Name, "Card not inserted.Not possible to eject it.");
        }
        public void GetPIN()
        {
            Log.ShowMessage(MethodBase.GetCurrentMethod().Name, "Please insert the card.");
        }
        public void Withdraw()
        {
            Log.ShowMessage(MethodBase.GetCurrentMethod().Name, "Card not inserted.Not possible to withdraw.");
        }
    }
}
