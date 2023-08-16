
namespace ShapeTests;

[TestFixture]
public class CircleTests
{
    [Test]
    public void GetArea_ReturnsRightResult()
    {
        //Arrange
        var circle = new Circle( 2);
        
        //Act & Assert
        Assert.AreEqual(12.566370614359172, circle.GetArea());
    }
}