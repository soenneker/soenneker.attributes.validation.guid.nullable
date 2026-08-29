using AwesomeAssertions;
using Soenneker.Tests.Unit;

namespace Soenneker.Attributes.Validation.Guid.Nullable.Tests;

public sealed class NullableGuidValidationAttributeTests : UnitTest
{
    [Test]
    public void Default()
    {

    }

    [Test]
    public void Null_value_should_validate()
    {
        var attribute = new NullableGuidValidationAttribute();

        attribute.IsValid(null).Should().BeTrue();
    }

    [Test]
    public void Valid_guid_should_validate()
    {
        var attribute = new NullableGuidValidationAttribute();

        attribute.IsValid(Faker.Random.Guid().ToString()).Should().BeTrue();
    }

    [Test]
    public void Empty_guid_should_not_validate()
    {
        var attribute = new NullableGuidValidationAttribute();

        attribute.IsValid(System.Guid.Empty.ToString()).Should().BeFalse();
    }

    [Test]
    public void Non_string_value_should_not_validate()
    {
        var attribute = new NullableGuidValidationAttribute();

        attribute.IsValid(123).Should().BeFalse();
    }
}
