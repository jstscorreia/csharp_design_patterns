using System;

namespace DesignPatterns.Behavioral.State
{
    internal class AtmMachine : IAtmMachineState
    {
        public IAtmMachineState atmMachineState { get; set; }
        public AtmMachine()
        {
            atmMachineState = new CardNotInsertedState();
        }
        public void InsertCard()
        {
            if (atmMachineState is CardNotInsertedState)
            {
                atmMachineState.InsertCard();
                atmMachineState = new CardInsertedState();
                
            }
            Log.ShowMessage(string.Format("ATM Current State: {0}", atmMachineState.GetType().Name));
        }
        public void EjectCard()
        {
            if (atmMachineState is CardInsertedState)
            {
                atmMachineState = new CardNotInsertedState();
                atmMachineState.EjectCard(); 
            }
        }
        public void GetPIN()
        {
            if(atmMachineState is CardInsertedState)
                atmMachineState.GetPIN();
        }
        public void Withdraw()
        {   
            if(atmMachineState is CardInsertedState)
                atmMachineState.Withdraw();
        }
    }
}
