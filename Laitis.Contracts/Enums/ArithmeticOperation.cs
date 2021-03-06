﻿namespace Laitis.Contracts.Enums
{
    /// <summary>
    /// Used for Laitis SetVariableValue Actions
    /// 
    /// <seealso cref="ActionType.SetVariableValue"/>
    /// </summary>
    public enum ArithmeticOperation
    {
        /// <summary>
        /// Do nothing, return first operand
        /// </summary>
        None = 0,

        /// <summary>
        /// +
        /// </summary>
        Add = 1,

        /// <summary>
        /// -
        /// </summary>
        Substract = 2,

        /// <summary>
        /// *
        /// </summary>
        Multiply = 3,

        /// <summary>
        /// /
        /// </summary>
        Divide = 4,

        /// <summary>
        /// %
        /// </summary>
        Modulo = 5,
        
        /// <summary>
        /// ^
        /// </summary>
        Pow = 6,
        
        /// <summary>
        /// Root
        /// </summary>
        Sqrt = 7,
        
        /// <summary>
        /// Max
        /// </summary>
        Max = 8,
        
        /// <summary>
        /// Min
        /// </summary>
        Min = 9,
        
        /// <summary>
        /// Abs
        /// </summary>
        Abs = 10,
        
        /// <summary>
        /// Round
        /// </summary>
        Round = 11,
        
        /// <summary>
        /// Random
        /// </summary>
        Rand = 12,
        
        /// <summary>
        /// String replace
        /// </summary>
        Replace = 13,
        
        /// <summary>
        /// Replace word in string
        /// </summary>
        WordReplace = 14,

        /// <summary>
        /// Regular expression replace
        /// </summary>
        RegExReplace = 15,

        /// <summary>
        /// Regular expression matches
        /// </summary>
        RegExMatch = 16
    }
}
