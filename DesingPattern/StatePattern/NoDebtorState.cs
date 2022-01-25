using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesingPattern.StatePattern
{
    public class NoDebtorState : IState
    {
        public void Action(CustomerContext customerContext, decimal amount)
        {
            if (amount <= customerContext.Residue)
            {
                customerContext.Discount(amount);
                Console.WriteLine($"Solicitud es permitida, gastó {amount} y le queda de saldo {customerContext.Residue}");

                if(customerContext.Residue <= 0)
                {
                    customerContext.SetState(new DebtorState());
                }
            }
            else
            {
                Console.WriteLine($"No ajusta a lo solicitado, ya que tienes {customerContext.Residue} y quieres gastar {amount}");
            }
        }
    }
}
