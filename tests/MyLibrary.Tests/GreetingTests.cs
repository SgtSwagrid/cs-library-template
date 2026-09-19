namespace MyLibrary.Tests;

public class GreetingTests {

    [Fact]
    public void FormatAddressesTheRecipient() =>
        Assert.Equal("Hello, World!", new Greeting("World").Format());
}
