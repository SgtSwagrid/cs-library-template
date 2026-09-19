namespace MyLibrary;

/// <summary>A greeting addressed to someone.</summary>
/// <param name="Recipient">The name of the one being greeted.</param>
public record Greeting(
    string Recipient
);

/// <summary>Operations on <see cref="Greeting"/>.</summary>
public static class Greetings {

    extension(Greeting greeting) {

        /// <summary>Renders the greeting as text.</summary>
        /// <returns>A sentence such as <c>Hello, World!</c>.</returns>
        public string Format() => $"Hello, {greeting.Recipient}!";
    }
}
