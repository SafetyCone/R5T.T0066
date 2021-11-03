using System;


namespace R5T.T0066
{
    /// <summary>
    /// Empty implementation as base for extension methods.
    /// </summary>
    public class ServiceComponentName : IServiceComponentName
    {
        #region Static
        
        public static ServiceComponentName Instance { get; } = new();

        #endregion
    }
}