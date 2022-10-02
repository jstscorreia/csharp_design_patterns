using DesignPatterns;
using DesignPatterns.Behavioral.State;

Console.WriteLine("Start");

#region State

AtmMachine atmMachine = new AtmMachine();
Console.WriteLine("---------------------");
Log.ShowMessage(string.Format("ATM Current State: {0}",atmMachine.atmMachineState.GetType().Name));

Console.WriteLine("Please insert your card:");
atmMachine.InsertCard();
Log.ShowMessage(string.Format("ATM Current State: {0}", atmMachine.atmMachineState.GetType().Name));


Console.WriteLine("Please inform your PIN:");
atmMachine.GetPIN();
Log.ShowMessage(string.Format("ATM Current State: {0}", atmMachine.atmMachineState.GetType().Name));


Console.WriteLine("Please inform the amount to withdraw:");
atmMachine.Withdraw();
Log.ShowMessage(string.Format("ATM Current State: {0}", atmMachine.atmMachineState.GetType().Name));
Console.WriteLine("Withdraw is done. The system will eject your card.");


atmMachine.EjectCard();
Console.WriteLine("---------------------");
Log.ShowMessage(string.Format("ATM Current State: {0}", atmMachine.atmMachineState.GetType().Name));


Console.WriteLine("Press any key to exit.");
Console.ReadKey();
#endregion State