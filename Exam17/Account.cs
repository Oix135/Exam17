namespace Exam17
{
    internal class Account : IAccount
    {
        public AccountType Type { get; set; }
        public double Balance { get; set; }
        public double Interest { get; set; }

        public void CalculateInterest()
        {
            if (Type == AccountType.Обычный)
            {
                Interest = Math.Round(Balance * 0.4, 2);
                if (Balance < 1000)
                    Interest -= Math.Round(Balance * 0.2, 2);

                if (Balance >= 1000)
                {
                    //Тут будет 0! Похоже, банк все украдёт.
                    //Не уверен в таких правилах, но на правду похоже
                    Interest -= Math.Round(Balance * 0.4, 2);
                }
            }
            else if (Type == AccountType.Зарплатный)
            {
                Interest = Math.Round(Balance * 0.5, 2);
            }
        }
    }
}
