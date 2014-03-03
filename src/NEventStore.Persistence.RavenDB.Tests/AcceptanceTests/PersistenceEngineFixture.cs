﻿// ReSharper disable once CheckNamespace
namespace NEventStore.Persistence.AcceptanceTests
{
    using NEventStore.Persistence.RavenDB.Tests;

    public partial class PersistenceEngineFixture
    {
        public PersistenceEngineFixture()
        {
            _createPersistence = _ => new InMemoryRavenPersistenceFactory(TestRavenConfig.GetDefaultConfig()).Build();
        }
    }
}