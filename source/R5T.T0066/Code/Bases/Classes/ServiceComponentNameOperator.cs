using System;


namespace R5T.T0066
{
    /// <summary>
    /// Empty implementation as base for extension methods.
    /// </summary>
    public class ServiceComponentNameOperator : IServiceComponentNameOperator
    {
        #region Static
        
        public static ServiceComponentNameOperator Instance { get; } = new();

        #endregion
    }
}