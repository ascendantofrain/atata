﻿using OpenQA.Selenium;

namespace Atata
{
    public class WaitUntilNoElementByClassAttribute : WaitUntilNoElementAttribute
    {
        public WaitUntilNoElementByClassAttribute(string value, TriggerEvent on, TriggerPriority priority = TriggerPriority.Medium, TriggerScope appliesTo = TriggerScope.Self)
            : base(By.ClassName(value), on, priority, appliesTo)
        {
        }
    }
}
