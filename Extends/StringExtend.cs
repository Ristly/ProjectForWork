﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectForWork.Extends;

public static class StringExtend
{
    public static string? FirstCharToLowerCase(this string? str)
    {
        if (!string.IsNullOrEmpty(str) && char.IsUpper(str[0]) && str is not null)
            return str.Length == 1 ? char.ToLower(str[0]).ToString() : char.ToLower(str[0]) + str[1..];

        return str;
    }
}
