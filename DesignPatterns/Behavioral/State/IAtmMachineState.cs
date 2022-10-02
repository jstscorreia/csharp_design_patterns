using System;

namespace DesignPatterns.Behavioral.State
{
    //State
    internal interface IAtmMachineState
    {
        void InsertCard();
        void EjectCard();
        void GetPIN();
        void Withdraw();
    }
}
