namespace ClassWork_Zad_2
{
    public delegate void AccountStateHandler(string str);
    class Account
    {
        private int sum;

        public int Summ { get => sum; }

        public Account(int summ)
        {
            this.sum = summ;
        }

        public event AccountStateHandler Withdrawn = null;
        public event AccountStateHandler Added = null;

        public void Put(int sum)
        {
            if (sum < 0)
                throw new System.ArgumentNullException("Сумма меньше нуля!");


            this.sum += sum;

            if(Added != null)
            {
                Added.Invoke($"Вы на счет положили {sum}");
            }
        }

        public void Withdraw(int sum)
        {
            if (this.sum < sum)
            {
                System.Console.WriteLine("Вы не можете снять деньги на вашем счету не хватает средств");
                return;
            }else if (sum<0)
            {
                throw new System.ArgumentNullException("Сумма меньше нуля!");
            }

            this.sum -= sum;

            if (Withdrawn != null)
            {
                Withdrawn.Invoke($"Вы сняли со счета {sum}");
            }
        }
    }
}
