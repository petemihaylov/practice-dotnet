﻿using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceSegregation.Library
{
    interface IBorrowableBook : IBorrowable, IBook
    {
    }
}
