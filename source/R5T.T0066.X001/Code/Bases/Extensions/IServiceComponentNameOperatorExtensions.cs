using System;

using R5T.T0066;

using Instances = R5T.T0066.X001.Instances;


namespace System
{
    public static class IServiceComponentNameOperatorExtensions
    {
        public static string GetServiceTypeNameStemFromDefinitionTypeName(this IServiceComponentNameOperator _,
            string serviceDefinitionTypeName)
        {
            var output = Instances.TypeNameOperator.GetTypeNameStem_HandleInterface(
                serviceDefinitionTypeName);

            return output;
        }
    }
}