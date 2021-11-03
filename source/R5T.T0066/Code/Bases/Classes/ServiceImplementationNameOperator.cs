using System;


namespace R5T.T0066
{
    /// <summary>
    /// Empty implementation as base for extension methods.
    /// </summary>
    public class ServiceImplementationNameOperator : IServiceImplementationNameOperator
    {
        #region Static
        
        public static ServiceImplementationNameOperator Instance { get; } = new();

        #endregion
    }
}