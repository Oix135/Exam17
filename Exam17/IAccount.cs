﻿
namespace Exam17
{
    
    public interface IAccount
    {
        public AccountType Type { get; set; }

        // баланс учетной записи
        public double Balance { get; set; }

        // процентная ставка
        public double Interest { get; set; }
        void CalculateInterest();
    }
}
