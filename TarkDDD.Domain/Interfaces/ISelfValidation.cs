﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TarkDDD.Domain.Interfaces
{
    public interface ISelfValidation
    {
        Validations.ValidationResult Validate();        
    }
}
