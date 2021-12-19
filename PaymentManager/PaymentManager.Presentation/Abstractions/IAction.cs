﻿namespace PaymentManager.Presentation.Abstractions
{
    public interface IAction
    {
        int MenuIndex { get; set; }
        string Label { get; set; }
        void Call();
    }
}
