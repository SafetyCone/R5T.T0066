using System;


namespace R5T.T0066
{
    /// <summary>
    /// Empty implementation as base for extension methods.
    /// </summary>
    public class ServiceDefinitionName : IServiceDefinitionName
    {
        #region Static
        
        public static ServiceDefinitionName Instance { get; } = new();

        #endregion
    }
}