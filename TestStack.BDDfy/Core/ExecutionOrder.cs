﻿namespace TestStack.BDDfy.Core
{
    public enum ExecutionOrder
    {
        Initialize = 1,
        SetupState = 2,
        ConsecutiveSetupState = 3,
        Transition = 4,
        ConsecutiveTransition = 5,
        Assertion = 6,
        ConsecutiveAssertion = 7,
        TearDown = 8
    }
}