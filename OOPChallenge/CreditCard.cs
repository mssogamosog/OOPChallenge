﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OOPChallenge;

namespace OOPChallenge
{
    public class CreditCard : PaymentMethod
    {
        private double number;
        private DateTime expDate;
        private int maxInstallElemtens;
        private Issuer issuer;
    }
}
