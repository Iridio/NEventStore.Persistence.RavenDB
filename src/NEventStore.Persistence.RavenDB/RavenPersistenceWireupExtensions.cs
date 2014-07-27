using NEventStore.Persistence.RavenDB;

namespace NEventStore
{
  public static class RavenPersistenceWireupExtensions
  {
    public static RavenPersistenceWireup UsingRavenPersistence(this Wireup wireup, string connectionName)
    {
      return new RavenPersistenceWireup(wireup, connectionName);
    }

    public static RavenPersistenceWireup UsingRavenPersistence(this Wireup wireup, string connectionName, RavenPersistenceOptions options)
    {
      return new RavenPersistenceWireup(wireup, connectionName, options);
    }
  }

}