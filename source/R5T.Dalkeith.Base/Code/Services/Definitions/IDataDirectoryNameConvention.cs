using System;

using R5T.T0064;


namespace R5T.Dalkeith
{
    [ServiceDefinitionMarker]
    public interface IDataDirectoryNameConvention : IServiceDefinition
    {
        string GetDataDirectoryName();
    }
}
