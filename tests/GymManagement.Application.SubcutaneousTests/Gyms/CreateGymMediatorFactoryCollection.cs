namespace GymManagement.Application.SubcutaneousTests.Gyms;

[CollectionDefinition(CollectionName)]
public class CreateGymMediatorFactoryCollection : ICollectionFixture<CreateGymMediatorFactory>
{
    public const string CollectionName = "MediatorFactoryCollection";
}