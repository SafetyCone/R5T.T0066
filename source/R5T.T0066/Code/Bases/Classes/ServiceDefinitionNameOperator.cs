using System;


namespace R5T.T0066
{
    /// <summary>
    /// Empty implementation as base for extension methods.
    /// </summary>
    public class ServiceDefinitionNameOperator : IServiceDefinitionNameOperator
    {
        #region Static
        
        public static ServiceDefinitionNameOperator Instance { get; } = new();

        #endregion
    }
}